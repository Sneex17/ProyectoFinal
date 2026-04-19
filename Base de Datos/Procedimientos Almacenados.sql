USE [GestionTurnosHospitalDB]
GO

-- =============================================
-- AUTENTICACIÓN
-- =============================================

CREATE OR ALTER PROCEDURE sp_Login
    @Usuario NVARCHAR(50),
    @Contrasena NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        u.UsuarioId,
        u.Usuario,
        u.RolId,
        r.Nombre AS RolNombre,
        u.EstadoId,
        e.Nombre AS EstadoNombre,
        CASE 
            WHEN u.RolId = 2 THEN m.MedicoId 
            WHEN u.RolId = 3 THEN rec.RecepcionistaId 
            ELSE NULL 
        END AS IdRelacionado
    FROM Usuarios u
    INNER JOIN Roles r ON u.RolId = r.RolId
    INNER JOIN Estados e ON u.EstadoId = e.EstadoId
    LEFT JOIN Medicos m ON u.UsuarioId = m.UsuarioId
    LEFT JOIN Recepcionistas rec ON u.UsuarioId = rec.UsuarioId
    WHERE u.Usuario = @Usuario 
        AND u.Contrasena = @Contrasena
        AND u.EstadoId = 1;
END
GO


-- =============================================
-- GESTIÓN DE PACIENTES
-- =============================================

CREATE OR ALTER PROCEDURE sp_InsertarPaciente
    @Cedula NVARCHAR(20),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @FechaNacimiento DATE,
    @Sexo CHAR(1),
    @Direccion NVARCHAR(255) = NULL,
    @Seguro NVARCHAR(100) = NULL,
    @Correo NVARCHAR(150) = NULL,
    @PacienteId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM Pacientes WHERE Cedula = @Cedula)
    BEGIN
        RAISERROR('Ya existe un paciente con esta cedula', 16, 1);
        RETURN -1;
    END
    
    INSERT INTO Pacientes (Cedula, Nombre, Apellido, FechaNacimiento, Sexo, Direccion, Seguro, Correo)
    VALUES (@Cedula, @Nombre, @Apellido, @FechaNacimiento, @Sexo, @Direccion, @Seguro, @Correo);
    
    SET @PacienteId = SCOPE_IDENTITY();
END
GO

CREATE OR ALTER PROCEDURE sp_ActualizarPaciente
    @PacienteId INT,
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @FechaNacimiento DATE,
    @Sexo CHAR(1),
    @Direccion NVARCHAR(255) = NULL,
    @Seguro NVARCHAR(100) = NULL,
    @Correo NVARCHAR(150) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE Pacientes
    SET Nombre = @Nombre,
        Apellido = @Apellido,
        FechaNacimiento = @FechaNacimiento,
        Sexo = @Sexo,
        Direccion = @Direccion,
        Seguro = @Seguro,
        Correo = @Correo
    WHERE PacienteId = @PacienteId;
END
GO

CREATE OR ALTER PROCEDURE sp_EliminarPaciente
    @PacienteId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM Turnos WHERE PacienteId = @PacienteId AND EstadoTurnoId IN (1, 2))
    BEGIN
        RAISERROR('El paciente tiene turnos activos. No se puede eliminar.', 16, 1);
        RETURN -1;
    END
    
    SELECT 1 AS Resultado, 'Paciente validado para eliminacion' AS Mensaje;
END
GO

