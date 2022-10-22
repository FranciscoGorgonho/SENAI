// See https://aka.ms/new-console-template for more information
using BE7_FS4_UC9;
using BE7_FS4_UC9.Classes;


Console.WriteLine(@$"
=================================================================================
*                                                                               *
*                              Seja Bem Vindo !                                 *
*               Sistema de Cadastro de Pessoas Físicas e Jurídicas              *
*                                                                               *
=================================================================================
");


BarraCarregamento("Carregando", 200);

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
=================================================================================
*                                                                               *
*                            Escolha uma das Opções:                            *
*_______________________________________________________________________________*
*                                                                               *
*                              1 - Pessoa Física                                *
*                              2 - Pessoa Jurídica                              *
*                                                                               *
*                              0  - Sair                                        *
*                                                                               *
=================================================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();
            PessoaFisica metodoPf = new PessoaFisica();
            novaPf.nome = "Dante Medeiros";
            novaPf.dataNascimento = "10/07/1991";
            novaPf.cpf = "177.182.300-55";
            novaPf.rendimento = 2000.0f;
            novoEnd.logradouro = "Praça Dezoito de Fevereiro";
            novoEnd.numero = 27;
            novoEnd.complemento = "Casa";
            novoEnd.endComercial = true;
            novaPf.endereco = novoEnd;

            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
            Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim" : "Não")}
            Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
            ");

            Console.WriteLine ($"Digite Enter para continuar");
            Console.ReadLine();
            break;


        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndpj = new Endereco();

            novaPj.nome = "KABUM";
            novaPj.cnpj = "17.184.037/0001-70";
            novaPj.razaoSocial = "KABUM COMÉRCIO ELETRÔNICO S.A";
            novaPj.rendimento = 8000.5f;
            novoEndpj.logradouro = "Avenida Campos Sales";
            novoEndpj.numero = 281;
            novoEndpj.complemento = "Galpão 07";
            novoEndpj.endComercial = true;


            Console.WriteLine($@"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaoSocial}
            CNPJ: {novaPj.cnpj}
            CNPJ é válido: {(metodoPj.ValidarCnpj(novaPj.cnpj) ?"Sim":"Não" )}
            O valor do imposto é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
            ");

            Console.WriteLine($"Digite Enter para sair");
            Console.ReadLine();
            break;

        case "0":
            Console.WriteLine($"Obrigado por utilizar nosso Sistema");
            BarraCarregamento("Finalizando", 300);

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida - Digite outra Opção");
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.DarkBlue;

    Console.Write($"{texto}");

    for (var contador = 0; contador < 35; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(250);
    }

    Console.ResetColor();
}


