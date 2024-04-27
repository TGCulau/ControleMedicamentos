namespace ControleMedicamentos

{
    public class Repositorio
    {
        public Posto Postinho { get; set; }
        public Funcionario funcionario { get; set; }
        public Fornecedor fornecedor { get; set; }

        public void LeituraPostinho()
        {
            string PostinhoBD = "PostinhoBD.txt";
            //1 = sim / 0 = não
            int existe = 1;
            //Verifica se o arquivo existe
            if (!File.Exists(PostinhoBD))
            {
                // Cria o arquivo e fecha-o imediatamente
                File.Create(PostinhoBD).Close();
                existe = 0;
            }

            //Lê as linhas do arquivo PostinhoBD.txt
            string[] linhadotxt = File.ReadAllLines(PostinhoBD);

            string bairro = "", telefoneFormatado = "";
            int numerodaunidade = 0;

            foreach (string linhalida in linhadotxt)
            {
                // Divide a linha em partes usando a vírgula como separador
                string[] coluna = linhalida.Split(',');

                bairro = coluna[0];
                telefoneFormatado = coluna[1];
                numerodaunidade = int.Parse(coluna[2]);
                existe = int.Parse(coluna[3]);
            }
            Postinho = new Posto(bairro, telefoneFormatado, numerodaunidade, existe);
        }
        public void SalvarPostinho()
        {
            string PostinhoBD = "PostinhoBD.txt";
            // Prepara a linha para ser escrita no arquivo
            string linha = $"{Postinho.Bairro},{Postinho.TelefoneFormatado},{Postinho.NumeroDaUnidade},{Postinho.Existe}";
            // Escreve a linha no arquivo
            File.AppendAllText(PostinhoBD, linha + Environment.NewLine);
        }
        public void LeituraFuncionario()
        {
            string FuncionarioBD = "FuncionarioBD.txt";
            //1 = sim / 0 = não
            int existe = 1;
            //Verifica se o arquivo existe
            if (!File.Exists(FuncionarioBD))
            {
                // Cria o arquivo e fecha-o imediatamente
                File.Create(FuncionarioBD).Close();
                existe = 0;
            }

            //Lê as linhas do arquivo FuncionarioBD.txt
            string[] linhadotxt = File.ReadAllLines(FuncionarioBD);

            string nome = "", email = "", senha = "", genero = "", cpfformatado = "", cargo = "";
            int idade = 0, matricula = 0;

            foreach (string linhalida in linhadotxt)
            {
                // Divide a linha em partes usando a vírgula como separador
                string[] coluna = linhalida.Split(',');

                nome = coluna[0];
                idade = int.Parse(coluna[1]);
                genero = coluna[2];
                cpfformatado = coluna[3];
                cargo = coluna[4];
                matricula = int.Parse(coluna[5]);
                email = coluna[6];
                senha = coluna[7];
                existe = int.Parse(coluna[8]);
            }
            funcionario = new Funcionario(nome, idade, genero, cpfformatado, cargo, matricula, email, senha, existe);
        }
        public void SalvarFuncionario()
        {
            string FuncionarioBD = "FuncionarioBD.txt";
            // Prepara a linha para ser escrita no arquivo
            string linha = $"{funcionario.Nome},{funcionario.Idade},{funcionario.CPFFormatado},{funcionario.Cargo},{funcionario.Matricula},{funcionario.Email},{funcionario.Senha}";
            // Escreve a linha no arquivo
            File.AppendAllText(FuncionarioBD, linha + Environment.NewLine);
        }
        public void LeituraForncedor()
        {
            string FornecedorBD = "FornecedorBD.txt";
            //1 = sim / 0 = não
            int existe = 1;
            //Verifica se o arquivo existe
            if (!File.Exists(FornecedorBD))
            {
                // Cria o arquivo e fecha-o imediatamente
                File.Create(FornecedorBD).Close();
                existe = 0;
            }

            //Lê as linhas do arquivo FornecedorBD.txt
            string[] linhadotxt = File.ReadAllLines(FornecedorBD);

            string nome = "", cnpjformatado = "", email = "";
            int prazo = 0;

            foreach (string linhalida in linhadotxt)
            {
                // Divide a linha em partes usando a vírgula como separador
                string[] coluna = linhalida.Split(',');

                nome = coluna[0];
                cnpjformatado = coluna[1];
                email = coluna[2];
                prazo = int.Parse(coluna[3]);
                existe = int.Parse(coluna[4]);
            }
            fornecedor = new Fornecedor(nome, cnpjformatado, email, prazo, existe);
        }
        public void SalvarForncedor()
        {
            string FornecedorBD = "FornecedorBD.txt";
            // Prepara a linha para ser escrita no arquivo
            string linha = $"{fornecedor.Nome},{fornecedor.CNPJFormatado},{fornecedor.Email},{fornecedor.Prazo},{fornecedor.Existe}";
            // Escreve a linha no arquivo
            File.AppendAllText(FornecedorBD, linha + Environment.NewLine);
        }

    }
    public class Posto
    {
        public string Bairro = "", TelefoneFormatado = "";
        public int NumeroDaUnidade;
        public int Existe;

        public Posto(string bairro, string telefoneFormatado, int numerodaunidade, int existe)
        {
            Bairro = bairro;
            NumeroDaUnidade = numerodaunidade;
            TelefoneFormatado = telefoneFormatado;
            Existe = existe;
        }
    }
    public class Funcionario
    {
        public string Nome = "", Email = "", CPFFormatado = "", Cargo = "", Senha = "", Genero = "";
        public int Idade, Matricula, Existe;

        public Funcionario(string nome, int idade, string genero, string cpfformatado, string cargo, int matricula, string email, string senha, int existe)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
            Existe = existe;
            CPFFormatado = cpfformatado;
            Cargo = cargo;
            Matricula = matricula;
            Email = email;
            Senha = senha;
        }
    }
    public class Fornecedor
    {
        public string Nome = "", Email = "", CNPJFormatado = "";
        public int Prazo, Existe;

        public Fornecedor(string nome, string cnpjformatado, string email, int prazo, int existe)
        {
            Nome = nome;
            CNPJFormatado = cnpjformatado;
            Email = email;
            Prazo = prazo;
            Existe = existe;
        }
    }
    public class Medicamento
    {
        public string Nome = "", Tipo = "";
        public bool EControlado;
        public int QuantidadeDeComprimidosPorCaixa, PrazoParaAviso;

        public Medicamento(string nome, string tipo, bool econtrolado, int quantidadeDeComprimidosPorCaixa, int prazoParaAviso)
        {
            Nome = nome;
            Tipo = tipo;
            EControlado = econtrolado;
            QuantidadeDeComprimidosPorCaixa = quantidadeDeComprimidosPorCaixa;
            PrazoParaAviso = prazoParaAviso;
        }
    }
    public class Paciente
    {
        public string Nome = "", Email = "", CPFFormatado = "", Senha = "", Genero = "", TelefoneFormatado = "";
        public long CPF, Telefone;
        public int Idade, CartaoSUS;

        public Paciente(string nome, int idade, string genero, long cpf, string cpfformatado, int cartaoSUS, string telefoneFormatado)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
            CPF = cpf;
            CPFFormatado = cpfformatado;
            CartaoSUS = cartaoSUS;
            TelefoneFormatado = telefoneFormatado;
        }
    }
    public class Receita
    {
        public string NomeDoMedico = "", NomeDoRemedio = "", Tipo = "", DataValidadeFormatada = "";
        public bool EControlado;
        public long DataValidade;
        public int QuantidadeDeComprimidosTotais;

        public Receita(string nomedoMedico, string nomedoRemedio, string tipo, bool econtrolado, int quantidadeDeComprimidosTotais, long dataValidade, string dataValidadeFormatada)
        {
            NomeDoMedico = nomedoMedico;
            NomeDoRemedio = nomedoRemedio;
            Tipo = tipo;
            EControlado = econtrolado;
            QuantidadeDeComprimidosTotais = quantidadeDeComprimidosTotais;
            DataValidade = dataValidade;
            DataValidadeFormatada = dataValidadeFormatada;
        }
    }
}