CREATE OR ALTER PROCEDURE sp_BuscarPaciente
    @Cedula NVARCHAR(20) = NULL,
    @Nombre NVARCHAR(100) = NULL,
    @Codigo INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        PacienteId,
        Cedula,
        Nombre,
        Apellido,
        FechaNacimiento,
        Sexo,
        Direccion,
        Seguro,
        Correo
    FROM Pacientes
    WHERE (@Cedula IS NULL OR Cedula = @Cedula)
        AND (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%')
        AND (@Codigo IS NULL OR PacienteId = @Codigo);
END
GO

CREATE OR ALTER PROCEDURE sp_ListarPacientes
    @PageNumber INT = 1,
    @PageSize INT = 10,
    @Buscar NVARCHAR(100) = NULL,
    @OrdenarPor NVARCHAR(50) = 'PacienteId',
    @OrdenDireccion NVARCHAR(4) = 'ASC'
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @Skip INT = (@PageNumber - 1) * @PageSize;
    
    SELECT 
        PacienteId,
        Cedula,
        Nombre,
        Apellido,
        FechaNacimiento,
        Sexo,
        Direccion,
        Seguro,
        Correo,
        COUNT(*) OVER() AS TotalRegistros
    FROM Pacientes
    WHERE @Buscar IS NULL 
       OR Cedula LIKE '%' + @Buscar + '%' 
       OR Nombre LIKE '%' + @Buscar + '%' 
       OR Apellido LIKE '%' + @Buscar + '%'
    ORDER BY 
        CASE WHEN @OrdenarPor = 'Nombre' AND @OrdenDireccion = 'ASC' THEN Nombre END,
        CASE WHEN @OrdenarPor = 'Nombre' AND @OrdenDireccion = 'DESC' THEN Nombre END DESC,
        CASE WHEN @OrdenarPor = 'Cedula' AND @OrdenDireccion = 'ASC' THEN Cedula END,
        CASE WHEN @OrdenarPor = 'Cedula' AND @OrdenDireccion = 'DESC' THEN Cedula END DESC,
        PacienteId
    OFFSET @Skip ROWS
    FETCH NEXT @PageSize ROWS ONLY;
END
GO


-- =============================================
-- GESTIÓN DE TURNOS
-- =============================================

CREATE OR ALTER PROCEDURE sp_TieneTurnoActivo
    @PacienteId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT TOP 1 
        CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END,
        t.TurnoId,
        et.Nombre
    FROM Turnos t
    INNER JOIN EstadoTurnos et ON t.EstadoTurnoId = et.EstadoTurnoId
    WHERE t.PacienteId = @PacienteId 
        AND t.EstadoTurnoId IN (1, 2, 5)
    GROUP BY t.TurnoId, et.Nombre;
END
GO


CREATE OR ALTER PROCEDURE sp_TieneTurnoActivo
    @PacienteId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @TieneActivo BIT = 0;
    DECLARE @TurnoId INT = NULL;
    DECLARE @Estado NVARCHAR(50) = NULL;
    
    IF EXISTS (
        SELECT 1 FROM Turnos 
        WHERE PacienteId = @PacienteId 
        AND EstadoTurnoId IN (1, 2, 5)
    )
    BEGIN
        SET @TieneActivo = 1;
        
        SELECT TOP 1 
            @TurnoId = t.TurnoId,
            @Estado = et.Nombre
        FROM Turnos t
        INNER JOIN EstadoTurnos et ON t.EstadoTurnoId = et.EstadoTurnoId
        WHERE t.PacienteId = @PacienteId 
        AND t.EstadoTurnoId IN (1, 2, 5)
        ORDER BY t.FechaHoraCreacion DESC;
    END
    
    SELECT 
        @TieneActivo AS TieneTurnoActivo,
        @TurnoId AS TurnoIdActual,
        @Estado AS EstadoActual;
END
GO

CREATE OR ALTER PROCEDURE sp_ObtenerSiguienteNumeroTurno
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @MaxNumero INT;
    DECLARE @Hoy DATE = CAST(GETDATE() AS DATE);
    
    SELECT @MaxNumero = ISNULL(MAX(NumeroTurno), 0)
    FROM Turnos
    WHERE CAST(FechaHoraCreacion AS DATE) = @Hoy;
    
    SELECT @MaxNumero + 1 AS SiguienteNumero;
END
GO

CREATE OR ALTER PROCEDURE sp_CrearTurno
    @PacienteId INT,
    @MedicoId INT,
    @RecepcionistaId INT,
    @PrioridadId INT,
    @Observaciones NVARCHAR(MAX) = NULL,
    @TurnoId INT OUTPUT,
    @NumeroTurno INT OUTPUT,
    @Mensaje NVARCHAR(255) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Verificar si el paciente tiene turno activo
    IF EXISTS (SELECT 1 FROM Turnos WHERE PacienteId = @PacienteId AND EstadoTurnoId IN (1, 2, 5))
    BEGIN
        SET @Mensaje = 'El paciente ya tiene un turno activo';
        SET @TurnoId = 0;
        SET @NumeroTurno = 0;
        RETURN;
    END
    
    -- Obtener siguiente número
    DECLARE @MaxNumero INT;
    DECLARE @Hoy DATE = CAST(GETDATE() AS DATE);
    
    SELECT @MaxNumero = ISNULL(MAX(NumeroTurno), 0)
    FROM Turnos
    WHERE CAST(FechaHoraCreacion AS DATE) = @Hoy;
    
    SET @NumeroTurno = @MaxNumero + 1;
    
    -- Insertar turno directamente
    INSERT INTO Turnos (PacienteId, MedicoId, RecepcionistaId, PrioridadId, EstadoTurnoId, NumeroTurno, Observaciones, FechaHoraCreacion)
    VALUES (@PacienteId, @MedicoId, @RecepcionistaId, @PrioridadId, 1, @NumeroTurno, @Observaciones, GETDATE());
    
    SET @TurnoId = SCOPE_IDENTITY();
    SET @Mensaje = 'Turno creado exitosamente. Numero: ' + CAST(@NumeroTurno AS NVARCHAR(10));
END
GO


CREATE OR ALTER PROCEDURE sp_ObtenerColaTurnos
    @MedicoId INT = NULL,
    @EspecialidadId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        t.TurnoId,
        t.NumeroTurno,
        t.FechaHoraCreacion,
        t.PrioridadId,
        p.Nombre AS Prioridad,
        et.Nombre AS Estado,
        t.PacienteId,
        pac.Cedula,
        pac.Nombre AS PacienteNombre,
        pac.Apellido AS PacienteApellido,
        m.MedicoId,
        m.Nombre + ' ' + m.Apellido AS MedicoNombre,
        e.EspecialidadId,
        e.Nombre AS Especialidad,
        t.Observaciones,
        CASE t.PrioridadId
            WHEN 4 THEN 1
            WHEN 1 THEN 2
            WHEN 2 THEN 3
            WHEN 3 THEN 4
        END AS OrdenPrioridad
    FROM Turnos t
    INNER JOIN EstadoTurnos et ON t.EstadoTurnoId = et.EstadoTurnoId
    INNER JOIN Prioridades p ON t.PrioridadId = p.PrioridadId
    INNER JOIN Pacientes pac ON t.PacienteId = pac.PacienteId
    INNER JOIN Medicos m ON t.MedicoId = m.MedicoId
    INNER JOIN Especialidades e ON m.EspecialidadId = e.EspecialidadId
    WHERE t.EstadoTurnoId = 1
        AND (@MedicoId IS NULL OR t.MedicoId = @MedicoId)
        AND (@EspecialidadId IS NULL OR e.EspecialidadId = @EspecialidadId)
    ORDER BY 
        CASE t.PrioridadId
            WHEN 4 THEN 1
            WHEN 1 THEN 2
            WHEN 2 THEN 3
            WHEN 3 THEN 4
        END,
        t.FechaHoraCreacion ASC;
END
GO
GO
GO
CREATE OR ALTER PROCEDURE sp_CambiarEstadoTurno
    @TurnoId INT,
    @NuevoEstadoId INT,
    @Mensaje NVARCHAR(255) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @EstadoActualId INT;
    DECLARE @PacienteId INT;
    DECLARE @MedicoId INT;
    
    SELECT 
        @EstadoActualId = t.EstadoTurnoId,
        @PacienteId = t.PacienteId,
        @MedicoId = t.MedicoId
    FROM Turnos t
    WHERE t.TurnoId = @TurnoId;
    
    IF @NuevoEstadoId = 2 AND @EstadoActualId != 1
    BEGIN
        SET @Mensaje = 'Solo se puede pasar de Creado a En Atencion';
        RAISERROR(@Mensaje, 16, 1);
        RETURN -1;
    END
    
    IF @NuevoEstadoId = 3 AND @EstadoActualId != 2
    BEGIN
        SET @Mensaje = 'Solo se puede pasar de En Atencion a Atendido';
        RAISERROR(@Mensaje, 16, 1);
        RETURN -1;
    END
    
    IF @NuevoEstadoId = 4 AND @EstadoActualId NOT IN (1, 5)
    BEGIN
        SET @Mensaje = 'Solo se puede cancelar un turno Creado o Postergado';
        RAISERROR(@Mensaje, 16, 1);
        RETURN -1;
    END
    
    IF @NuevoEstadoId = 5 AND @EstadoActualId != 1
    BEGIN
        SET @Mensaje = 'Solo se puede postergar un turno Creado';
        RAISERROR(@Mensaje, 16, 1);
        RETURN -1;
    END
    
    UPDATE Turnos
    SET EstadoTurnoId = @NuevoEstadoId,
        FechaHoraInicio = CASE WHEN @NuevoEstadoId = 2 AND FechaHoraInicio IS NULL THEN GETDATE() ELSE FechaHoraInicio END,
        FechaHoraFin = CASE WHEN @NuevoEstadoId = 3 THEN GETDATE() ELSE FechaHoraFin END
    WHERE TurnoId = @TurnoId;
    
    SELECT 
        et.Nombre AS NuevoEstado,
        GETDATE() AS FechaCambio
    FROM EstadoTurnos et
    WHERE et.EstadoTurnoId = @NuevoEstadoId;
    
    SET @Mensaje = 'Estado cambiado exitosamente';
END
GO


-- =============================================
-- GESTIÓN DE MÉDICOS
-- =============================================

CREATE OR ALTER PROCEDURE sp_InsertarMedico
    @NLicencia NVARCHAR(50),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @EspecialidadId INT,
    @UsuarioId INT,
    @MedicoId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM Medicos WHERE NLicencia = @NLicencia)
    BEGIN
        RAISERROR('Ya existe un medico con esta licencia', 16, 1);
        RETURN -1;
    END
    
    INSERT INTO Medicos (NLicencia, Nombre, Apellido, EspecialidadId, UsuarioId)
    VALUES (@NLicencia, @Nombre, @Apellido, @EspecialidadId, @UsuarioId);
    
    SET @MedicoId = SCOPE_IDENTITY();
