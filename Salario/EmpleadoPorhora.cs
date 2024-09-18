using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    public class EmpleadoPorhora : Empleado
    {

        public int HorasTrabajadas { get; set; }
        public decimal TarifaHora { get; set; } = 800;


        public EmpleadoPorhora(string nombre, int horasTrabajadas)
            :base (nombre, 0)

        {

            HorasTrabajadas = horasTrabajadas;

        }

        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * TarifaHora;
        }

    }

   
}
