using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGastos
{
    abstract class Comodo : IConsumidor
    {
        private float consumo;
        protected List<Eletrodomésticos> list_ED;
        public List<Eletrodomésticos> list_Padrão_ED;
        private float area;
        private float area_p;

        public float Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public float Consumo
        {
            get
            {
                return consumo;
            }

            set
            {
                consumo = value;
            }
        }

        public float Area_p
        {
            get
            {
                return area_p;
            }

            set
            {
                area_p = value;
            }
        }

        public virtual float ConsumoEnergia()
        {


            return Consumo;

        }


        public virtual void ListarEletrodomestico()
        {
            


        }


    }
}
