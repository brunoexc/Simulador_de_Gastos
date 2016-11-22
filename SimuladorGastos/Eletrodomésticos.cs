using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGastos
{
    class Eletrodomésticos
    {
        private string nome;
        private float khw;
        private int qtdED;

        public Eletrodomésticos()
        {

        }

        public Eletrodomésticos(string nome) //Construtor para fazer a criação das Listas Padrões
        {

        }


        public Eletrodomésticos(string n, float k, int qED)
        {
           nome = n;
           khw = k;
           qtdED = qED;
        }


        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public float Khw
        {
            get
            {
                return khw;
            }

            set
            {
                khw = value;
            }
        }

        public int QtdED
        {
            get
            {
                return qtdED;
            }

            set
            {
                qtdED = value;
            }
        }
    }
}
