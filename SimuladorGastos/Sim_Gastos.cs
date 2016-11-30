using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGastos
{
    class Sim_Gastos
    {


        public void CalcularFatura(int opcao, Quarto q, Sala s, Cozinha c, Banheiro b)
        {
            Quarto c_quarto = q;
            Sala c_sala = s;
            Cozinha c_Cozinha = c;
            Banheiro c_Banheiro = b;

            float ValorTotal = 0.00f, tarifa = 0.30f;

            switch (opcao)
            {

                case 1:

                    for (int i = 0; i < q.list_ED.Count; i++)
                    {
                        ValorTotal += (q.list_ED[i].Khw * tarifa) * q.list_ED[i].QtdED;
                    }
                    int e_nome = 27, e_qtd = 20, e_c = 12, e_qtdc = 14, t = 0;
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("                               Fatura do Quarto                                ");
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("Lista de Eletrodomésticos  || Consumo Total(Kwh) ||  Quantidade  || Valor (R$) ");
                    for (int i = 0; i < q.list_ED.Count; i++)
                    {
                        Console.Write(q.list_ED[i].Nome);
                        t = q.list_ED[i].Nome.Length;
                        while (t < e_nome)
                        {
                            Console.Write(" ");
                            t++;
                        }
                        Console.Write("||");

                        Console.Write(q.list_ED[i].Khw);
                        t = q.list_ED[i].Khw.ToString().Length;
                        while (t < e_qtd)
                        {
                            Console.Write(" ");
                            t++;
                        }
                        Console.Write("||");

                        Console.Write(q.list_ED[i].QtdED);
                        t = q.list_ED[i].QtdED.ToString().Length;

                        while (t < e_qtdc)
                        {
                            Console.Write(" ");
                            t++;
                        }
                        Console.Write("||");

                        float valorQuarto = 0.00f;

                        valorQuarto += (q.list_ED[i].Khw * tarifa) * q.list_ED[i].QtdED;

                        Console.Write(valorQuarto);

                        t = valorQuarto.ToString().Length;

                        while (t < e_c)
                        {
                            Console.Write(" ");
                            t++;
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("Valor da Fatura = R$" + ValorTotal);
                    Console.WriteLine("===============================================================================");
                    Console.ReadKey();

                    break;

                case 2:

                    for (int i = 0; i < s.list_ED.Count; i++)
                    {
                        ValorTotal += (s.list_ED[i].Khw * tarifa) * s.list_ED[i].QtdED;
                    }
                    int e_nome1 = 27, e_qtd1 = 20, e_c1 = 12, e_qtdc1 = 14, t1 = 0;
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("                               Fatura da Sala                                  ");
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("Lista de Eletrodomésticos  || Consumo Total(Kwh) ||  Quantidade  || Valor (R$) ");
                    for (int i = 0; i < s.list_ED.Count; i++)
                    {
                        Console.Write(s.list_ED[i].Nome);
                        t1 = s.list_ED[i].Nome.Length;
                        while (t1 < e_nome1)
                        {
                            Console.Write(" ");
                            t1++;
                        }
                        Console.Write("||");

                        Console.Write(s.list_ED[i].Khw);
                        t1 = s.list_ED[i].Khw.ToString().Length;
                        while (t1 < e_qtd1)
                        {
                            Console.Write(" ");
                            t1++;
                        }
                        Console.Write("||");

                        Console.Write(s.list_ED[i].QtdED);
                        t1 = s.list_ED[i].QtdED.ToString().Length;

                        while (t1 < e_qtdc1)
                        {
                            Console.Write(" ");
                            t1++;
                        }
                        Console.Write("||");

                        float valorSala = 0.00f;

                        valorSala += (s.list_ED[i].Khw * tarifa) * s.list_ED[i].QtdED;

                        Console.Write(valorSala);

                        t1 = valorSala.ToString().Length;

                        while (t1 < e_c1)
                        {
                            Console.Write(" ");
                            t1++;
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("Valor da Fatura = R$" + ValorTotal);
                    Console.WriteLine("===============================================================================");
                    Console.ReadKey();
                    break;
                case 3:
                    for (int i = 0; i < c.list_ED.Count; i++)
                    {
                        ValorTotal += (c.list_ED[i].Khw * tarifa) * c.list_ED[i].QtdED;
                    }
                    int e_nome2 = 27, e_qtd2 = 20, e_c2 = 12, e_qtdc2 = 14, t2 = 0;
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("                               Fatura da Cozinha                               ");
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("Lista de Eletrodomésticos  || Consumo Total(Kwh) ||  Quantidade  || Valor (R$) ");
                    
                    for (int i = 0; i < c.list_ED.Count; i++)
                    {
                        Console.Write(c.list_ED[i].Nome);
                        t2 = c.list_ED[i].Nome.Length;
                        while (t2 < e_nome2)
                        {
                            Console.Write(" ");
                            t2++;
                        }
                        Console.Write("||");

                        Console.Write(c.list_ED[i].Khw);
                        t2 = c.list_ED[i].Khw.ToString().Length;
                        while (t2 < e_qtd2)
                        {
                            Console.Write(" ");
                            t2++;
                        }
                        Console.Write("||");

                        Console.Write(c.list_ED[i].QtdED);
                        t2 = c.list_ED[i].QtdED.ToString().Length;

                        while (t2 < e_qtdc2)
                        {
                            Console.Write(" ");
                            t2++;
                        }
                        Console.Write("||");

                        float valorCozinha = 0.00f;

                        valorCozinha += (c.list_ED[i].Khw * tarifa) * c.list_ED[i].QtdED;

                        Console.Write(valorCozinha);

                        t2 = valorCozinha.ToString().Length;

                        while (t2 < e_c2)
                        {
                            Console.Write(" ");
                            t2++;
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("Valor da Fatura = R$" + ValorTotal);
                    Console.WriteLine("===============================================================================");
                    Console.ReadKey();
                    break;
                case 4:

                    for (int i = 0; i < b.list_ED.Count; i++)
                    {
                        ValorTotal += (b.list_ED[i].Khw * tarifa) * b.list_ED[i].QtdED;
                    }
                    int e_nome3 = 27, e_qtd3 = 20, e_c3 = 12, e_qtdc3 = 14, t3 = 0;
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("                               Fatura do Banheiro                              ");
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("Lista de Eletrodomésticos  || Consumo Total(Kwh) ||  Quantidade  || Valor (R$) ");
                    
                    for (int i = 0; i < b.list_ED.Count; i++)
                    {
                        Console.Write(b.list_ED[i].Nome);
                        t3 = b.list_ED[i].Nome.Length;
                        while (t3 < e_nome3)
                        {
                            Console.Write(" ");
                            t3++;
                        }
                        Console.Write("||");

                        Console.Write(b.list_ED[i].Khw);
                        t3 = b.list_ED[i].Khw.ToString().Length;
                        while (t3 < e_qtd3)
                        {
                            Console.Write(" ");
                            t3++;
                        }
                        Console.Write("||");

                        Console.Write(b.list_ED[i].QtdED);
                        t3 = b.list_ED[i].QtdED.ToString().Length;

                        while (t3 < e_qtdc3)
                        {
                            Console.Write(" ");
                            t3++;
                        }
                        Console.Write("||");

                        float valorBan = 0.00f;
                        valorBan += (b.list_ED[i].Khw * tarifa) * b.list_ED[i].QtdED;
                       
                        Console.Write(valorBan);
                        
                        t3 = valorBan.ToString().Length;

                        while (t3 < e_c3)
                        {
                            Console.Write(" ");
                            t3++;
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("===============================================================================");
                    Console.WriteLine("Valor da Fatura = R$" + ValorTotal);
                    Console.WriteLine("===============================================================================");
                    Console.ReadKey();
                    break;
            }
        }
        public void CalcularFaturaTotal(Sala s, Cozinha c, Banheiro b, Quarto q)
        {
            Quarto c_quarto = q;
            Sala c_sala = s;
            Cozinha c_Cozinha = c;
            Banheiro c_Banheiro = b;

            float ValorTotal = 0.00f, tarifa = 0.30f, ValorTotalSala = 0.00f, ValorTotalCozinha = 0.00f, ValorTotalBanheiro = 0.00f, ValorTotalQuarto = 0.00f;

            for (int i = 0; i < s.list_ED.Count; i++)
            {
                ValorTotalSala += (s.list_ED[i].Khw * tarifa) * s.list_ED[i].QtdED;
            }
            for (int i = 0; i < c.list_ED.Count; i++)
            {
                ValorTotalCozinha += (c.list_ED[i].Khw * tarifa) * c.list_ED[i].QtdED;
            }
            for (int i = 0; i < b.list_ED.Count; i++)
            {
                ValorTotalBanheiro += (b.list_ED[i].Khw * tarifa) * b.list_ED[i].QtdED;
            }
            for (int i = 0; i < q.list_ED.Count; i++)
            {
                ValorTotalQuarto += (q.list_ED[i].Khw * tarifa) * q.list_ED[i].QtdED;
            }
            ValorTotal += ValorTotalBanheiro + ValorTotalCozinha + ValorTotalQuarto + ValorTotalSala;

            int e_nome3 = 27, e_qtd3 = 20, e_c3 = 12, e_qtdc3 = 14, t3 = 0;
            int e_nome2 = 27, e_qtd2 = 20, e_c2 = 12, e_qtdc2 = 14, t2 = 0;
            int e_nome1 = 27, e_qtd1 = 20, e_c1 = 12, e_qtdc1 = 14, t1 = 0;
            int e_nome = 27, e_qtd = 20, e_c = 12, e_qtdc = 14, t = 0;
            Console.WriteLine("===============================================================================");
            Console.WriteLine("                               Fatura do Total                                 ");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Lista de Eletrodomésticos  || Consumo Total(Kwh) ||  Quantidade  || Valor (R$) ");

            for (int i = 0; i < b.list_ED.Count; i++)
            {
                Console.Write(b.list_ED[i].Nome);
                t3 = b.list_ED[i].Nome.Length;
                while (t3 < e_nome3)
                {
                    Console.Write(" ");
                    t3++;
                }
                Console.Write("||");

                Console.Write(b.list_ED[i].Khw);
                t3 = b.list_ED[i].Khw.ToString().Length;
                while (t3 < e_qtd3)
                {
                    Console.Write(" ");
                    t3++;
                }
                Console.Write("||");

                Console.Write(b.list_ED[i].QtdED);
                t3 = b.list_ED[i].QtdED.ToString().Length;

                while (t3 < e_qtdc3)
                {
                    Console.Write(" ");
                    t3++;
                }
                Console.Write("||");

                float valorBanheiro = 0.00f;

                valorBanheiro += (b.list_ED[i].Khw * tarifa) * b.list_ED[i].QtdED;

                Console.Write(valorBanheiro);

                t3 = valorBanheiro.ToString().Length;

                while (t3 < e_c3)
                {
                    Console.Write(" ");
                    t3++;
                }
                Console.WriteLine(" ");

                for (int j = 0; j < c.list_ED.Count; j++)
                {
                    Console.Write(c.list_ED[j].Nome);
                    t2 = c.list_ED[j].Nome.Length;
                    while (t2 < e_nome2)
                    {
                        Console.Write(" ");
                        t2++;
                    }
                    Console.Write("||");

                    Console.Write(c.list_ED[j].Khw);
                    t2 = c.list_ED[j].Khw.ToString().Length;
                    while (t2 < e_qtd2)
                    {
                        Console.Write(" ");
                        t2++;
                    }
                    Console.Write("||");

                    Console.Write(c.list_ED[j].QtdED);
                    t2 = c.list_ED[j].QtdED.ToString().Length;

                    while (t2 < e_qtdc2)
                    {
                        Console.Write(" ");
                        t2++;
                    }
                    Console.Write("||");

                    float valorCozinha = 0.00f;

                    valorCozinha += (c.list_ED[j].Khw * tarifa) * c.list_ED[j].QtdED;

                    Console.Write(valorCozinha);

                    t2 = valorCozinha.ToString().Length;

                    while (t2 < e_c2)
                    {
                        Console.Write(" ");
                        t2++;
                    }
                    Console.WriteLine(" ");

                    for (int k = 0; k < s.list_ED.Count; k++)
                    {
                        Console.Write(s.list_ED[k].Nome);
                        t1 = s.list_ED[k].Nome.Length;
                        while (t1 < e_nome1)
                        {
                            Console.Write(" ");
                            t1++;
                        }
                        Console.Write("||");

                        Console.Write(s.list_ED[k].Khw);
                        t1 = s.list_ED[k].Khw.ToString().Length;
                        while (t1 < e_qtd1)
                        {
                            Console.Write(" ");
                            t1++;
                        }
                        Console.Write("||");

                        Console.Write(s.list_ED[k].QtdED);
                        t1 = s.list_ED[k].QtdED.ToString().Length;

                        while (t1 < e_qtdc1)
                        {
                            Console.Write(" ");
                            t1++;
                        }
                        Console.Write("||");

                        float valorSala = 0.00f;

                        valorSala += (s.list_ED[k].Khw * tarifa) * s.list_ED[k].QtdED;

                        Console.Write(valorSala);

                        t1 = valorSala.ToString().Length;

                        while (t1 < e_c1)
                        {
                            Console.Write(" ");
                            t1++;
                        }
                        Console.WriteLine(" ");

                        for (int e = 0; e < q.list_ED.Count; e++)
                        {
                            Console.Write(q.list_ED[e].Nome);
                            t = q.list_ED[e].Nome.Length;
                            while (t < e_nome)
                            {
                                Console.Write(" ");
                                t++;
                            }
                            Console.Write("||");

                            Console.Write(q.list_ED[e].Khw);
                            t = q.list_ED[e].Khw.ToString().Length;
                            while (t < e_qtd)
                            {
                                Console.Write(" ");
                                t++;
                            }
                            Console.Write("||");

                            Console.Write(q.list_ED[e].QtdED);
                            t = q.list_ED[e].QtdED.ToString().Length;

                            while (t < e_qtdc)
                            {
                                Console.Write(" ");
                                t++;
                            }
                            Console.Write("||");

                            float valorQuarto = 0.00f;

                            valorQuarto += (q.list_ED[e].Khw * tarifa) * q.list_ED[e].QtdED;

                            Console.Write(valorQuarto);

                            t = valorQuarto.ToString().Length;

                            while (t < e_c)
                            {
                                Console.Write(" ");
                                t++;
                            }
                            Console.WriteLine(" ");
                        }

                    }
                }
            }
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Valor Total da Fatura = R$" + ValorTotal);
            Console.WriteLine("===============================================================================");
            Console.ReadKey();
        }
    }
}