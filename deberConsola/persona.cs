using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deberConsola
{
    public class persona
    {
        private string identificacion;
        private string nombres;
        private string apellidos;
        private string fechaNacimiento;
        private string genero;
        private string tipoSangre;

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Genero { get => genero; set => genero = value; }
        public string TipoSangre { get => tipoSangre; set => tipoSangre = value; }
    }
}
