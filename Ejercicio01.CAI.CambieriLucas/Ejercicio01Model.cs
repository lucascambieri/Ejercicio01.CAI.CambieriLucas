using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.CAI.CambieriLucas
{
    internal class Ejercicio01Model
    {
        public string DniIngresado { get; set; }
        public string NombreIngresado { get; set; }
        public string ApellidoIngresado { get; set; }

        public DateTime FechaNacimientoIngresada { get; set; }

        public string Validar()
        {
            
            if (string.IsNullOrEmpty(DniIngresado))
            {
                return "El DNI no puede estar en blanco.";
            }

            if (!int.TryParse(DniIngresado, out int dni))
            {
                return "Ingrese un DNI númerico.";
            }

            if (!EsNumeroDe8o9Digitos(dni))
                {
                    return "Debe ingresar un número de DNI de 8 o 9 dígitos.";
                }

            static bool EsNumeroDe8o9Digitos(int numero)
            {
                int digitos = 0;
                while (numero != 0)
                {
                    numero /= 10;
                    digitos++;
                }
                return digitos >= 8 && digitos <= 9;
            }
            
            if (string.IsNullOrEmpty(NombreIngresado))
            {
                return "El nombre no puede estar vacío.";
            }

            if (NombreIngresado.Length > 50)
            {
                return "El nombre no puede tener más de 50 caracteres.";
            }

            if (string.IsNullOrEmpty(ApellidoIngresado))
            {
                return "El apellido no puede estar vacío.";
            }

            if (ApellidoIngresado.Length > 50)
            {
                return "El apellido no puede tener más de 50 caracteres";
            }
                
            if (FechaNacimientoIngresada >= DateTime.Today)
            {
                return "La fecha debe ser menor a la fecha de hoy.";
            }
            return "Datos cargados correctamente.";
        }
    }
}
