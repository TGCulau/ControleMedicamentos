namespace ControleMedicamentos
{
    public class Funcoes : Repositorio
    {
        Tela display;
        Mensagens mensagem;
        Repositorio repositorio;
        public Funcoes(Tela display, Repositorio repositorio)
        {
            this.display = display;
            this.repositorio = repositorio;
        }
        public int LerInt(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = int.TryParse(Console.ReadLine(), out var numero);
                if (digitouNumero)
                {
                    return numero;
                }
                mensagem.Erro();
            }
        }
        public bool ChecagemLong(string texto)
        {
            while (true)
            {
                var digitouNumero = long.TryParse(texto, out var numero);
                if (digitouNumero)
                {
                    return true;
                }
                mensagem.Erro();
            }
        }
        public void CheckFornecedor()
        {
            bool existeInformacaoNoArquivo = repositorio.LeituraForncedor();
            if (existeInformacaoNoArquivo == false)
            {
                CadastroFornecedor();
            }
        }
        public void CheckFuncionario()
        {
            bool existeInformacaoNoArquivo = repositorio.LeituraFuncionario();
            if (existeInformacaoNoArquivo == false)
            {
                CadastroFuncionario();
            }
        }
        public void CheckPostinho()
        {
            bool existeInformacaoNoArquivo = repositorio.LeituraPostinho();
            if (existeInformacaoNoArquivo == false)
            {
                CadastroPosto();
            }
        }
        public string CheckGenero(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = int.TryParse(Console.ReadLine(), out var numero);
                if (!digitouNumero)
                {
                    mensagem.Erro();
                    continue;
                }
                if (numero != 1 && numero != 2)
                {
                    mensagem.Erro();
                    continue;
                }
                string genero = Convert.ToString(numero);
                return genero;
            }
        }
        public string OrganizarCPF()
        {
            string cpf;
            while (true)
            {
                Console.Write("\nDigite o seu CPF: ");
                cpf = Console.ReadLine();
                bool DigitouCerto = ChecagemLong(cpf);
                if (!DigitouCerto)
                {
                    mensagem.Erro();
                    continue;
                }
                if (cpf.Length > 11)
                {
                    mensagem.Erro();
                    continue;
                }
                break;
            }

            string cpforganizado = "";
            int cont = 0;
            char[] aux = new char[11];
            foreach (char numero in cpf)
            {

                if (cont <= 2)
                {
                    cpforganizado += numero;
                }
                if (cont == 3)
                {
                    cpforganizado = cpforganizado + ".";
                }
                if (cont >= 3 && cont <= 5)
                {
                    cpforganizado += numero;
                }
                if (cont == 6)
                {
                    cpforganizado = cpforganizado + ".";
                }
                if (cont >= 6 && cont <= 8)
                {
                    cpforganizado += numero;
                }
                if (cont == 9)
                {
                    cpforganizado = cpforganizado + "-";
                }
                if (cont >= 9)
                {
                    cpforganizado += numero;
                }
                cont++;
            }
            return cpforganizado;
        }
        public string OrganizarTelefone()
        {

            string telefone;
            while (true)
            {
                Console.Write("\nTelefone fixo para contato (apenas numeros): ");
                telefone = Console.ReadLine();
                bool DigitouCerto = ChecagemLong(telefone);
                if (!DigitouCerto)
                {
                    mensagem.Erro();
                    continue;
                }
                if (telefone.Length > 10)
                {
                    mensagem.Erro();
                    continue;
                }
                break;
            }
            string telefoneFormatado = "";
            int cont = 0;
            char[] aux = new char[10];
            if (telefone.Length == 8)
            {
                foreach (char numero in telefone)
                {
                    if (cont <= 3)
                    {
                        telefoneFormatado += numero;
                    }
                    if (cont == 3)
                    {
                        telefoneFormatado += '-';
                    }
                    if (cont > 3)
                    {
                        telefoneFormatado += numero;
                    }
                    cont++;
                }
                telefoneFormatado = $"(49) {telefoneFormatado}";
            }
            else if (telefone.Length == 10)
            {
                foreach (char numero in telefone)
                {
                    if (cont == 0)
                    {
                        telefoneFormatado += '(';
                    }
                    if (cont < 2)
                    {
                        telefoneFormatado += numero;
                    }
                    if (cont == 2)
                    {
                        telefoneFormatado += ')';
                        telefoneFormatado += ' ';
                    }
                    if (cont >= 2 && cont <= 5)
                    {
                        telefoneFormatado += numero;
                    }
                    if (cont == 5)
                    {
                        telefoneFormatado += '-';
                    }
                    if (cont > 5)
                    {
                        telefoneFormatado += numero;
                    }
                    cont++;
                }
            }
            return telefoneFormatado;
        }
        public string OrganizarCNPJ()
        {
            string CNPJ;
            while (true)
            {
                Console.Write("\nCNPJ: ");
                string auxiliar = Console.ReadLine();
                bool DigitouCerto = ChecagemLong(auxiliar);
                if (!DigitouCerto)
                {
                    mensagem.Erro();
                    continue;
                }
                CNPJ = Convert.ToString(auxiliar);
                if (CNPJ.Length > 14)
                {
                    mensagem.Erro();
                    continue;
                }
                break;
            }
            string CNPJFormatado = "";
            int cont = 0;
            char[] aux = new char[14];

            foreach (char numero in CNPJ)
            {
                if (cont < 2)
                {
                    CNPJFormatado += numero;
                }
                if (cont == 2)
                {
                    CNPJFormatado += '.';
                }
                if (cont >= 2 && cont < 5)
                {
                    CNPJFormatado += numero;
                }
                if (cont == 5)
                {
                    CNPJFormatado += '.';
                }
                if (cont >= 5 && cont < 8)
                {
                    CNPJFormatado += numero;
                }
                if (cont == 8)
                {
                    CNPJFormatado += '/';
                }
                if (cont >= 8 && cont < 12)
                {
                    CNPJFormatado += numero;
                }
                if (cont == 12)
                {
                    CNPJFormatado += '-';
                }
                if (cont >= 12 && cont < 14)
                {
                    CNPJFormatado += numero;
                }
                cont++;
            }

            Console.Write($"CNPJ ORGANIZADO: {CNPJFormatado}");
            Console.ReadLine();
            return CNPJFormatado;
        }
        public void LoginEmail(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                string email = Console.ReadLine();
                if (email != funcionario.Email)
                {
                    mensagem.LoginErrado();
                    continue;
                }
            }
        }
        public void LoginSenha(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                string senha = Console.ReadLine();
                if (senha != funcionario.Senha)
                {
                    mensagem.LoginErrado();
                    continue;
                }
            }
        }
        public void CadastroPosto()
        {
            mensagem.Cabecalho();
            Console.Write("O sistema não detectou nenhum posto cadastrado, por favor insira os seguintes dados.\n\nNome do bairro: ");
            string bairro = Console.ReadLine();
            string telefoneFormatado = OrganizarTelefone();
            int numerodaunidade = LerInt("\nDigite o numero da unidade: ");

            postinho = new Posto(bairro, telefoneFormatado, numerodaunidade);

            repositorio.SalvarPostinho();

            mensagem.CadastroComSucesso();
        }
        public void CadastroFuncionario()
        {
            mensagem.Cabecalho();
            Console.Write("O sistema não detectou nenhum funcionário cadastrado, por favor insira os seguintes dados.\n\nNome: ");
            string nome = Console.ReadLine();
            int idade = LerInt("\nIdade: ");
            string genero = CheckGenero("\nGenero\n1. Homem\n2. Mulher\nSua opção: ");
            string cpfformatado = OrganizarCPF();
            Console.Write("\nCargo: ");
            string cargo = Console.ReadLine();
            int matricula = LerInt("\nMatricula: ");
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            Console.Write("\nSenha: ");
            string senha = Console.ReadLine();

            funcionario = new Funcionario(nome, idade, genero, cpfformatado, cargo, matricula, email, senha);

            repositorio.SalvarFuncionario();

            mensagem.CadastroComSucesso();
        }
        public void CadastroFornecedor()
        {
            mensagem.Cabecalho();
            Console.Write("O sistema não detectou nenhum forncedor cadastrado, por favor insira os seguintes dados.\n\nNome do fornecedor: ");
            string nome = Console.ReadLine();
            string cnpjformatado = OrganizarCNPJ();
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            int prazo = LerInt("\nPrazo de entrega dos medicamentos: ");

            fornecedor = new Fornecedor(nome, cnpjformatado, email, prazo);

            repositorio.SalvarForncedor();

            mensagem.CadastroComSucesso();
        }










        public decimal LerDecimal(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = decimal.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }
                mensagem.Erro();
            }
        }
        public string Data(string nomeequipamento)
        {
            string data = "", mesaux = "", diaaux = "";
            while (true)
            {
                int dia = LerInt($"\nDigite o dia de fabricação do produto {nomeequipamento}: ");
                if (dia < 0 || dia > 31)
                {
                    mensagem.Erro();
                    continue;
                }
                int mes = LerInt($"\nDigite o mês, em numero, de fabricação do produto {nomeequipamento}: ");
                if (mes < 0 || mes > 12)
                {
                    mensagem.Erro();
                    continue;
                }
                int ano = LerInt($"\nDigite o ano de fabricação do produto {nomeequipamento}: ");
                if (ano > 2024)
                {
                    mensagem.Erro();
                    continue;
                }

                mesaux = $"{mes}";
                diaaux = $"{dia}";

                if (mes < 10)
                {
                    mesaux = $"0{mes}";
                }
                if (dia < 10)
                {
                    diaaux = $"0{dia}";
                }
                data = $"{diaaux}/{mesaux}/{ano}";
                return data;
            }
        }
        public int VerificacaoRemedio(int NI)
        {
            int opcaomenu = 0;
            if (NI == -1)
            {
                mensagem.Cabecalho();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Nenhum produto cadastrado ainda.");
                Console.ForegroundColor = ConsoleColor.Magenta;
                opcaomenu = LerInt("\n\nO que deseja fazer?\n\n1. Voltar ao menu\n2. Cadastrar um produto\nSua opção: ");
            }
            return opcaomenu;
        }
    }
}