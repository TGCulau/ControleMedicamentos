namespace ControleMedicamentos

{
    public class Repositorio
    {
        public Posto postinho { get; set; }
        public Funcionario funcionario { get; set; }
        public Fornecedor fornecedor { get; set; }
        public Medicamento medicamento { get; set; }

        public bool LeituraPostinho()
        {
            string PostinhoBD = "PostinhoBD.txt";
            //1 = sim / 0 = não
            //Verifica se o arquivo existe
            if (!File.Exists(PostinhoBD))
            {
                // Cria o arquivo e fecha-o imediatamente
                File.Create(PostinhoBD).Close();
            }

            //Lê as linhas do arquivo PostinhoBD.txt
            string[] linhadotxt = File.ReadAllLines(PostinhoBD);

            bool ExisteInformacaoNoArquivo = true;
            if (linhadotxt == null)
            {
                ExisteInformacaoNoArquivo = false;
            }

            string bairro = "", telefoneFormatado = "";
            int numerodaunidade = 0;

            foreach (string linhalida in linhadotxt)
            {
                // Divide a linha em partes usando a vírgula como separador
                string[] coluna = linhalida.Split(',');

                bairro = coluna[0];
                telefoneFormatado = coluna[1];
                numerodaunidade = int.Parse(coluna[2]);
            }
            postinho = new Posto(bairro, telefoneFormatado, numerodaunidade);
            return ExisteInformacaoNoArquivo;
        }
        public void SalvarPostinho()
        {
            string PostinhoBD = "PostinhoBD.txt";
            // Prepara a linha para ser escrita no arquivo
            string linha = $"{postinho.Bairro},{postinho.TelefoneFormatado},{postinho.NumeroDaUnidade}";
            // Escreve a linha no arquivo
            File.AppendAllText(PostinhoBD, linha + Environment.NewLine);
        }
        public bool LeituraFuncionario()
        {
            string FuncionarioBD = "FuncionarioBD.txt";
            //Verifica se o arquivo existe
            if (!File.Exists(FuncionarioBD))
            {
                // Cria o arquivo e fecha-o imediatamente
                File.Create(FuncionarioBD).Close();
            }

            //Lê as linhas do arquivo FuncionarioBD.txt
            string[] linhadotxt = File.ReadAllLines(FuncionarioBD);

            bool ExisteInformacaoNoArquivo = true;
            if (linhadotxt == null)
            {
                ExisteInformacaoNoArquivo = false;
            }

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
            }
            funcionario = new Funcionario(nome, idade, genero, cpfformatado, cargo, matricula, email, senha);
            return ExisteInformacaoNoArquivo;
        }
        public void SalvarFuncionario()
        {
            string FuncionarioBD = "FuncionarioBD.txt";
            // Prepara a linha para ser escrita no arquivo
            string linha = $"{funcionario.Nome},{funcionario.Idade},{funcionario.CPFFormatado},{funcionario.Cargo},{funcionario.Matricula},{funcionario.Email},{funcionario.Senha}";
            // Escreve a linha no arquivo
            File.AppendAllText(FuncionarioBD, linha + Environment.NewLine);
        }
        public bool LeituraForncedor()
        {
            string FornecedorBD = "FornecedorBD.txt";
            //Verifica se o arquivo existe
            if (!File.Exists(FornecedorBD))
            {
                // Cria o arquivo e fecha-o imediatamente
                File.Create(FornecedorBD).Close();
            }

            //Lê as linhas do arquivo FornecedorBD.txt
            string[] linhadotxt = File.ReadAllLines(FornecedorBD);

            bool ExisteInformacaoNoArquivo = true;
            if (linhadotxt == null)
            {
                ExisteInformacaoNoArquivo = false;
            }

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
            }
            fornecedor = new Fornecedor(nome, cnpjformatado, email, prazo);
            return ExisteInformacaoNoArquivo;
        }
        public void SalvarForncedor()
        {
            string FornecedorBD = "FornecedorBD.txt";
            // Prepara a linha para ser escrita no arquivo
            string linha = $"{fornecedor.Nome},{fornecedor.CNPJFormatado},{fornecedor.Email},{fornecedor.Prazo}";
            // Escreve a linha no arquivo
            File.AppendAllText(FornecedorBD, linha + Environment.NewLine);
        }
        public bool LeituraMedicamento()
        {
            string MedicamentoBD = "MedicamentoBD.txt";
            //Verifica se o arquivo existe
            if (!File.Exists(MedicamentoBD))
            {
                // Cria o arquivo e fecha-o imediatamente
                File.Create(MedicamentoBD).Close();
            }

            //Lê as linhas do arquivo MedicamentoBD.txt
            string[] linhadotxt = File.ReadAllLines(MedicamentoBD);

            bool ExisteInformacaoNoArquivo = true;
            if (linhadotxt == null)
            {
                ExisteInformacaoNoArquivo = false;
            }

            foreach (string linhalida in linhadotxt)
            {
                // Divide a linha em partes usando a vírgula como separador
                string[] coluna = linhalida.Split(',');

                string nome = coluna[0];
                string tipo = coluna[1];
                bool eControlado = true;
                int econtrolado = int.Parse(coluna[2]);
                int quantidadeDeComprimidosPorCaixa = int.Parse(coluna[3]);
                int prazoParaAviso = int.Parse(coluna[4]);
                int existeInformacaoNoArquivo = int.Parse(coluna[5]);
                if (econtrolado == 0)
                {
                    eControlado = false;
                }

                medicamento = new Medicamento(nome, tipo, eControlado, quantidadeDeComprimidosPorCaixa, prazoParaAviso, existeInformacaoNoArquivo);
            }

            return ExisteInformacaoNoArquivo;
        }
        public void SalvarMedicamento()
        {
            string MedicamentoBD = "MedicamentoBD.txt";
            // Prepara a linha para ser escrita no arquivo

            string linha = $"{medicamento.Nome}, {medicamento.Tipo}, {medicamento.EControlado}, {medicamento.QuantidadeDeComprimidosPorCaixa}, {medicamento.PrazoParaAviso}, {medicamento.ExisteInformacaoNoArquivo}";
            // Escreve a linha no arquivo
            File.AppendAllText(MedicamentoBD, linha + Environment.NewLine);
        }

        //public bool LeituraMedicamento()
        //public List<Medicamento> LeituraMedicamento()
        //{
        //    string MedicamentoBD = "MedicamentoBD.txt";
        //    //Verifica se o arquivo existe
        //    if (!File.Exists(MedicamentoBD))
        //    {
        //        // Cria o arquivo e fecha-o imediatamente
        //        File.Create(MedicamentoBD).Close();
        //    }

        //    //Lê as linhas do arquivo MedicamentoBD.txt
        //    string[] linhadotxt = File.ReadAllLines(MedicamentoBD);

        //    int existeInformacaoNoArquivo = 1;
        //    if (linhadotxt == null)
        //    {
        //        existeInformacaoNoArquivo = 0;
        //    }


        //    bool eControlado = true;
        //    int cont = 0;
        //    foreach (string linhalida in linhadotxt)
        //    {
        //        // Divide a linha em partes usando a vírgula como separador
        //        string[] coluna = linhalida.Split(',');

        //        string nome = coluna[0];
        //        string tipo = coluna[1];
        //        int econtrolado = int.Parse(coluna[2]);
        //        if (econtrolado == 1)
        //        {
        //            eControlado = true;
        //        }
        //        int quantidadeDeComprimidosPorCaixa = int.Parse(coluna[3]);
        //        int prazoParaAviso = int.Parse(coluna[4]);

        //        Medicamento medicamento = new Medicamento(nome, tipo, eControlado, quantidadeDeComprimidosPorCaixa, prazoParaAviso, existeInformacaoNoArquivo);
        //        medicamentos.Add(medicamento);
        //    }
        //    return medicamentos;
        //}
        //public void SalvarMedicamento(Medicamento medicamento)
        //{
        //    string MedicamentoBD = "MedicamentoBD.txt";
        //    // Prepara a linha para ser escrita no arquivo
        //    string linha = $"{medicamento.Nome},{medicamento.Tipo},{medicamento.EControlado},{medicamento.QuantidadeDeComprimidosPorCaixa},{medicamento.PrazoParaAviso},";
        //    // Escreve a linha no arquivo
        //    File.AppendAllText(MedicamentoBD, linha + Environment.NewLine);
        //}
        //public void SalvarTodosMedicamentos()
        //{
        //    foreach (var medicamento in medicamentos)
        //    {
        //        SalvarMedicamento(medicamento);
        //    }
        //}
        //public void SalvarMedicamento()
        //{
        //    string MedicamentoBD = "MedicamentoBD.txt";
        //    // Prepara a linha para ser escrita no arquivo
        //    string linha = $"{medicamento.Nome},{medicamento.Tipo},{medicamento.EControlado},{medicamento.QuantidadeDeComprimidosPorCaixa},{medicamento.PrazoParaAviso}\n";
        //    // Escreve a linha no arquivo
        //    File.AppendAllText(MedicamentoBD, linha + Environment.NewLine);
        //}

    }
    public class Posto
    {
        public string Bairro = "", TelefoneFormatado = "";
        public int NumeroDaUnidade;

        public Posto(string bairro, string telefoneFormatado, int numerodaunidade)
        {
            Bairro = bairro;
            NumeroDaUnidade = numerodaunidade;
            TelefoneFormatado = telefoneFormatado;
        }
    }
    public class Funcionario
    {
        public string Nome = "", Email = "", CPFFormatado = "", Cargo = "", Senha = "", Genero = "";
        public int Idade, Matricula;

        public Funcionario(string nome, int idade, string genero, string cpfformatado, string cargo, int matricula, string email, string senha)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
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
        public int Prazo;

        public Fornecedor(string nome, string cnpjformatado, string email, int prazo)
        {
            Nome = nome;
            CNPJFormatado = cnpjformatado;
            Email = email;
            Prazo = prazo;
        }
    }
    public class Medicamento
    {
        public string Nome = "", Tipo = "";
        public bool EControlado;
        public int QuantidadeDeComprimidosPorCaixa, PrazoParaAviso, ExisteInformacaoNoArquivo;

        public Medicamento(string nome, string tipo, bool eControlado, int quantidadeDeComprimidosPorCaixa, int prazoParaAviso, int existeInformacaoNoArquivo)
        {
            Nome = nome;
            Tipo = tipo;
            EControlado = eControlado;
            QuantidadeDeComprimidosPorCaixa = quantidadeDeComprimidosPorCaixa;
            PrazoParaAviso = prazoParaAviso;
            ExisteInformacaoNoArquivo = existeInformacaoNoArquivo;
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