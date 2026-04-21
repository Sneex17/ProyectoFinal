using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;
using ClosedXML.Excel;

namespace CPresentacion
{
    public partial class FormEstadisticas : Form
    {
        private readonly TurnoRepository _turnoRepository;
        private readonly EspecialidadesRepositoty _especialidadesRepository;
        private DateTime? _fechaDesde;
        private DateTime? _fechaHasta;
        private int? _especialidadId;

        public FormEstadisticas()
        {
            InitializeComponent();
            _turnoRepository = new TurnoRepository();
            _especialidadesRepository = new EspecialidadesRepositoty();
            Load += FormEstadisticas_Load;
            btnFiltro.Click += btnFiltro_Click;
            btnExportar.Click += btnExportar_Click;
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today;
            CargarEspecialidades();
            CargarEstadisticas();
        }

        private void CargarEspecialidades()
        {
            try
            {
                cmbEspecialidades.DataSource = null;
                cmbEspecialidades.Items.Clear();
                
                var itemTodas = new Especialidade { EspecialidadId = 0, Nombre = "Todas las especialidades" };
                
                var especialidades = _especialidadesRepository.Listar();
                var listaCompleta = new List<Especialidade> { itemTodas };
                listaCompleta.AddRange(especialidades);
                
                cmbEspecialidades.DataSource = listaCompleta;
                cmbEspecialidades.DisplayMember = "Nombre";
                cmbEspecialidades.ValueMember = "EspecialidadId";
                cmbEspecialidades.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar especialidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstadisticas()
        {
            try
            {
                _fechaDesde = dtpDesde.Value.Date;
                _fechaHasta = dtpHasta.Value.Date;

                _especialidadId = null;

                var selectedItem = cmbEspecialidades.SelectedItem;
                
                if (selectedItem != null)
                {
                    if (selectedItem is Especialidade espItem)
                    {
                        if (espItem.EspecialidadId != 0)
                        {
                            _especialidadId = espItem.EspecialidadId;
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"SelectedItem type: {selectedItem.GetType().Name}, Value: {selectedItem}");
                    }
                }

                var stats = _turnoRepository.ObtenerEstadisticas(_fechaDesde, _fechaHasta, _especialidadId);
                var pacientes = _turnoRepository.ObtenerTotalPacientes(_fechaDesde, _fechaHasta, _especialidadId);

                lblPacientes.Text = pacientes.ToString();
                lblEnEspera.Text = stats.Creado.ToString();
                lblEnAtencion.Text = stats.EnAtencion.ToString();
                lblCanceladas.Text = stats.Cancelado.ToString();
                lblAtendidos.Text = stats.Atendido.ToString();

                var dt = _turnoRepository.ObtenerTurnosDetallados(_fechaDesde, _fechaHasta, _especialidadId);
                dgvEstadisticas.DataSource = dt;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                MessageBox.Show($"Error al cargar estadísticas: {ex.Message}\n\nStack: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarEstadisticas();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEstadisticas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Excel Files|*.xlsx";
                    saveDialog.FileName = $"Estadisticas_Turnos_{DateTime.Now:yyyyMMdd}";
                    
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToExcel(saveDialog.FileName);
                        MessageBox.Show($"Datos exportados exitosamente a:\n{saveDialog.FileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel(string filePath)
        {
            try
            {
                var dataTable = (DataTable)dgvEstadisticas.DataSource;
                
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Estadísticas");
                    
                    var tituloRange = worksheet.Range(1, 1, 1, dataTable.Columns.Count);
                    tituloRange.Merge();
                    tituloRange.Value = "REPORTE DE ESTADÍSTICAS - TURNOS HOSPITAL";
                    tituloRange.Style.Font.Bold = true;
                    tituloRange.Style.Font.FontSize = 14;
                    tituloRange.Style.Font.FontColor = ClosedXML.Excel.XLColor.FromHtml("#003366");
                    tituloRange.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                    
                    worksheet.Row(2).Merge();
                    var subtitleRange = worksheet.Cell(2, 1);
                    subtitleRange.Value = $"Período: {dtpDesde.Value:dd/MM/yyyy} - {dtpHasta.Value:dd/MM/yyyy}";
                    subtitleRange.Style.Font.FontSize = 11;
                    subtitleRange.Style.Font.FontColor = ClosedXML.Excel.XLColor.FromHtml("#666666");
                    
                    int startRow = 4;
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        var cell = worksheet.Cell(startRow, i + 1);
                        cell.Value = dataTable.Columns[i].ColumnName;
                        cell.Style.Font.Bold = true;
                        cell.Style.Font.FontColor = ClosedXML.Excel.XLColor.White;
                        cell.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.FromHtml("#003366");
                        cell.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                        cell.Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                    }
                    
                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            var cell = worksheet.Cell(startRow + 1 + row, col + 1);
                            cell.Value = dataTable.Rows[row][col]?.ToString() ?? "";
                            
                            if (row % 2 == 0)
                                cell.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.FromHtml("#E6F2FF");
                            else
                                cell.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.White;
                            
                            cell.Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                        }
                    }
                    
                    worksheet.Columns().AdjustToContents();
                    worksheet.Column(1).Width = 10;
                    worksheet.Column(2).Width = 10;
                    worksheet.Column(3).Width = 12;
                    worksheet.Column(4).Width = 15;
                    worksheet.Column(5).Width = 12;
                    
                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear Excel: {ex.Message}");
            }
        }
    }
}