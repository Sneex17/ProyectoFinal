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
            RuleFor(L => L.Apellido).NotEmpty().WithMessage("El apellido del médico es obligatorio.");
            RuleFor(L => L.Nlicencia).NotEmpty().WithMessage("El Licencia del médico es obligatorio.");
        }
    }

    public class ValidacionUsuario : AbstractValidator<Usuario>
    {
        public ValidacionUsuario()
        {
            RuleFor(L => L.Usuario1).NotEmpty().WithMessage("El usuario del médico es obligatorio.");
            RuleFor(L => L.Contrasena).NotEmpty().WithMessage("La contraseña del médico es obligatorio.");
        }
    }

    public class ValidacionRecepcionista : AbstractValidator<Recepcionista>
    {
        public ValidacionRecepcionista()
        {
            RuleFor(L => L.Nombre).NotEmpty().WithMessage("El nombre del recepcionista es obligatorio.");
            RuleFor(L => L.Apellido).NotEmpty().WithMessage("El apellido del recepcionista es obligatorio.");
        }
    }
}
