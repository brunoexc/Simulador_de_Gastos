using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGastos
{
    class Program
    {
        public static int opcao = 0;

        public static Program program = new Program();        

        //Objetos para navegação de metodos das subclasses do usuário
        public static Quarto quarto = new Quarto();
        public static Sala sala = new Sala();
        public static Banheiro banheiro = new Banheiro();
        public static Cozinha cozinha = new Cozinha();
        public static Sim_Gastos sim_gastos = new Sim_Gastos();
        public static Sim_Sustentavel sim_sust = new Sim_Sustentavel();
        //Objetos para navegação de metodos das subclasses do usuário


        //Objetos para comparação nos metodos de dicas _p = padrão e os numeros são para suas respectivas areas
        public static Quarto quarto_p20 = new Quarto();
        public static Sala sala_p20 = new Sala();
        public static Banheiro banheiro_p20 = new Banheiro();
        public static Cozinha cozinha_p20 = new Cozinha();
        public static Sim_Gastos sim_gastos_p20 = new Sim_Gastos();
        public static Sim_Sustentavel sim_sust_p20 = new Sim_Sustentavel();


        public static Quarto quarto_p40 = new Quarto();
        public static Sala sala_p40 = new Sala();
        public static Banheiro banheiro_p40 = new Banheiro();
        public static Cozinha cozinha_p40 = new Cozinha();
        public static Sim_Gastos sim_gastos_p40 = new Sim_Gastos();
        public static Sim_Sustentavel sim_sust_p40 = new Sim_Sustentavel();


        public static Quarto quarto_p80 = new Quarto();
        public static Sala sala_p80 = new Sala();
        public static Banheiro banheiro_p80 = new Banheiro();
        public static Cozinha cozinha_p80 = new Cozinha();
        public static Sim_Gastos sim_gastos_p80 = new Sim_Gastos();
        public static Sim_Sustentavel sim_sust_p80 = new Sim_Sustentavel();

        //Objetos para comparação nos metodos de dicas _p = padrão e os numeros são para suas respectivas areas


        static void Main(string[] args)
        {
            
            Menu();
            FuncionalidadesPadrões();                     

            while (opcao != 6)
            {
                Switch_Menu(opcao);
            }
        }

      


        //<<<<<<<<<<<<<<<<<<  INICIO DOS METODOS DE NAVEGAÇÃO DA MAIN >>>>>>>>>>>>>>>>>>>>>>>


        public static int Menu()  // MENU PRINCIPAL
        {

            /*BLOCO PARA LEITURA DO LOG DO USUARIO, A DISCUTIR ONDE SERA REGISTRADO            
            
            FileStream fs = new FileStream("");
            StreamReader sr = new StreamReader(fs);           
            
            */       

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("                  Bem Vindo ao Simulador de Gastos");
            Console.WriteLine("========================================================================");
            Console.WriteLine("Escolha uma das opções\n");
            Console.WriteLine("1 - Cadastrar Eletrodoméstico");
            Console.WriteLine("2 - Ver Lista de Eletrodomesticos Cadastrados");
            Console.WriteLine("3 - Calcular Fatura");
            Console.WriteLine("4 - Dicas de Economia");
            Console.WriteLine("5 - Enviar bug ou sugestão");
            Console.WriteLine("6 - Sair do Simulador");
            opcao = int.Parse(Console.ReadLine());

            return opcao;
        }


        public static void Switch_Menu(int opcao) //SWITCH DE OPÇAO DO MENU PRINCIPAL
        {
            int op_switch = 0;
            
                switch (opcao)
                {
                    case 1: //Cadastro de Eletrodomestico Escolhido no Menu Principal

                         Console.WriteLine("========================================================================");
                         Console.WriteLine("Cadastro de Eletromestico Escolhido \n");
                         Console.WriteLine("Escolha em qual comodo deseja cadastrar: \n");
                         Console.WriteLine("1 - Sala");
                         Console.WriteLine("2 - Cozinha");
                         Console.WriteLine("3 - Quarto");
                         Console.WriteLine("4 - Banheiro");
                         Console.WriteLine("5 - Voltar ao menu principal");
                         op_switch = int.Parse(Console.ReadLine());
 
                         Menu_Case1(op_switch); // METODO COM SWITCH PARA CADASTRAR ELETRODOMESTICO EM COMODOS ESPECIFICOS

                         break;

                    case 2:  //Listar Eletrodomestico Escolhido no Menu Principal

                         Console.WriteLine("========================================================================");
                         Console.WriteLine("Listar de Eletromestico Cadastrados Escolhido \n");
                         Console.WriteLine("Escolha uma opção: \n");
                         Console.WriteLine("1 - Listar Sala");
                         Console.WriteLine("2 - Listar Cozinha");
                         Console.WriteLine("3 - Listar Quarto");
                         Console.WriteLine("4 - Listar Banheiro");
                         Console.WriteLine("5 - Listar Todos os Comodos");
                         Console.WriteLine("6 - Voltar ao menu principal");
                         op_switch = int.Parse(Console.ReadLine());

                         Menu_Case2(op_switch); // METODO PARA LISTAR ELETRODOMESTICO EM COMODOS ESPECIFICOS OU CASA TODA

                    break;

                    case 3: //Calcular Fatura Escolhido no Menu Principal

                         break;

                    case 4: //Dicas de economia Escolhido no Menu Principal

                        Console.WriteLine("========================================================================");
                        Console.WriteLine("Dicas de Economia Selecionado \n");
                        Console.WriteLine("Escolha uma opção: \n");
                        Console.WriteLine("1 - Dicas de Economia para toda a casa");
                        Console.WriteLine("2 - Dicas de Economia para um comodo especifico");
                        Console.WriteLine("3 - Voltar ao menu principal");
                        op_switch = int.Parse(Console.ReadLine());

                        Menu_Case4(op_switch); // METODO COM SWITCH PARA FORNERCER DICAS DE ECONOMIA


                        break;

                    case 5: // Enviar bug ou sugestão Escolhido no Menu Principal


                    break;

                    case 6: //Sair do Simulador Escolhido no Menu Principal

                        opcao = 6;
                        Console.WriteLine("Obrigado por utilizar nosso sistema!");
                        Console.ReadKey();
 

                        break;

                 }
            }        


        public static void Menu_Case1(int opcao) //METODO PARA INSERIR ELETRODOMESTICOS EM COMODO
        {
            string nome;
            float khw;
            int qtdED;
            Eletrodomésticos eletro;

            switch (opcao)
            {
                case 1:

                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Cadastro de Eletromestico na Sala Escolhido \n");
                    Console.WriteLine("Informe o nome do eletrodomestico:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Informe o consumo(Kilowatts/hora) do eletrodomestico:");
                    khw = float.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade de eletrodomestico no comodo:");
                    qtdED = int.Parse(Console.ReadLine());

                    eletro = new Eletrodomésticos(nome, khw, qtdED);



                    sala.InserirEletrodomestico(eletro);

                    Console.WriteLine("Cadastro Concluido com Sucesso");
                    Console.ReadKey();

                    Menu();

                    break;


                case 2:

                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Cadastro de Eletromestico na Cozinha Escolhido \n");
                    Console.WriteLine("Informe o nome do eletrodomestico:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Informe o consumo(Kilowatts/hora) do eletrodomestico:");
                    khw = float.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade de eletrodomestico no comodo:");
                    qtdED = int.Parse(Console.ReadLine());

                    eletro = new Eletrodomésticos(nome, khw, qtdED);

                    cozinha.InserirEletrodomestico(eletro);

                    Console.WriteLine("Cadastro Concluido com Sucesso");
                    Console.ReadKey();

                    Menu();

                    break;


                case 3:

                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Cadastro de Eletromestico na Quarto Escolhido \n");
                    Console.WriteLine("Informe o nome do eletrodomestico:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Informe o consumo(Kilowatts/hora) do eletrodomestico:");
                    khw = float.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade de eletrodomestico no comodo:");
                    qtdED = int.Parse(Console.ReadLine());

                    eletro = new Eletrodomésticos(nome, khw, qtdED);

                    quarto.InserirEletrodomestico(eletro);

                    Console.WriteLine("Cadastro Concluido com Sucesso");
                    Console.ReadKey();

                    Menu();
                    break;


                case 4:

                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Cadastro de Eletromestico na Cozinha Escolhido \n");
                    Console.WriteLine("Informe o nome do eletrodomestico:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Informe o consumo(Kilowatts/hora) do eletrodomestico:");
                    khw = float.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade de eletrodomestico no comodo:");
                    qtdED = int.Parse(Console.ReadLine());

                    eletro = new Eletrodomésticos(nome, khw, qtdED);

                    banheiro.InserirEletrodomestico(eletro);

                    Console.WriteLine("Cadastro Concluido com Sucesso");
                    Console.ReadKey();

                    Menu();
                    break;

                case 5:

                    Menu();
                                        
                    break;

            }
        }


        public static void Menu_Case2(int opcao) // METODO PARA IMPRESSAO DA LISTA DE ELETRODOMESTICO
        {

            switch (opcao)
            {

                case 1:
                    sala.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 2:
                    cozinha.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 3:
                    quarto.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 4:
                    banheiro.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 5:
                    sala.ListarEletrodomestico();
                    cozinha.ListarEletrodomestico();
                    quarto.ListarEletrodomestico();
                    banheiro.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 6:
                    Menu();
                    Console.ReadKey();
                    break;


            }

        }


        public static void Menu_Case4(int opcao) //METODO PARA DICAS DE ECONOMIA DA CASA TODA
        {


            switch (opcao)
            {
                case 1:
                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Dicas de Economia para toda a casa selecionado \n");
                    Console.WriteLine("Informe a area de sua residência \n");



                    break;


                case 2:


                    break;





            }



        }

        


        public static void FuncionalidadesPadrões() //CRIA OS ELETRODOMESTICOS PADROES PARA SERVIR DE BASE NAS DICAS 
        {

            //Inicio da criação da Lista de Eletrodomesticos Padrões e Consumo

            /*TODOS OS VALORES DESCRITOS SÃO PARA EFEITO DE BASE PARA AS DICAS APENAS, ESTIPULADOS EM CIMA DE PESQUISAS,
              POIS OS MESMO VARIAM DE ACORDO COM A TARIFA DE CADA ESTADO E SEU TEMPO DE CONSUMO*/


            //Padrões para uma casa com comodos de 2m² até 20m²               NOME, KHW, QTD             Consumo  | Custo(mês)

            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 1));          // ~100kwh |  R$5,00  
            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 1));          // ~80kwh  |  R$3,00            
            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("dvd", 20, 1));                 // ~20kwh  |  R$1,00
            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 1));            // ~50kwh  |  R$2,00
            sala_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 1));         // ~120kwh |  R$6,00
            sala_p20.Area_p = 20;           

            quarto_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 1));
            quarto_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 1));            
            quarto_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 1));
            quarto_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 1));
            quarto_p20.Area_p = 20;            

            banheiro_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("chuveiro", 120, 1));        // ~120kwh e R$6,00 
            banheiro_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 1));
            banheiro_p20.Area_p = 20;            

            cozinha_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("geladeira", 250, 1));        // ~250kwh e R$12,00 
            cozinha_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("maquina de lavar", 50, 1));  // ~50kwh e R$2,00 
            cozinha_p20.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 1));
            cozinha_p20.Area_p = 20; 


            //Padrões para uma casa com comodos de 21m² até 40m² 

            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 2));
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("arcondicionado", 150, 1));      // ~150kwh |  R$7,50
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 1));
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("dvd", 20, 1));
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 2));
            sala_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 1));
            sala_p40.Area_p = 40;            

            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 2));
            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("arcondicionado", 150, 1));
            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 1));
            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 2));
            quarto_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 2));
            quarto_p40.Area_p = 40;         

            banheiro_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("chuveiro", 120, 1));        
            banheiro_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 3));
            banheiro_p40.Area_p = 40;           

            cozinha_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("geladeira", 250, 1));
            cozinha_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("microondas", 80, 1));       // ~80kwh |  R$3,00
            cozinha_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("maquina de lavar", 50, 1));  
            cozinha_p40.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 2));
            cozinha_p40.Area_p = 40;     


            //Padrões para uma casa com comodos mais 40²  

            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 2));
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("arcondicionado", 150, 1));     
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 2));
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("dvd", 20, 2));
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 4));
            sala_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 2));
            sala_p80.Area_p = 40;            

            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("televisão", 100, 4));
            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("arcondicionado", 150, 2));
            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("computador", 80, 2));
            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 4));
            quarto_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("ventilador", 120, 4));
            quarto_p80.Area_p = 40;           

            banheiro_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("chuveiro", 120, 2));
            banheiro_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 6));
            banheiro_p80.Area_p = 40;

            cozinha_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("geladeira", 250, 1));
            cozinha_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("microondas", 80, 1));       
            cozinha_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("maquina de lavar", 50, 1));
            cozinha_p80.InserirEletrodomesticoPadrão(new Eletrodomésticos("lampadas", 50, 4));
            cozinha_p80.Area_p = 40;       


            //Fim da criação da Lista de Eletrodomesticos Padrões e Consumo 

        }


    }
}
