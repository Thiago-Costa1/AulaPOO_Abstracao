using System;
using Nova_pasta.classes;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            Boleto bol = new Boleto();
            Credito cre = new Credito();
            Debito deb = new Debito();
            string resposta = "";


             Console.WriteLine("Olá, o que deseja fazer? ");
            do
            {   Console.WriteLine("Selecione uma das opções abaixo");
               
                Console.WriteLine("[1] - Salvar cartão ");
                Console.WriteLine("[2] - Registrar boleto");
                Console.WriteLine("[3] - Pagar");
                Console.WriteLine("[4] - Cancelar pagamento");
                Console.WriteLine("[5] - Mostrar dados");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Para salvar selecione um cartão: ");
                        Console.WriteLine("[1] - Crédito");
                        Console.WriteLine("[2] - Débito");
                        int escolha1 = int.Parse(Console.ReadLine());
                        switch (escolha1)
                        {
                            case 1:
                                Console.Write("Digite a bandeira: ");
                                cre.bandeira = Console.ReadLine();
                                Console.Write("Digite o número do cartão: ");
                                cre.numero = Console.ReadLine();
                                Console.Write("Digite o nome do titular do cartão: ");
                                cre.titular = Console.ReadLine();
                                Console.Write("Digite o cvv: ");
                                cre.cvv = Console.ReadLine();

                                Console.WriteLine("Seu cartão foi salvo no sistema!");
                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;

                            case 2:
                                Console.Write("Digite a bandeira: ");
                                deb.bandeira = Console.ReadLine();
                                Console.Write("Digite o número do cartão: ");
                                deb.numero = Console.ReadLine();
                                Console.Write("Digite o nome do titular do cartão: ");
                                deb.titular = Console.ReadLine();
                                Console.Write("Digite o cvv: ");
                                deb.cvv = Console.ReadLine();

                                Console.WriteLine("Seu cartão foi salvo no sistema!");
                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");

                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                        }
                        break;

                    case 2:
                        Console.Write("Escreva a linha de seu boleto: ");
                        bol.CodigoDeBarras = Console.ReadLine();
                        Console.WriteLine("Ok, registrado com sucesso!");
                        Console.WriteLine("Quer voltar para o menu? [s/n] ");
                        resposta = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Deseja pagar como? ");
                        Console.WriteLine("[1] - Boleto");
                        Console.WriteLine("[2] - Crédito");
                        Console.WriteLine("[3] - Débito");
                        int compra = int.Parse(Console.ReadLine());

                        switch (compra)
                        {
                            case 1:
                                Console.WriteLine("Digite o valor do produto?");
                                int valor = int.Parse(Console.ReadLine());

                                Console.WriteLine(bol.Desconto(valor));
                                Console.WriteLine("Quer voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("Digite o valor do produto?");
                                int valor2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Quer parcelar em quantas vezes?");
                                int parcela = int.Parse(Console.ReadLine());
                                cre.Pagar(valor2, parcela);

                                Console.WriteLine("Quer voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();                             
                                break;

                            case 3:
                                Console.WriteLine("Digite o valor do produto?");
                                int valor1 = int.Parse(Console.ReadLine());

                                deb.Pagar(valor1);
                                Console.WriteLine("Quer voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                                
                            default:

                            break;
                        }
                        
                        break;

                    case 4:
                        Console.WriteLine(deb.Cancelar());
                        Console.WriteLine("Quer voltar para o menu? [s/n] ");
                        resposta = Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Selecione uma opção para mostrar os dados dos seguites cartões: ");
                        Console.WriteLine("[1] - Crédito");
                        Console.WriteLine("[2] - Débito");
                        int escolha3 = int.Parse(Console.ReadLine());

                        switch (escolha3)
                        {
                            case 1:
                                Console.WriteLine(cre.SalvarCartao());
                                Console.WriteLine($"O Limite é: {cre.Limite}");

                                Console.WriteLine("Quer voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine(deb.SalvarCartao());
                                Console.WriteLine($"O Saldo é de: {deb.SaldoNaConta}");

                                Console.WriteLine("Quer voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");

                                Console.WriteLine("Quer voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                        }
                        break;

                
                }
            } while (resposta == "s");

        }
    }
}
}