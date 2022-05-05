using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deberConsola
{
    public class contrato:persona
    {
        private double sueldo;
        private string fechaContrato;

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public string FechaContrato { get => fechaContrato; set => fechaContrato = value; }
    }
}
