using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    public class EmpleadoFijo : Empleado

    {
        public bool MetaAlcanzada {  get; set; }

        public EmpleadoFijo(string nombre, decimal salarioBase, bool metaAlcanzada)
            :base (nombre, salarioBase)

        {

            MetaAlcanzada = metaAlcanzada;
        }


        public override decimal CalcularSalario()
        {
            return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
        }
    }
}
