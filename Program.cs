using System;
using ProjetoEvento.ClassePai.ClassesFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            do
            {
                System.Console.WriteLine("Seja bem-vindo(a) ao Sistema de Ingressos Code-XP.");
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Show.");
                Console.WriteLine("2 - Teatro.");
                Console.WriteLine("3 - Cinema.");
                Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        OpcaoShow();
                        break;
                    
                    case "2":
                        OpcaoTeatro();
                        break;
                        
                    case "3":
                        Cinema();
                        break;                    

                    case "9":
                        System.Console.WriteLine("Obrigado por usar nosso sistema.");
                        System.Console.WriteLine("Volte sempre!");
                        break;                    
                    
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }    
            while(opcao != "9");     
        }
            
        static void OpcaoShow(){

            string opcao = "";
            do
            {
                Console.WriteLine("Digite a opção desejada:");
                System.Console.WriteLine("1 - Cadastrar Show.");
                System.Console.WriteLine("2 - Pesquisar Show.");
                System.Console.WriteLine("3 - Voltar.");
                
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                    {
                        Console.Write("Digite o título do Show: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Digite o local do Show: ");
                        string local = Console.ReadLine();
                        Console.Write("Digite o lotacao do Show: ");
                        int lotacao = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite a duração do Show(min): ");
                        string duracao = Console.ReadLine();
                        Console.Write("Digite o classificação do Show: ");
                        int classificacao = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite o data do Show: ");
                        DateTime data = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Digite o artista do Show: ");
                        string artista = Console.ReadLine();
                        Console.Write("Digite o genero musical do Show: ");
                        string generomusical = Console.ReadLine();
                        
                        Show show = new Show(titulo, local, lotacao, duracao, classificacao, data, artista, generomusical);

                        show.Cadastrar();

                        bool cadastrosucesso = show.Cadastrar();
                        if(cadastrosucesso)
                            Console.WriteLine("Show cadastrado com sucesso!");
                        else
                            Console.WriteLine("Ocorreu um erro, contate o administrador do sitema.");
                        break;
                    }

                    case "2":
                    {
                        Console.WriteLine("Como deseja realizar a pesquisa? ");
                        Console.WriteLine("1 - Título do show.");
                        Console.WriteLine("2 - Data do show.");
                        Console.WriteLine("9 - Voltar.");

                        string pesquisa1 = "";
                        pesquisa1 = Console.ReadLine();
                        switch (pesquisa1)
                        {
                            case "1":
                            {
                                Console.Write("Digite o títudo do show: ");
                                string titulo = Console.ReadLine();
                                Show show = new Show();
                                show.Pesquisar(titulo);
                                string resultado = show.Pesquisar(titulo);
                                Console.WriteLine(resultado);
                                break;
                            }
                            case "2":
                            {
                                Console.Write("Digite a data do Show: ");
                                DateTime data = Convert.ToDateTime(Console.ReadLine());
                                Show show = new Show();
                                string resultado = show.Pesquisar(data);
                                Console.WriteLine(resultado);
                                break;
                            }
                            default: Console.WriteLine("Nenhum show encontrado");
                                break;
                        }
                            break;
                    }
                    case "9":
                    {
                        return;
                    }
                        
                    default: Console.WriteLine("Opção Inválida.");
                        break;
                }      
            } while (opcao != "0");
        }

        static void OpcaoTeatro(){
            
            string opcao = "";
            do
            {
                System.Console.WriteLine("Digite a opção desejada:");
                System.Console.WriteLine("1 - Cadastrar peça de teatro.");
                System.Console.WriteLine("2 - Pesquisar peça de teatro");
                System.Console.WriteLine("3 - Votlar.");

                opcao = Console.ReadLine();
                switch(opcao)
                {
                    case "1":
                    {
                        
                        Console.Write("Digite o título da peça:");
                        string titulo = Console.ReadLine();
                        Console.Write("Digite o local da peça:");
                        string local = Console.ReadLine();
                        Console.Write("Digite a lotação do local:");
                        int lotacao = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite a duração da peça(min):");
                        string duracao = Console.ReadLine();
                        Console.Write("Digite a classificação indicativa da peça:");
                        int classificacao = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite a data da peça:");
                        DateTime data = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Digite o elenco da peça:");
                        string elenco = Console.ReadLine();
                        Console.Write("Digite o diretor da peça:");
                        string diretor = Console.ReadLine();

                        Teatro teatro = new Teatro(titulo, local, lotacao, duracao, classificacao, data, elenco, diretor);

                        teatro.Cadastrar();

                        bool cadastrosucesso = teatro.Cadastrar();
                        if(cadastrosucesso)
                            Console.WriteLine("Peça cadastrada com sucesso.");
                        else
                            Console.WriteLine("Ocorreu um erro, contate o administrador do sistema.");
                        break;
                    }

                    case "2":
                    {
                        Console.WriteLine("Como deseja realizar");
                        Console.WriteLine("1 - Título da peça.");
                        Console.WriteLine("2 - Data da apresentação.");
                        Console.WriteLine("3 - Voltar.");

                        string pesquisa1 = "";
                        pesquisa1 = Console.ReadLine();
                        
                        switch (pesquisa1)
                        {
                            case "1":
                            {
                                Console.Write("Digite o título da peça: ");
                                string titulo = Console.ReadLine();
                                Teatro teatro = new Teatro();
                                teatro.Pesquisar(titulo);
                                string resultado = teatro.Pesquisar(titulo);
                                Console.WriteLine(resultado);
                                break;
                            }
                            case "2":
                                Console.Write("Digite a data da peça (dd: ");
                                DateTime data = Convert.ToDateTime(Console.rea)   
                            default:

                                break;
                        }

                        break;
                    }
                
                }
            }
            while (true);
            {
                
            }
            
        }

        static void Cinema(){

        }
    }
}