END
GO

CREATE OR ALTER PROCEDURE sp_ActualizarMedico
    @MedicoId INT,
    @NLicencia NVARCHAR(50),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @EspecialidadId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE Medicos
    SET NLicencia = @NLicencia,
        Nombre = @Nombre,
        Apellido = @Apellido,
        EspecialidadId = @EspecialidadId
    WHERE MedicoId = @MedicoId;
END
GO

CREATE OR ALTER PROCEDURE sp_ListarMedicos
    @EspecialidadId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        m.MedicoId,
        m.NLicencia,
        m.Nombre,
        m.Apellido,
        m.EspecialidadId,
        e.Nombre AS Especialidad,
        m.UsuarioId,
        u.Usuario
    FROM Medicos m
    INNER JOIN Especialidades e ON m.EspecialidadId = e.EspecialidadId
    INNER JOIN Usuarios u ON m.UsuarioId = u.UsuarioId
    WHERE (@EspecialidadId IS NULL OR m.EspecialidadId = @EspecialidadId)
    ORDER BY m.Apellido, m.Nombre;
END
GO

CREATE OR ALTER PROCEDURE sp_ObtenerMedicosPorEspecialidad
    @EspecialidadId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        MedicoId,
        NLicencia,
        Nombre + ' ' + Apellido AS NombreCompleto,
        EspecialidadId
    FROM Medicos
    WHERE EspecialidadId = @EspecialidadId
    ORDER BY Apellido, Nombre;
