namespace cadParceiros;

public class Parceiro
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string EmailSolicitacao { get; set; }
    public string Documento { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public Endereco EnderecoCobranca { get; set; }
    public Endereco EnderecoEntrega { get; set; }

}
