using S627.PFIES.Communication.Requests;
using S627.PFIES.Communication.Responses;

namespace S627.PFIES.Application.UseCases.Alunos.Register;

public class RegisterAlunoUseCase
{
    public ResponseRegisterAluno Execute(RequestRegisterAluno request)
    {
        Validate(request);

        return new ResponseRegisterAluno();
    }

    private void Validate(RequestRegisterAluno request)
    {
        var nomeIsEmpty = string.IsNullOrEmpty(request.NomeAluno);
        if (nomeIsEmpty)
        {
            throw new ArgumentException("O nome do aluno é obrigatório.");
        }

        var emailIsEmpty = string.IsNullOrEmpty(request.EmailAluno);
        if (emailIsEmpty)
        {
            throw new ArgumentException("O email do aluno é obrigatório.");
        }

        var semestreIsEmpty = string.IsNullOrEmpty(request.SemestreAluno);
        if (semestreIsEmpty)
        {
            throw new ArgumentException("O semestre do aluno é obrigatório.");
        }

        if (request.IdAluno <= 0)
        {
            throw new ArgumentException("Sequencial do aluno é inválido.");
        }

        if (request.FaseAluno <= 0)
        {
            throw new ArgumentException("Fase do aluno é inválida.");
        }

    }
}