END
GO


-- =============================================
-- GESTIÓN DE ESPECIALIDADES
-- =============================================

CREATE OR ALTER PROCEDURE sp_InsertarEspecialidad
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255) = NULL,
    @EspecialidadId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Especialidades (Nombre, Descripcion)
    VALUES (@Nombre, @Descripcion);
    
    SET @EspecialidadId = SCOPE_IDENTITY();
END
GO

CREATE OR ALTER PROCEDURE sp_ActualizarEspecialidad
    @EspecialidadId INT,
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE Especialidades
    SET Nombre = @Nombre,
        Descripcion = @Descripcion
    WHERE EspecialidadId = @EspecialidadId;
END
GO

CREATE OR ALTER PROCEDURE sp_ListarEspecialidades
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        EspecialidadId,
        Nombre,
        Descripcion,
        (SELECT COUNT(*) FROM Medicos WHERE EspecialidadId = Especialidades.EspecialidadId) AS CantidadMedicos
    FROM Especialidades
    ORDER BY Nombre;
END
GO


-- =============================================
-- GESTIÓN DE RECEPCIONISTAS
-- =============================================

CREATE OR ALTER PROCEDURE sp_InsertarRecepcionista
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @AreaId INT,
    @UsuarioId INT,
    @RecepcionistaId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Recepcionistas (Nombre, Apellido, AreaId, UsuarioId)
    VALUES (@Nombre, @Apellido, @AreaId, @UsuarioId);
    
    SET @RecepcionistaId = SCOPE_IDENTITY();
