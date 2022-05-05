using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deberConsola
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Instancia la clase contrato para poder usar sus atributos 
            contrato contra = new contrato();
            //Pide datos personales
            Console.WriteLine("=============================================");
            Console.WriteLine("=========Ingresar los siguientes datos=======");
            Console.WriteLine("Ingrese su cedula");
            contra.Identificacion = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese sus nombres");
            contra.Nombres = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese sus apellidos");
            contra.Apellidos = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese su fecha de nacimiento");
            contra.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese su genero");
            Console.WriteLine(" 1.Masculino \n 2.Femenino");
            int genero = Convert.ToInt32(Console.ReadLine());
            if (genero == 1)
            {
                contra.Genero = ("Masculino");
            }
            if (genero == 2)
            {
                contra.Genero = ("Femenino");
            }
            Console.WriteLine("");
            Console.WriteLine("Seleccione su tipo de sangre");
            Console.WriteLine(" 1.Tipo A \n 2.Tipo B \n 3.Tipo AB \n 4.Tipo O ");
            int tipoS = Convert.ToInt32(Console.ReadLine());
            if (tipoS == 1)
            {
                contra.TipoSangre = ("Tipo A");
            }
            if (tipoS == 2)
            {
                contra.TipoSangre = ("Tipo B");
            }
            if (tipoS == 3)
            {
                contra.TipoSangre = ("Tipo AB");
            }
            if (tipoS == 4)
            {
                contra.TipoSangre = ("Tipo 0");
            }
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine("==========Ingresar datos del contrato========");
            Console.WriteLine("Seleccione su fecha de contrato");
            Console.WriteLine("1. Seccion Costa y galapagos");
            Console.WriteLine("2. Seccion Sierra y Amazonia");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                contra.FechaContrato = "28/02/2021 al 15/03/2022";
            }
            if (true)
            {
                contra.FechaContrato = "01/08/2021 al 31/07/2022";
            }
            int diasTrabajados;
            Console.WriteLine("Ingrese los dias trabajados (en numeros)");
            diasTrabajados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=============================================");
            //Ejecuta las funciones y retorna los valores pedidos de las funciones
            double sueldoMes = calculoSueldo(diasTrabajados);
            double porcentajeAporte = calculoAporte(sueldoMes);
            double sueldoDecimoC = calculoSueldosTC(sueldoMes, op);
            double sueldoRe = contra.Sueldo = sueldoMes;
            //Impresion de datos finales
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine("===============Datos personales==============");
            Console.WriteLine("Nombres: " + contra.Nombres);
            Console.WriteLine("Apellidos: " + contra.Apellidos);
            Console.WriteLine("Fecha de nacimiento: " + contra.FechaNacimiento);
            Console.WriteLine("Genero: " + contra.Genero);
            Console.WriteLine("Tipo de sangre: " + contra.TipoSangre);
            Console.WriteLine("Fecha contrato: " + contra.FechaContrato);
            Console.WriteLine("Sueldo: " + contra.Sueldo);
            Console.WriteLine("=============================================");
            Console.WriteLine("================Datos Contrato===============");
            Console.WriteLine("Su sueldo del mes es de: " + sueldoMes);
            Console.WriteLine("Su aporte al IESS es de: " + porcentajeAporte);
            Console.WriteLine("Su decimo tercero es de: " + sueldoMes);
            Console.WriteLine("Su decimo cuarto es de: " + sueldoDecimoC);
            Console.WriteLine("=============================================");
            Console.ReadKey();

        }

        #region calculoSueldosExtra
        //Funcion para calcular el decimo tercer y cuarto sueldo
        private static double calculoSueldosTC(double sueldoMes, int op)
        {
            double sueldoRe = 0.0;// sueldo del decimo cuarto
            double mesesCostaS = 11;//meses entre las fechas
            double diasCosta = 27;//dias costa y galapagos
            double diasSierra = 30;//dias sierra y amazonia

            if (op == 1)
            {
                sueldoRe = ((425 / 12) * mesesCostaS) + ((425 / 360) * diasCosta);
            }
            if (op == 2)
            {
                sueldoRe = ((425 / 12) * mesesCostaS) + ((425 / 360) * diasSierra);
            }
            return sueldoRe;
        }
        #endregion

        #region calculoAporte
        //Funcion para calcular aporte al IESS
        private static double calculoAporte(double sueldoMes)
        {
            double porcentajeAporte = 0.0;

            Console.WriteLine("Ingrese el tipo de aportacion: ");
            Console.WriteLine("1. Aporte como trabajador");
            Console.WriteLine("2. Aporte como empreador");
            Console.WriteLine("3. Aporte como afiliado voluntario");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                porcentajeAporte = sueldoMes * 0.9;
            }
            if (op == 2)
            {
                porcentajeAporte = sueldoMes * 0.1115;
            }
            if (op == 3)
            {
                porcentajeAporte = sueldoMes * 0.205;
            }
            return porcentajeAporte;
        }
        #endregion

        #region calculoSueldo
        //Funcion para calcular el sueldo 
        private static double calculoSueldo(int diasTrabajados)
        {
            double sueldoBase = 425.49;
            double sueldoMes;
            sueldoMes = (sueldoBase / 30) * diasTrabajados;
            return sueldoMes;
        }
        #endregion
    }
}
