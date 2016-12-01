using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGastos
{
    class Sim_Sustentavel
    {
        public Quarto quarto_p20 = new Quarto();
        public Sala sala_p20 = new Sala();
        public Banheiro banheiro_p20 = new Banheiro();
        public Cozinha cozinha_p20 = new Cozinha();

        public Quarto quarto_p40 = new Quarto();
        public Sala sala_p40 = new Sala();
        public Banheiro banheiro_p40 = new Banheiro();
        public Cozinha cozinha_p40 = new Cozinha();

        public Quarto quarto_p80 = new Quarto();
        public Sala sala_p80 = new Sala();
        public Banheiro banheiro_p80 = new Banheiro();
        public Cozinha cozinha_p80 = new Cozinha();

        public float c_quarto_p20, c_quarto_p40, c_quarto_p80;
        public float c_sala_p20, c_sala_p40, c_sala_p80;
        public float c_banheiro_p20, c_banheiro_p40, c_banheiro_p80;
        public float c_cozinha_p20, c_cozinha_p40, c_cozinha_p80;

        public float c_total_p20, c_total_p40, c_total_p80;






        public void SimularEconomia(float area, Quarto q, Sala s, Banheiro b, Cozinha c)
        {
            // c_quarto = consumo_quarto           

            float c_quarto = q.ConsumoEnergia(), c_sala = s.ConsumoEnergia(), c_banheiro = b.ConsumoEnergia(), c_cozinha = c.ConsumoEnergia();
            float c_total = c_quarto + c_sala + c_banheiro + c_cozinha;


            if (area >= 5 && area <= 20)
                if (c_total > c_total_p20)
                {
                    Console.WriteLine("\nSua casa encontra-se fora dos nossos padrões de consumo de energia!");
                    Console.WriteLine("Consumo da Residencia: " + c_total + " kWh");
                    Console.WriteLine("Consumo esperado para residência de até 20m²: " + c_total_p20 + " kWh");                    
                    Console.WriteLine("Quantidade ideal que pode-se economizar: " + (c_total - c_total_p20) + " kWh");
                    Console.WriteLine("Para mais detalhes confira o consumo individual dos comodos!");
                }
                else
                {
                    Console.WriteLine("\nParabens sua casa encontra-se dentro dos nossos padrões de economia\n");
                    Console.WriteLine("Consumo da residência: " + c_total + " kWh");
                    Console.WriteLine("Consumo esperado para residência de até 20m²: " + c_total_p20 + " kWh");                    
                }

            if (area > 21 && area <= 40)
                if (c_total > c_total_p40)
                {
                    Console.WriteLine("\nSua casa encontra-se fora dos nossos padrões de consumo de energia!");
                    Console.WriteLine("Consumo da Residencia: " + c_total + " kWh");
                    Console.WriteLine("Consumo esperado para residência entre 21m² e 40m²: " + c_total_p40 + " kWh");
                    Console.WriteLine("Quantidade ideal que pode-se economizar: " + (c_total - c_total_p40) + " kWh");
                    Console.WriteLine("Para mais detalhes confira o consumo individual dos comodos!");
                }
                else
                {
                    Console.WriteLine("\nParabens sua casa encontra-se dentro dos nossos padrões de economia\n");
                    Console.WriteLine("Consumo da residência: " + c_total + " kWh");
                    Console.WriteLine("Consumo esperado para residência entre 21m² e 40m²: " + c_total_p40 + " kWh");
                }


            if (area > 40)
                if (c_total > c_total_p80)
                {
                    Console.WriteLine("\nSua casa encontra-se fora dos nossos padrões de consumo de energia!");
                    Console.WriteLine("Consumo da Residencia: " + c_total + " kWh");
                    Console.WriteLine("Consumo esperado para residência maior que 40m²: " + c_total_p80 + " kWh");
                    Console.WriteLine("Quantidade ideal que pode-se economizar: " + (c_total - c_total_p80) + " kWh");
                    Console.WriteLine("Para mais detalhes confira o consumo individual dos comodos!");
                }
                else
                {
                    Console.WriteLine("\nParabens sua casa encontra-se dentro dos nossos padrões de economia\n");
                    Console.WriteLine("Consumo da residência: " + c_total + " kWh");
                    Console.WriteLine("Consumo esperado para residência maior que 40m²: " + c_total_p80 + " kWh");
                }

            Console.WriteLine("========================================================================");
        }


        public void SimularEconomiaComodo(float area, int opcao, Quarto q, Sala s, Banheiro b, Cozinha c)
        {            

            float c_quarto = q.ConsumoEnergia(), c_sala = s.ConsumoEnergia(), c_banheiro = b.ConsumoEnergia(), c_cozinha = c.ConsumoEnergia();
            float c_total = c_quarto + c_sala + c_banheiro + c_cozinha;

            float economia = 0;

            switch (opcao) //<<<<<<<<<<<<<<< SWITCH PARA ESCOLHA DE COMODOS PARA DAR DICAS >>>>>>>>>>>>>>>>>>
            {
                case 1: //COMPARA SALAS

                    if (area >= 5 && area <= 20) 
                        if (c_sala > c_sala_p20)
                        {
                            economia = c_sala - c_sala_p20;
                            Console.WriteLine("\nComodo Sala: Possui consumo mais alto que nosso padrão!");                            
                            Console.WriteLine("\nConsumo do Comodo: " + c_sala + " kWh");
                            Console.WriteLine("Consumo esperado para comodo de até 20m²: " + c_sala_p20 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Sala: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do comodo: " + c_sala + " kWh");
                            Console.WriteLine("Consumo esperado para comodo de até 20m²: " + c_sala_p20 + " kWh");
                            
                        }  

                    if (area > 20 && area <= 40)                    
                        if (c_sala > c_sala_p40)
                        {
                            economia = c_sala - c_sala_p40;
                            Console.WriteLine("\nComodo Sala: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do comodo: " + c_sala + " kWh");
                            Console.WriteLine("Consumo esperado para comodo entre 21 e 40m²: " + c_sala_p40 + " kWh");                            
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Sala: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do comodo: " + c_sala + " kWh");
                            Console.WriteLine("Consumo esperado para comodo entre 21 e 40m²: " + c_sala_p40 + " kWh");
                            
                        } 

                    if (area > 40)                    
                        if (c_sala > c_sala_p80)
                        {
                            economia = c_sala - c_sala_p80;
                            Console.WriteLine("\nComodo Sala: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do comodo: " + c_sala + " kWh");
                            Console.WriteLine("Consumo esperado para comodo maior que 40m²: " + c_sala_p80 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }

                        else
                        {
                            Console.WriteLine("\nComodo Sala: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do comodo: " + c_sala + " kWh");
                            Console.WriteLine("Consumo esperado para comodo maior que 40m²: " + c_sala_p80 + " kWh");
                        }

                    Console.WriteLine("========================================================================");

                    break;

                case 2: // COMPARA COZINHA

                    if (area >= 5 && area <= 20)               
                        if (c_cozinha > c_cozinha_p20)
                        {
                            economia = c_cozinha - c_cozinha_p20;
                            Console.WriteLine("\nComodo Cozinha: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do Comodo: " + c_cozinha + " kWh");
                            Console.WriteLine("Consumo esperado para comodo de até 20m²: " + c_cozinha_p20 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Cozinha: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do Comodo: " + c_cozinha + " kWh");
                            Console.WriteLine("Consumo esperado para comodo de até 20m²: " + c_cozinha_p20 + " kWh");
                        }
                

                    if (area > 20 && area <= 40)                    
                        if (c_cozinha > c_cozinha_p40)
                        {
                            economia = c_cozinha - c_cozinha_p40;
                            Console.WriteLine("\nComodo Cozinha: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do comodo: " + c_cozinha + " kWh");
                            Console.WriteLine("Consumo esperado para comodo entre 21 e 40m²: " + c_cozinha_p40 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Cozinha: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do comodo: " + c_cozinha + " kWh");
                            Console.WriteLine("Consumo esperado para comodo entre 21 e 40m²: " + c_cozinha_p40 + " kWh");
                        }

                    if (area > 40)                   
                        if (c_cozinha > c_cozinha_p80)
                        {
                            economia = c_cozinha - c_cozinha_p80;
                            Console.WriteLine("\nComodo Cozinha: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do Comodo: " + c_cozinha + " kWh");
                            Console.WriteLine("Consumo esperado para comodo maior que 40m²: " + c_cozinha_p80 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Cozinha: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do Comodo: " + c_cozinha + " kWh");
                            Console.WriteLine("Consumo esperado para comodo maior que 40m²: " + c_cozinha_p80 + " kWh");
                        }

                    Console.WriteLine("========================================================================");

                    break;

                case 3: // COMPARA QUARTO

                    if (area >= 5 && area <= 20)                  
                        if (c_quarto > c_quarto_p20)
                        {
                            economia = c_quarto - c_quarto_p20;
                            Console.WriteLine("\nComodo Quarto: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do Comodo: " + c_quarto + " kWh");
                            Console.WriteLine("Consumo esperado para comodo de até 20m²: " + c_quarto_p20 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Quarto: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do Comodo: " + c_quarto + " kWh");
                            Console.WriteLine("Consumo esperado para comodo de até 20m²: " + c_quarto_p20 + " kWh");
                        }                 

                    if (area > 20 && area <= 40)          
                        if (c_quarto > c_quarto_p40)
                        {
                            economia = c_quarto - c_quarto_p40;
                            Console.WriteLine("\nComodo Quarto: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do comodo: " + c_quarto + " kWh");
                            Console.WriteLine("Consumo esperado para comodo entre 21 e 40m²: " + c_quarto_p40 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Quarto: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do comodo: " + c_quarto + " kWh");
                            Console.WriteLine("Consumo esperado para comodo entre 21 e 40m²: " + c_quarto_p40 + " kWh");
                        }  

                    if (area > 40)                  
                        if (c_quarto > c_quarto_p80)
                        {
                            economia = c_quarto - c_quarto_p80;
                            Console.WriteLine("\nComodo Quarto: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do comodo: " + c_quarto + " kWh");
                            Console.WriteLine("Consumo esperado para comodo maior que 40m²: " + c_quarto_p80 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Quarto: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do comodo: " + c_quarto + " kWh");
                            Console.WriteLine("Consumo esperado para comodo maior que 40m²: " + c_quarto_p80 + " kWh");
                        }

                    Console.WriteLine("========================================================================");

                    break;

                case 4: // COMPARA BANHEIRO

                    if (area >= 5 && area <= 20)                
                        if (c_banheiro > c_banheiro_p20)
                        {
                            economia = c_banheiro - c_banheiro_p20;
                            Console.WriteLine("\nComodo Banheiro: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do Comodo: " + c_banheiro + " kWh");
                            Console.WriteLine("Consumo esperado para comodo de até 20m²: " + c_banheiro_p20 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh"); ;
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Banheiro: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do Comodo: " + c_banheiro + " kWh");
                            Console.WriteLine("Consumo esperado para comodo de até 20m²: " + c_banheiro_p20 + " kWh"); ;
                        }                

                    if (area > 20 && area <= 40) 
                        if (c_banheiro > c_banheiro_p40)
                        {
                            economia = c_banheiro - c_banheiro_p40;
                            Console.WriteLine("\nComodo Banheiro: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do comodo: " + c_banheiro + " kWh");
                            Console.WriteLine("Consumo esperado para comodo entre 21 e 40m²: " + c_banheiro_p40 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Banheiro: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do comodo: " + c_banheiro + " kWh");
                            Console.WriteLine("Consumo esperado para comodo entre 21 e 40m²: " + c_banheiro_p40 + " kWh");
                        }

                    if (area > 40)                
                        if (c_banheiro > c_banheiro_p80)
                        {
                            economia = c_banheiro - c_banheiro_p80;
                            Console.WriteLine("\nComodo Banheiro: Possui consumo mais alto que nosso padrão!");
                            Console.WriteLine("\nConsumo do Comodo: " + c_banheiro + " kWh");
                            Console.WriteLine("Consumo esperado para comodo maior que 40m²: " + c_banheiro_p80 + " kWh");
                            Console.WriteLine("Quantidade que pode-se economizar: " + economia + " kWh");
                        }
                        else
                        {
                            Console.WriteLine("\nComodo Banheiro: Encontra-se dentro de nossos padrões de consumo");
                            Console.WriteLine("\nConsumo do Comodo: " + c_banheiro + " kWh");
                            Console.WriteLine("Consumo esperado para comodo maior que 40m²: " + c_banheiro_p80 + " kWh");
                        }

                    Console.WriteLine("========================================================================");
                    break;
               
            }             
        }  

        public void FuncionalidadesPadrões() //CRIA OS ELETRODOMESTICOS PADROES PARA SERVIR DE BASE NAS DICAS 
        {

            //Inicio da criação da Lista de Eletrodomesticos Padrões e Consumo

            /*TODOS OS VALORES DESCRITOS SÃO PARA EFEITO DE BASE PARA AS DICAS APENAS, ESTIPULADOS EM CIMA DE PESQUISAS,
              POIS OS MESMO VARIAM DE ACORDO COM A TARIFA DE CADA ESTADO E SEU TEMPO DE CONSUMO*/


            //Padrões para uma casa com comodos de 5m² até 20m²               NOME, KHW, QTD             Consumo  | Custo(mês)

            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 1));          // ~100kwh |  R$5,00  
            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 1));          // ~80kwh  |  R$3,00            
            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("dvd", 20, 1));                 // ~20kwh  |  R$1,00
            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 1));            // ~50kwh  |  R$2,00
            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 1));         // ~120kwh |  R$6,00
            sala_p20.Area_p = 20;

            //Consumo Padrão Sala até 20m² = 100 + 80 + 20 + 50 + 120 = 370 kwh (Utilizar este consumo para as dicas) 

            quarto_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 1));
            quarto_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 1));
            quarto_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 1));
            quarto_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 1));
            quarto_p20.Area_p = 20;

            //Consumo Padrão Quarto até 20m² = 100 + 80 + 50 + 120 = 350 kwh (Utilizar este consumo para as dicas)            

            banheiro_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("chuveiro", 120, 1));        // ~120kwh e R$6,00 
            banheiro_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 1));
            banheiro_p20.Area_p = 20;

            //Consumo Padrão Banheiro até 20m² = 120 + 50 = 170 kwh (Utilizar este consumo para as dicas)            

            cozinha_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("geladeira", 250, 1));        // ~250kwh e R$12,00 
            cozinha_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("maquina de lavar", 50, 1));  // ~50kwh e R$2,00 
            cozinha_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 1));
            cozinha_p20.Area_p = 20;

            //Consumo Padrão Cozinha até 20m² = 250 + 50 + 50 = 350 kwh (Utilizar este consumo para as dicas)
            //Consumo Total Esperado para um casa de até 20m² = 1240 kwh


            //Padrões para uma casa com comodos de 21m² até 40m² 

            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 2));
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("arcondicionado", 150, 1));      // ~150kwh |  R$7,50
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 1));
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("dvd", 20, 1));
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 2));
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 1));
            sala_p40.Area_p = 40;

            //Consumo Padrão Sala até 40m² = (100 * 2) + 150 + 80 + 20 + (50 * 2) + 120 = 670 kwh (Utilizar este consumo para as dicas)           

            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 2));
            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("arcondicionado", 150, 1));
            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 1));
            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 2));
            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 2));
            quarto_p40.Area_p = 40;

            //Consumo Padrão Quarto até 40m² = (100 * 2) + 150 + 80 + (50 * 2) + (120 * 2) = 770 kwh (Utilizar este consumo para as dicas)        

            banheiro_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("chuveiro", 120, 1));
            banheiro_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 3));
            banheiro_p40.Area_p = 40;

            //Consumo Padrão Banheiro até 40m² = 120 + (50 * 3) = 270 kwh (Utilizar este consumo para as dicas)          

            cozinha_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("geladeira", 250, 1));
            cozinha_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("microondas", 80, 1));       // ~80kwh |  R$3,00
            cozinha_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("maquina de lavar", 50, 1));
            cozinha_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 2));
            cozinha_p40.Area_p = 40;

            //Consumo Padrão Cozinha até 40m² = 250 + 80 + 50 + (50 * 2) = 480 kwh (Utilizar este consumo para as dicas)  
            //Consumo Total Esperado para um casa de até 40m² = 2190 kwh     


            //Padrões para uma casa com comodos mais de 40m²  

            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 2));
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("arcondicionado", 150, 1));
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 2));
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("dvd", 20, 2));
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 4));
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 2));
            sala_p80.Area_p = 40;

            //Consumo Padrão Sala maiores que 40m² = (100 * 2) + 150 + (80 * 2) + (20 * 2) + (50 * 4) + (120 * 2) = 990 kwh             

            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 3));
            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("arcondicionado", 150, 2));
            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 2));
            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 4));
            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 4));
            quarto_p80.Area_p = 40;

            //Consumo Padrão Quarto maiores que 40m² = (100 * 3) + (150 * 2) + (80 * 2) + (50 * 4) + (120 * 4) = 1440 kwh          

            banheiro_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("chuveiro", 120, 2));
            banheiro_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 6));
            banheiro_p80.Area_p = 40;

            //Consumo Padrão Banheiro maiores que 40m² = (120 * 2) + (50 * 6) = 540 kwh

            cozinha_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("geladeira", 250, 2));
            cozinha_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("microondas", 80, 2));
            cozinha_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("maquina de lavar", 50, 1));
            cozinha_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 4));
            cozinha_p80.Area_p = 40;

            //Consumo Padrão Cozinha até 40m² = (250 * 2) + (80 * 2) + 50 + (50 * 4) = 910 kwh  
            //Consumo Total Esperado para um casa de até 20m² = 3880 kwh


            //Fim da criação da Lista de Eletrodomesticos Padrões e Consumo 


            c_quarto_p20 = quarto_p20.ConsumoEnergiaPadrao();
            c_sala_p20 = sala_p20.ConsumoEnergiaPadrao();
            c_banheiro_p20 = banheiro_p20.ConsumoEnergiaPadrao();
            c_cozinha_p20 = cozinha_p20.ConsumoEnergiaPadrao();

            c_quarto_p40 = quarto_p40.ConsumoEnergiaPadrao();
            c_sala_p40 = sala_p40.ConsumoEnergiaPadrao();
            c_banheiro_p40 = banheiro_p40.ConsumoEnergiaPadrao();
            c_cozinha_p40 = cozinha_p40.ConsumoEnergiaPadrao();

            c_quarto_p80 = quarto_p80.ConsumoEnergiaPadrao();
            c_sala_p80 = sala_p80.ConsumoEnergiaPadrao();
            c_banheiro_p80 = banheiro_p80.ConsumoEnergiaPadrao();
            c_cozinha_p80 = cozinha_p80.ConsumoEnergiaPadrao();

            c_total_p20 = c_quarto_p20 + c_sala_p20 + c_banheiro_p20 + c_cozinha_p20;
            c_total_p40 = c_quarto_p40 + c_sala_p40 + c_banheiro_p40 + c_cozinha_p40;
            c_total_p80 = c_quarto_p80 + c_sala_p80 + c_banheiro_p80 + c_cozinha_p80;            

        }







    }
}
