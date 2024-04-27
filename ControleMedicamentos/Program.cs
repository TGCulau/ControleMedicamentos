﻿namespace ControleMedicamentos
{
    public class Program
    {

        public static void Main()
        {
            Tela Display = new Tela();
            Funcoes Ferramentas = new Funcoes();
            Repositorio Repositorios = new Repositorio();


            Display.ChecagemPreLogin();

            Display.Login();

        }
    }

    public class Mensagens
    {
        public void CadastroComSucesso()
        {
            Cabecalho();
            Console.Write("Cadastro efetuado com sucesso!\n\nPrecione qualquer tecla para continuar.");
        }
        public void Erro()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("\n\n\n########################################################################################################################");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                                      ATENÇÃO                                                     ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                               Comando inválido. Por favor digite um comando válido.                              ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                      Precione qualquer tecla para continuar.                                     ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("########################################################################################################################");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.ReadKey();
            Cabecalho();
        }
        public void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("########################################################################################################################");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                           Secretaria de Saúde de Lages                                           ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                                  Farmácia Básica                                                 ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("########################################################################################################################\n");
            Console.ResetColor();
        }
        public void LoginErrado()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("\n\n\n########################################################################################################################");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                                       ERRO                                                       ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                         Dados não reconhecidos. Por favor verifique os dados digitados.                          ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                      Precione qualquer tecla para continuar.                                     ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("########################################################################################################################");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.ReadKey();
            Cabecalho();
        }

    }

    public class Tela : Repositorio
    {


        public void ChecagemPreLogin()
        {
            mensagem.Cabecalho();
            ferramenta.CheckPostinho();
            ferramenta.CheckFuncionario();
            ferramenta.CheckFornecedor();
        }
        public void Login()
        {
            mensagem.Cabecalho();
            ferramenta.LoginEmail("\n\nEmail: ");
            ferramenta.LoginSenha("\n\nSenha: ");
        }
        public void CadastroPosto()
        {
            mensagem.Cabecalho();
            Console.Write("O sistema não detectou nenhum posto cadastrado, por favor insira os seguintes dados.\n\nNome do bairro: ");
            string bairro = Console.ReadLine();
            string telefoneFormatado = ferramenta.OrganizarTelefone();
            int numerodaunidade = ferramenta.LerInt("\nDigite o numero da unidade: ");
            int existe = 1;
            Postinho = new Posto(bairro, telefoneFormatado, numerodaunidade, existe);

            repositorio.SalvarPostinho();

            mensagem.CadastroComSucesso();
        }
        public void CadastroFuncionario()
        {
            mensagem.Cabecalho();
            Console.Write("O sistema não detectou nenhum funcionário cadastrado, por favor insira os seguintes dados.\n\nNome: ");
            string nome = Console.ReadLine();
            int idade = ferramenta.LerInt("\nIdade: ");
            Console.Write("\nGenero: ");
            string genero = Console.ReadLine();
            string cpfformatado = ferramenta.OrganizarCPF();
            Console.Write("\nCargo: ");
            string cargo = Console.ReadLine();
            int matricula = ferramenta.LerInt("\nMatricula: ");
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            Console.Write("\nSenha: ");
            string senha = Console.ReadLine();
            int existe = 1;

            funcionario = new Funcionario(nome, idade, genero, cpfformatado, cargo, matricula, email, senha, existe);

            repositorio.SalvarFuncionario();

            mensagem.CadastroComSucesso();
        }
        public void CadastroFornecedor()
        {
            mensagem.Cabecalho();
            Console.Write("O sistema não detectou nenhum forncedor cadastrado, por favor insira os seguintes dados.\n\nNome do fornecedor: ");
            string nome = Console.ReadLine();
            string cnpjformatado = ferramenta.OrganizarCNPJ();
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            int prazo = ferramenta.LerInt("\nPrazo de entrega dos medicamentos: ");
            int existe = 1;

            fornecedor = new Fornecedor(nome, cnpjformatado, email, prazo, existe);

            repositorio.SalvarForncedor();

            mensagem.CadastroComSucesso();
        }
    }


}