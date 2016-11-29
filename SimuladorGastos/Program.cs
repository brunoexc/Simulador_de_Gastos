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
        
                 

        //Objetos para navegação de metodos das subclasses do usuário
        public static Quarto quarto = new Quarto();
        public static Sala sala = new Sala();
        public static Banheiro banheiro = new Banheiro();
        public static Cozinha cozinha = new Cozinha();
        public static Sim_Gastos sim_gastos = new Sim_Gastos();
        public static Sim_Sustentavel sim_sust = new Sim_Sustentavel();
        //Objetos para navegação de metodos das subclasses do usuário


        //Objetos para comparação nos metodos de dicas _p = padrão e os numeros são para suas respectivas areas

       



        //Objetos para comparação nos metodos de dicas _p = padrão e os numeros são para suas respectivas areas


        static void Main(string[] args)
        {

            Menu();
            sim_sust.FuncionalidadesPadrões();       
                                        

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

                    Console.WriteLine("=========================================================================");
                    Console.WriteLine("Escolha uma opção:  \n");
                    Console.WriteLine("1 - Valor gasto em energia no Quarto ");
                    Console.WriteLine("2 - Valor gasto em energia na Sala ");
                    Console.WriteLine("3 - Valor gasto em energia na Cozinha ");
                    Console.WriteLine("4 - Valor gasto de energia no Banheiro ");
                    Console.WriteLine("5 - Valor Total gasto em energia ");
                    Console.WriteLine("6 - Voltar ao menu principal");
                    op_switch = int.Parse(Console.ReadLine());

                    Menu_Case3(op_switch);

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


        public static void Menu_Case3(int opcao)
        {
            Sim_Gastos Sim = new Sim_Gastos();

            switch (opcao)
            {
                case 1:
                    Sim.CalcularFatura(1,quarto,sala,cozinha,banheiro);
                    Console.ReadKey();
                    Menu();
                    break;
                case 2:
                    Sim.CalcularFatura(2, quarto, sala, cozinha, banheiro);
                    Console.ReadKey();
                    Menu();
                    break;
                case 3:
                    Sim.CalcularFatura(3, quarto, sala, cozinha, banheiro);
                    Console.ReadKey();
                    Menu();
                    break;
                case 4:
                    Sim.CalcularFatura(4, quarto, sala, cozinha, banheiro);
                    Console.ReadKey();
                    Menu();
                    break;
                case 5:
                   /*
                    Sim.CalcularFaturaTotal(sala, cozinha, banheiro, quarto);
                    Console.ReadKey();
                    program.Menu();
                */   
                break;

                case 6:
                    Menu();
                    Console.ReadKey();
                    break;
            }
        }


        public static void Menu_Case4(int opcao) //METODO PARA DICAS DE ECONOMIA DA CASA
        {
            int area = 0;
            int op_switch = 0;

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Dicas de economia para toda a casa selecionado \n");
                    Console.WriteLine("Informe a area de sua residência");
                    area = int.Parse(Console.ReadLine());

                    sim_sust.SimularEconomia(area, quarto, sala, banheiro, cozinha);

                    Console.ReadKey();

                    Menu();


                    break;


                case 2:
                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Dicas de economia por comodo selecionado \n");  
                    Console.WriteLine("Escolha em qual comodo deseja as dicas: \n");
                    Console.WriteLine("1 - Sala");
                    Console.WriteLine("2 - Cozinha");
                    Console.WriteLine("3 - Quarto");
                    Console.WriteLine("4 - Banheiro");
                    Console.WriteLine("5 - Voltar ao menu principal");
                    op_switch = int.Parse(Console.ReadLine());                     

                    if (op_switch == 1 || op_switch == 2 || op_switch == 3 || op_switch == 4)
                    {
                        Console.WriteLine("\nInforme a area do comodo");
                        area = int.Parse(Console.ReadLine());

                        sim_sust.SimularEconomiaComodo(area, op_switch, quarto, sala, banheiro, cozinha);
                    }
                      

                    if (op_switch == 5)
                        Menu();

                    if(op_switch < 1 || op_switch > 5)
                    {  
                        // CRIAR EXECÇÂO PARA SELEÇÂO ERRADA
                    }

                    Console.ReadKey();
                    Console.Clear();
                    Menu();

                    break;
            }






        }

        




    }
}
