﻿namespace cadParceiros;

public abstract class Endereco 
{
    public int Id { get; set; }
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }   
    public int ParceiroId { get; set; }
    
}