END
GO

CREATE OR ALTER PROCEDURE sp_ListarRecepcionistas
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        r.RecepcionistaId,
        r.Nombre,
        r.Apellido,
        r.AreaId,
        a.Nombre AS Area,
        r.UsuarioId,
        u.Usuario
    FROM Recepcionistas r
    INNER JOIN Areas a ON r.AreaId = a.AreaId
    INNER JOIN Usuarios u ON r.UsuarioId = u.UsuarioId
    ORDER BY r.Apellido, r.Nombre;
END
GO


-- =============================================
-- GESTIÓN DE ÁREAS
-- =============================================

CREATE OR ALTER PROCEDURE sp_ListarAreas
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        AreaId,
        Nombre,
        Descripcion,
        (SELECT COUNT(*) FROM Recepcionistas WHERE AreaId = Areas.AreaId) AS CantidadRecepcionistas
    FROM Areas
    ORDER BY Nombre;
END
GO


-- =============================================
-- ESTADÍSTICAS Y REPORTES
-- =============================================

CREATE OR ALTER PROCEDURE sp_EstadisticasGenerales
    @FechaDesde DATE = NULL,
    @FechaHasta DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SET @FechaDesde = ISNULL(@FechaDesde, CAST(DATEADD(DAY, -30, GETDATE()) AS DATE));
    SET @FechaHasta = ISNULL(@FechaHasta, CAST(GETDATE() AS DATE));
    
    SELECT 
        et.Nombre AS Estado,
        COUNT(t.TurnoId) AS Cantidad
    FROM Turnos t
    INNER JOIN EstadoTurnos et ON t.EstadoTurnoId = et.EstadoTurnoId
    WHERE CAST(t.FechaHoraCreacion AS DATE) BETWEEN @FechaDesde AND @FechaHasta
    GROUP BY et.Nombre;
    
    SELECT 
        CAST(t.FechaHoraCreacion AS DATE) AS Fecha,
        COUNT(*) AS Cantidad
    FROM Turnos t
    WHERE CAST(t.FechaHoraCreacion AS DATE) BETWEEN @FechaDesde AND @FechaHasta
    GROUP BY CAST(t.FechaHoraCreacion AS DATE)
    ORDER BY Fecha;
    
    SELECT TOP 5
        m.Nombre + ' ' + m.Apellido AS Medico,
        COUNT(t.TurnoId) AS TurnosAtendidos
    FROM Turnos t
    INNER JOIN Medicos m ON t.MedicoId = m.MedicoId
    WHERE t.EstadoTurnoId = 3
        AND CAST(t.FechaHoraCreacion AS DATE) BETWEEN @FechaDesde AND @FechaHasta
    GROUP BY m.Nombre + ' ' + m.Apellido
    ORDER BY TurnosAtendidos DESC;
