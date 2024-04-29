namespace ControleMedicamentos
{
    public class Program
    {
        public static void Main()
        {
            #region CaixaDeTralha
            Repositorio repositorio = new Repositorio();
            Funcoes ferramenta = new Funcoes(null, repositorio);
            Tela Display = new Tela(ferramenta);
            #endregion CaixaDeTralha

            Display.ChecagemPreLogin();

            Display.Login();

            Display.MenuPrincipal();
        }
    }

    public class Mensagens : Repositorio
    {
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
        public void CadastroComSucesso()
        {
            Cabecalho();
            Console.Write("Cadastro efetuado com sucesso!\n\nPrecione qualquer tecla para continuar.");
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
        public void Saudacao()
        {
            string bemvindo = "Bem-Vind", pronome = "";

            if (funcionario.Genero == "Homem")
            {
                bemvindo += "o";
                pronome = "Sr.";
            }
            else if (funcionario.Genero == "Mulher")
            {
                bemvindo += "a";
                pronome = "Sra.";
            }
            Cabecalho();
            Console.Write($"Seja {bemvindo} {pronome}{funcionario.Nome}.");
        }
        public void SolicitarMaisRemédio()
        {
            if ()
                Console.Write("\n\n");

            edicamento.
        }
    }

    public class Tela(Funcoes ferramenta) : Mensagens
    {
        Funcoes ferramenta = ferramenta;
        Mensagens mensagem;

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
        public void MenuPrincipal()
        {
            mensagem.Saudacao();
            Console.Write("\n\n\nMenu Principal\n1. Novos cadastros internos\n2. Prontuario\n3. Solicitar Remedio\n4. Verficiar o Estoque\n5.Logout");



        }
    }
}


