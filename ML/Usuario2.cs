using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario2
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        public string EntidadNacimiento { get; set; }

        public string Curp { get; set; }

        public string Rfc { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string EstadoCivil { get; set; }

        public string Genero { get; set; }

        public string FormattedFechaNacimiento => FechaNacimiento.ToString("yyyy/MM/dd");
    }
}
