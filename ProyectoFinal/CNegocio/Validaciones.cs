using CEntidades;
using CEntidades.Models;
using FluentValidation;
using System.Data;
namespace CNegocio
{
    public class ValidacionEspecialidades : AbstractValidator<Especialidade>
    {
        public ValidacionEspecialidades()
        {
            RuleFor(L => L.Nombre).NotEmpty().WithMessage("El nombre de la especialidad es obligatorio.");  
        }
    }

    public class ValidacionMedico : AbstractValidator<Medico>
    {
        public ValidacionMedico()
        {
            RuleFor(L => L.Nombre).NotEmpty().WithMessage("El nombre del médico es obligatorio.");
        }
    }
}
