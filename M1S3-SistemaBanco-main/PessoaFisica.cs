using M1S3_SistemaBanco;



namespace M1S3_SistemaBanco_main
{
    public abstract class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade
        {
            get { return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); }
            private set { }

        }

        public override string ResumoCliente()
        {
            
        return $"{NumeroConta}  |  {Nome}  | {CPF}  |  {DataNascimento}  | {Endereco}  |  {Telefone}";
        }

        public bool EhMaior()
        {
            return Idade >= 18;
        }
    }
}