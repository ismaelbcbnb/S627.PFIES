using Microsoft.AspNetCore.Mvc;
using S627.PFIES.Application.UseCases.Alunos.Register;
using S627.PFIES.Communication.Requests;

namespace S627.PFIES.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlunoController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterAluno request)
    {
        try
        {
            var useCase = new RegisterAlunoUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }

        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Erro desconhecido");
        }
    }
}
