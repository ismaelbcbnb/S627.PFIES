namespace S627.PFIES.Communication.Requests;

public class RequestRegisterAluno
{
    public long IdAluno {get; set;}
    public string NomeAluno { get; set; } = string.Empty;
    public string EmailAluno {get; set;} = string.Empty;
    public short FaseAluno {get; set;}
    public string SemestreAluno {get; set;} = string.Empty;

    //financiamento: Financiamento = new Financiamento
    //proposta: Proposta = new Proposta
}
