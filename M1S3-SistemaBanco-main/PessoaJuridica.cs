using M1S3_SistemaBanco;

namespace M1S3_SistemaBanco_main
{
    public class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }
        public String RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public List<string> Socios { get; set; } = new List<string>();
        public DateTime DataAbertura { get; set; }

    }
}