END
GO

CREATE OR ALTER PROCEDURE sp_EstadisticasMedico
    @MedicoId INT,
    @Fecha DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SET @Fecha = ISNULL(@Fecha, CAST(GETDATE() AS DATE));
    
    SELECT COUNT(*) AS TurnosAtendidosHoy
    FROM Turnos
    WHERE MedicoId = @MedicoId 
        AND EstadoTurnoId = 3
        AND CAST(FechaHoraFin AS DATE) = @Fecha;
    
    SELECT COUNT(*) AS TurnosPendientes
    FROM Turnos
    WHERE MedicoId = @MedicoId 
        AND EstadoTurnoId = 1;
    
    SELECT TOP 1
        t.TurnoId,
        t.NumeroTurno,
        p.Nombre + ' ' + p.Apellido AS Paciente,
        t.FechaHoraInicio
    FROM Turnos t
    INNER JOIN Pacientes p ON t.PacienteId = p.PacienteId
    WHERE t.MedicoId = @MedicoId 
        AND t.EstadoTurnoId = 2
    ORDER BY t.FechaHoraInicio;
END
GO

CREATE OR ALTER PROCEDURE sp_HistorialTurnosPaciente
    @PacienteId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        t.TurnoId,
        t.NumeroTurno,
        t.FechaHoraCreacion,
        t.FechaHoraInicio,
        t.FechaHoraFin,
        et.Nombre AS Estado,
        pr.Nombre AS Prioridad,
        m.Nombre + ' ' + m.Apellido AS Medico,
        e.Nombre AS Especialidad,
        t.Observaciones
    FROM Turnos t
    INNER JOIN EstadoTurnos et ON t.EstadoTurnoId = et.EstadoTurnoId
    INNER JOIN Prioridades pr ON t.PrioridadId = pr.PrioridadId
    INNER JOIN Medicos m ON t.MedicoId = m.MedicoId
    INNER JOIN Especialidades e ON m.EspecialidadId = e.EspecialidadId
    WHERE t.PacienteId = @PacienteId
    ORDER BY t.FechaHoraCreacion DESC;
END
GO


-- =============================================
-- VALIDACIONES
-- =============================================

CREATE OR ALTER PROCEDURE sp_ValidarMedicoOcupado
    @MedicoId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @Ocupado BIT = 0;
    
    IF EXISTS (
        SELECT 1 FROM Turnos 
        WHERE MedicoId = @MedicoId 
        AND EstadoTurnoId = 2
    )
    BEGIN
        SET @Ocupado = 1;
    END
    
    SELECT @Ocupado AS MedicoOcupado;
END
GO

CREATE OR ALTER PROCEDURE sp_PosicionEnCola
    @TurnoId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @PacienteId INT;
    DECLARE @MedicoId INT;
    DECLARE @PrioridadId INT;
    DECLARE @FechaCreacion DATETIME;
    
    SELECT 
        @PacienteId = PacienteId,
        @MedicoId = MedicoId,
        @PrioridadId = PrioridadId,
        @FechaCreacion = FechaHoraCreacion
    FROM Turnos
    WHERE TurnoId = @TurnoId;
    
    SELECT 
        COUNT(*) + 1 AS Posicion
    FROM Turnos t
    WHERE t.MedicoId = @MedicoId
        AND t.EstadoTurnoId = 1
        AND (
            (t.PrioridadId = @PrioridadId AND t.FechaHoraCreacion < @FechaCreacion)
            OR t.PrioridadId < @PrioridadId
        );
END
GO
