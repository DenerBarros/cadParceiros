namespace cadParceiros;

public class Parceiro
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string EmailSolicitacao { get; set; }
    public string Documento { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public TipoParceiro TipoParceiro { get; set; }
    public TipoPessoa TipoPessoa { get; set; }

    public Status Status { get; set; }
   
    public EnderecoCobranca EnderecoCobranca { get; set; }
    public EnderecoEntrega EnderecoEntrega { get; set; }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

public enum Status
{
    Cadastrado,
    Solicitado,
    Cancelado
}
public enum TipoPessoa
{
    Física,
    Jurídica
}

public enum TipoParceiro
{
    Cliente,
    Fornecedor
}