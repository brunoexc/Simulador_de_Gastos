using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGastos
{
    public class OpcaoErradaMenuException : Exception
    {      
        
    }
    public class AreaInvalidaException : Exception
    {


    }


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
        public static StreamWriter sw;
        public static FileStream Fs;
        public static string Arq;


        static void Main(string[] args)
        {
            Arq = @"C:\Users\ucl\Source\Repos\Simulador_de_Gastos\log " + string.Format(DateTime.Now.ToString("dd_MM_yyyy (HH{0} mm{1} ss{2})"), "h","m","s") + ".txt";
            Fs = new FileStream(Arq, FileMode.OpenOrCreate, FileAccess.Write);
            sw = new StreamWriter(Fs, Encoding.UTF8);


            sw.WriteLine("Acesso do usuário no Simulador às " + DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy"));
            sw.WriteLine("");

            Menu();
            sim_sust.FuncionalidadesPadrões(); 

            while (opcao != 5)
            {
                Switch_Menu(opcao);
            }

            sw.Close();
            Fs.Close();
        }



      

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<  INICIO DOS METODOS DE NAVEGAÇÃO DA MAIN >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        public static int Menu()  // MENU PRINCIPAL
        {
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("                  Bem Vindo ao Simulador de Gastos");
            Console.WriteLine("========================================================================");
            Console.WriteLine("Escolha uma das opções\n");
            Console.WriteLine("1 - Cadastrar Eletrodoméstico");
            Console.WriteLine("2 - Ver Lista de Eletrodomesticos Cadastrados");
            Console.WriteLine("3 - Calcular Fatura");
            Console.WriteLine("4 - Dicas de Economia");            
            Console.WriteLine("5 - Sair do Simulador");

            try
            {
                opcao = int.Parse(Console.ReadLine());

                if(opcao < 1 || opcao > 5)
                {
                    throw new OpcaoErradaMenuException();
                }

            }
            catch(OpcaoErradaMenuException e)
            {
                sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                sw.WriteLine("Exceção OpçãoErradaMenu.Exception foi acionada no menu Menu Principal");
                sw.WriteLine("");

                Console.WriteLine("\nVocê precisa escolher uma das opções acima!");
                Console.WriteLine("\nPressione qualquer tecla para recomeçar.");
                Console.ReadKey();
                Menu();
            }          

            

            return opcao;
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< SWITCH DE OPÇAO DO MENU PRINCIPAL >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        public static void Switch_Menu(int opcao) 
        {
            int op_switch = 0;
            
                switch (opcao)
                {
                    case 1: //Cadastro de Eletrodomestico Escolhido no Menu Principal


                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Cadastro de Eletrodomésticos no Menu principal");
                    sw.WriteLine("");


                         Console.WriteLine("========================================================================");
                         Console.WriteLine("Cadastro de Eletromestico Escolhido \n");
                         Console.WriteLine("Escolha em qual comodo deseja cadastrar: \n");
                         Console.WriteLine("1 - Sala");
                         Console.WriteLine("2 - Cozinha");
                         Console.WriteLine("3 - Quarto");
                         Console.WriteLine("4 - Banheiro");
                         Console.WriteLine("5 - Voltar ao menu principal");

                         try
                         {
                            op_switch = int.Parse(Console.ReadLine());

                            if (op_switch < 1 || op_switch > 5)
                            {
                               throw new OpcaoErradaMenuException();
                            }

                         }
                         catch (OpcaoErradaMenuException e)
                         {
                            sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                            sw.WriteLine("Exceção OpçãoErradaMenu.Exception foi acionada no menu Cadastro de Eletrodomésticos");
                            sw.WriteLine("");

                            Console.WriteLine("\nVocê precisa escolher uma das opções acima!");
                            Console.WriteLine("\nPressione qualquer tecla para recomeçar.");
                            Console.ReadKey();
                            Console.Clear();
                            Switch_Menu(opcao);
                         }

                    


                    Menu_Case1(op_switch); // METODO COM SWITCH PARA CADASTRAR ELETRODOMESTICO EM COMODOS ESPECIFICOS

                         break;

                    case 2:  //Listar Eletrodomestico Escolhido no Menu Principal

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Listar Eletrodomésticos no Menu principal.");
                    sw.WriteLine("");

                         Console.WriteLine("========================================================================");
                         Console.WriteLine("Listar de Eletromestico Cadastrados Escolhido \n");
                         Console.WriteLine("Escolha uma opção: \n");
                         Console.WriteLine("1 - Listar Sala");
                         Console.WriteLine("2 - Listar Cozinha");
                         Console.WriteLine("3 - Listar Quarto");
                         Console.WriteLine("4 - Listar Banheiro");
                         Console.WriteLine("5 - Listar Todos os Comodos");
                         Console.WriteLine("6 - Voltar ao menu principal");

                         try
                         {
                            op_switch = int.Parse(Console.ReadLine());

                            if (op_switch < 1 || op_switch > 6)
                            { 
                               throw new OpcaoErradaMenuException();
                            }

                         }
                         catch (OpcaoErradaMenuException e)
                         {

                           sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                           sw.WriteLine("Exceção OpçãoErradaMenu.Exception foi acionada no menu Cadastro de Eletrodomésticos");
                           sw.WriteLine("");

                           Console.WriteLine("\nVocê precisa escolher uma das opções acima!");
                           Console.WriteLine("\nPressione qualquer tecla para recomeçar.");
                           Console.ReadKey();
                           Console.Clear();
                           Switch_Menu(opcao);
                         }

                    Menu_Case2(op_switch); // METODO PARA LISTAR ELETRODOMESTICO EM COMODOS ESPECIFICOS OU CASA TODA

                    break;

                    case 3: //Calcular Fatura Escolhido no Menu Principal

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Calcular Fatura no Menu principal");
                    sw.WriteLine("");

                    Console.WriteLine("=========================================================================");
                    Console.WriteLine("Escolha uma opção:  \n");
                    Console.WriteLine("1 - Valor gasto em energia no Quarto ");
                    Console.WriteLine("2 - Valor gasto em energia na Sala ");
                    Console.WriteLine("3 - Valor gasto em energia na Cozinha ");
                    Console.WriteLine("4 - Valor gasto de energia no Banheiro ");
                    Console.WriteLine("5 - Valor Total gasto em energia ");
                    Console.WriteLine("6 - Voltar ao menu principal");

                    try
                    {
                        op_switch = int.Parse(Console.ReadLine());

                        if (op_switch < 1 || op_switch > 6)
                        {
                            throw new OpcaoErradaMenuException();
                        }

                    }
                    catch (OpcaoErradaMenuException e)
                    {
                        Console.WriteLine("\nVocê precisa escolher uma das opções acima!");
                        Console.WriteLine("\nPressione qualquer tecla para recomeçar.");
                        Console.ReadKey();
                        Console.Clear();
                        Switch_Menu(opcao);
                    }

                    Menu_Case3(op_switch);

                    break;

                    case 4: //Dicas de economia Escolhido no Menu Principal

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Dicas de Economia no Menu principal");
                    sw.WriteLine("");

                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Dicas de Economia Selecionado \n");
                    Console.WriteLine("Escolha uma opção: \n");
                    Console.WriteLine("1 - Dicas de Economia para toda a casa");
                    Console.WriteLine("2 - Dicas de Economia para um comodo especifico");
                    Console.WriteLine("3 - Voltar ao menu principal");                       

                    try
                    {
                        op_switch = int.Parse(Console.ReadLine());

                        if (op_switch < 1 || op_switch > 3)
                        {
                            throw new OpcaoErradaMenuException();
                        }
                    }
                    catch (OpcaoErradaMenuException e)
                    {
                        sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                        sw.WriteLine("Exceção OpçãoErradaMenu.Exception foi acionada no menu Cadastro de Eletrodomésticos");
                        sw.WriteLine("");

                        Console.WriteLine("\nVocê precisa escolher uma das opções acima!");
                        Console.WriteLine("\nPressione qualquer tecla para recomeçar.");
                        Console.ReadKey();
                        Console.Clear();
                        Switch_Menu(opcao);
                    }

                    Menu_Case4(op_switch); // METODO COM SWITCH PARA FORNERCER DICAS DE ECONOMIA


                   break;

                    case 5:

                       opcao = 5;
                       Console.WriteLine("Obrigado por utilizar nosso sistema!");
                       Console.ReadKey();

                    break;

                  

                 }
            }


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< METODO PARA INSERIR ELETRODOMESTICOS EM COMODO >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public static void Menu_Case1(int opcao) 
        {
            string nome;
            float khw;
            int qtdED;
            Eletrodomésticos eletro;

            switch (opcao)
            {
                case 1:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Sala no menu Cadastro de Eletrodoméstico");
                    sw.WriteLine("");

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

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Cozinha no menu Cadastro de Eletrodoméstico");
                    sw.WriteLine("");

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

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Quarto no menu Cadastro de Eletrodoméstico");
                    sw.WriteLine("");

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

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Cozinha no menu Cadastro de Eletrodoméstico");
                    sw.WriteLine("");

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

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Voltar ao Menu Principal no menu Cadastro de Eletrodomésticos");
                    sw.WriteLine("");

                    Menu();
                                        
                    break;

            }
        }


        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<< METODO PARA IMPRESSAO DA LISTA DE ELETRODOMESTICO >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public static void Menu_Case2(int opcao) 
        {

            switch (opcao)
            {

                case 1:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Sala no menu Listar Eletrodomésticos");
                    sw.WriteLine("");

                    sala.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 2:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Cozinha no menu Listar Eletrodomésticos");
                    sw.WriteLine("");

                    cozinha.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 3:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Quarto no menu Listar Eletrodomésticos");
                    sw.WriteLine("");

                    quarto.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 4:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Banheiro no menu Listar Eletrodomésticos");
                    sw.WriteLine("");

                    banheiro.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 5:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Todos os Comôdos no menu Listar Eletrodomésticos");
                    sw.WriteLine("");

                    sala.ListarEletrodomestico();
                    cozinha.ListarEletrodomestico();
                    quarto.ListarEletrodomestico();
                    banheiro.ListarEletrodomestico();

                    Console.ReadKey();
                    Menu();
                    break;

                case 6:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Voltar ao Menu Principal no menu Listar Eletrodomésticos");
                    sw.WriteLine("");

                    Menu();                    
                    break;


            }

        }


        public static void Menu_Case3(int opcao)
        {
            Sim_Gastos Sim = new Sim_Gastos();

            switch (opcao)
            {
                case 1:
                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Quarto no menu Calcular Fatura");
                    sw.WriteLine("");

                    Sim.CalcularFatura(1,quarto,sala,cozinha,banheiro);                    
                    Menu();
                    break;
                case 2:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Sala no menu Calcular Fatura");
                    sw.WriteLine("");

                    Sim.CalcularFatura(2, quarto, sala, cozinha, banheiro);                   
                    Menu();
                    break;
                case 3:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Cozinha no menu Calcular Fatura");
                    sw.WriteLine("");

                    Sim.CalcularFatura(3, quarto, sala, cozinha, banheiro);                    
                    Menu();
                    break;
                case 4:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Banheiro no menu Calcular Fatura");
                    sw.WriteLine("");

                    Sim.CalcularFatura(4, quarto, sala, cozinha, banheiro);                   
                    Menu();
                    break;
                case 5:
                   
                    Sim.CalcularFaturaTotal(sala, cozinha, banheiro, quarto);                    
                    Menu();
                  
                break;

                case 6:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Voltar ao Menu Principal no menu Calcular Fatura");
                    sw.WriteLine("");

                    Menu();
                    
                    break;
            }
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< METODO PARA DICAS DE ECONOMIA DA CASA >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public static void Menu_Case4(int opcao) 
        {
            int area = 0;
            int op_switch = 0;

            switch (opcao)
            {
                case 1:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Dicas de Economia para Casa Toda no menu Menu Principal");
                    sw.WriteLine("");

                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Dicas de economia para toda a casa selecionado \n");
                    Console.WriteLine("Informe a area de sua residência");                    

                    try
                    {
                        area = int.Parse(Console.ReadLine());

                        if (area < 5)
                        {
                            throw new AreaInvalidaException();
                        }
                    }
                    catch (AreaInvalidaException e)
                    {
                        sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                        sw.WriteLine("Exceção OpçãoErradaMenu.Exception foi acionada no menu Dicas de Economia para Casa Toda");
                        sw.WriteLine("");

                        Console.WriteLine("\nArea fornecida é invalida ou abaixo do esperado");
                        Console.WriteLine("\nPressione qualquer tecla para recomeçar.");
                        Console.ReadKey();
                        Console.Clear();
                        Menu_Case4(opcao);
                    }

                    sim_sust.SimularEconomia(area, quarto, sala, banheiro, cozinha);

                    Console.ReadKey();

                    Menu();


                    break;


                case 2:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Dicas de Economia para os Comodos no menu Menu Principal");
                    sw.WriteLine("");

                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Dicas de economia por comodo selecionado \n");  
                    Console.WriteLine("Escolha em qual comodo deseja as dicas: \n");
                    Console.WriteLine("1 - Sala");
                    Console.WriteLine("2 - Cozinha");
                    Console.WriteLine("3 - Quarto");
                    Console.WriteLine("4 - Banheiro");
                    Console.WriteLine("5 - Voltar ao menu principal");
                    

                    try
                    {
                        op_switch = int.Parse(Console.ReadLine());

                        if (op_switch < 1 || op_switch > 6)                        
                            throw new OpcaoErradaMenuException();
                       

                        if(op_switch == 5)
                            Menu();


                        Console.WriteLine("\nInforme a area do comodo");
                        area = int.Parse(Console.ReadLine());                           

                        if (area < 5)
                           throw new AreaInvalidaException();


                        sim_sust.SimularEconomiaComodo(area, op_switch, quarto, sala, banheiro, cozinha);
                    }
                    catch (OpcaoErradaMenuException e)
                    {
                        sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                        sw.WriteLine("Exceção OpçãoErradaMenu.Exception foi acionada no menu Dicas de Economia para os Comodos");
                        sw.WriteLine("");

                        Console.WriteLine("\nVocê precisa escolher uma das opções acima!");
                        Console.WriteLine("\nPressione qualquer tecla para recomeçar.");
                        Console.ReadKey();
                        Console.Clear();
                        Menu_Case4(opcao);
                    }
                    catch(AreaInvalidaException e)
                    {
                        sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                        sw.WriteLine("Exceção AreaInvalidaExcpetion.Exception foi acionada no menu Dicas de Economia para os Comodos");
                        sw.WriteLine("");

                        Console.WriteLine("\nArea fornecida é invalida ou abaixo do esperado");
                        Console.WriteLine("\nPressione qualquer tecla para recomeçar.");
                        Console.ReadKey();
                        Console.Clear();
                        Menu_Case4(opcao);
                    }
                 
                    Console.ReadKey();
                    Console.Clear();
                    Menu();

                    break;

                case 3:

                    sw.Write(DateTime.Now.ToString("HH:mm:ss") + " - ");
                    sw.WriteLine("Foi escolhida opção Voltar ao Menu Principal no menu Dicas de Economia");
                    sw.WriteLine("");

                    Menu();     

                    break;
            }

        }



    }
}
