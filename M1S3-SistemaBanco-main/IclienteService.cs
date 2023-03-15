using M1S3_SistemaBanco;


namespace M1S3_SistemaBanco_main
{
  public interface IClienteService
{
    void CriarConta();
    Cliente BuscarCliente();
    void ExibirClientes();
}
}