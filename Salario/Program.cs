using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un docente por hora
            EmpleadoPorhora empleadoPorhora = new EmpleadoPorhora("Naomi", 20); 
            Console.WriteLine($"{empleadoPorhora.Nombre}: Salario mensual = {empleadoPorhora.CalcularSalario()}");

            // Crear un docente de contrato fijo
            EmpleadoFijo empleadoFijo = new EmpleadoFijo ("Orlando", 2000, true); 
            Console.WriteLine($"{empleadoFijo.Nombre}: Salario mensual = {empleadoFijo.CalcularSalario()}");

            // Crear un empleado administrativo
            EmpleadoAdmin empleadoAdmin = new EmpleadoAdmin("Jorge", 1500, false); 
            Console.WriteLine($"{empleadoAdmin.Nombre}: Salario mensual = {empleadoAdmin.CalcularSalario()}");
        
    }
    }
}
