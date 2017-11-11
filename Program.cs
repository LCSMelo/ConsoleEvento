using System;
using ProjetoEvento.ClassePai.ClassesFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            do{
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
                        Teatro();
                        break;
                        
                    case "3":
                        Cinema();
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
                        System.Console.Write("Digite o títudo do show: ");
                        string titulo = Console.ReadLine();
                        Show show = new Show();
                        show.Pesquisar(titulo);
                        string resultado = show.Pesquisar(titulo);
                        Console.WriteLine(resultado);
                        break;
                    }

                    case "3":
                    {
                        Console.Write("Digite a data do Show: ");
                        DateTime data = Convert.ToDateTime(Console.ReadLine());
                        Show show = new Show();
                        string resultado = show.Pesquisar(data);
                        Console.WriteLine(resultado);
                        break;
                    }
                        
                    default: Console.WriteLine("Opção Inválida");
                        break;
                }      
            } while (opcao != "9");
        }

        static void Teatro(){

        }

        static void Cinema(){

        }
    
    }


}

