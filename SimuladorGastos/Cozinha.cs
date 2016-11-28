using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGastos
{
    class Cozinha : Comodo, IConsumidor
    {

        public new List<Eletrodomésticos> list_ED = new List<Eletrodomésticos>();
        public new List<Eletrodomésticos> list_Padrão_ED = new List<Eletrodomésticos>();


        public void InserirEletrodomestico(Eletrodomésticos e)
        {
            list_ED.Add(e);
        }

        public void InserirEletrodomesticoPadrão(Eletrodomésticos e)
        {
            list_Padrão_ED.Add(e);
        }


        public override float ConsumoEnergia()
        {
            for (int i = 0; i < list_ED.Count(); i++)
            {
                Consumo += list_ED[i].Khw;
            }           

            return Consumo;
        }

        public float ConsumoEnergiaPadrao()
        {
            for (int i = 0; i < list_Padrão_ED.Count(); i++)
            {
                Consumo += list_Padrão_ED[i].Khw;
            }

            return Consumo;
        }


        public override void ListarEletrodomestico()
        {
            Console.WriteLine("========================================================================");
            Console.WriteLine("Lista de Eletromesticos da Cozinha\n");
            Console.WriteLine("Nome               | Quantidade  | Consumo Individual  | Consumo Total |");

            int t = 0;
            float consumo_total = 0;
            int e_nome = 19, e_qtd = 13, e_c = 21, e_ct = 15;


            for (int i = 0; i < list_ED.Count(); i++)
            {

                //Inicio da Impressão do Nome na Tabela
                Console.Write(list_ED[i].Nome);

                t = list_ED[i].Nome.Length;

                while (t < e_nome)
                {
                    Console.Write(" ");
                    t++;
                }
                Console.Write("|");

                //Fim da Impressão do Nome na Tabela


                //Inicio da Impressão da Quantidade de Eletrodomestico na Tabela

                Console.Write(list_ED[i].QtdED);

                t = list_ED[i].QtdED.ToString().Length;

                while (t < e_qtd)
                {
                    Console.Write(" ");
                    t++;
                }
                Console.Write("|");

                //Fim da Impressão da Quantidade de Eletrodomestico na Tabela


                //Inicio da Impressão do Consumo Individual na Tabela

                Console.Write(list_ED[i].Khw);

                t = list_ED[i].Khw.ToString().Length;

                while (t < e_c)
                {
                    Console.Write(" ");
                    t++;
                }
                Console.Write("|");

                //Fim da Impressão do Consumo Individual na Tabela


                //Inicio da Impressão do Consumo Total na Tabela

                Console.Write((list_ED[i].Khw * list_ED[i].QtdED));

                t = (list_ED[i].Khw * list_ED[i].QtdED).ToString().Length;

                consumo_total += (list_ED[i].Khw * list_ED[i].QtdED);


                while (t < e_ct)
                {
                    Console.Write(" ");
                    t++;
                }
                Console.WriteLine("|");

                //Fim da Impressão do Consumo Total na Tabela
            }

            Console.WriteLine("\nConsumo Geral - " + consumo_total + "\n");
            Console.WriteLine("========================================================================");
        }
    }
}
