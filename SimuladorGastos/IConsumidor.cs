using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGastos
{
    interface IConsumidor
    {
        float ConsumoEnergia();
        void ListarEletrodomestico();
    }
}
