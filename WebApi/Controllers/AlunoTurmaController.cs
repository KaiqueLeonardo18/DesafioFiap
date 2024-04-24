using Application.UseCases.Alunos.GetAllAlunos;
using Application.UseCases.AlunoTurmas.Create;
using Application.UseCases.AlunoTurmas.GetAllAlunoTurma;
using Application.UseCases.AlunoTurmas.Update;
using Application.UseCases.Turmas.Create;
using Application.UseCases.Turmas.GetById;
using Application.UseCases.Turmas.Update;
using Domain.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoTurmaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AlunoTurmaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateAlunoTurmaResponse>> Create(CreateAlunoTurmaRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _mediator.Send(request, cancellationToken);

                return Ok(response);
            }
            catch (AlunoTurmaException ex)
            {
                return StatusCode(500, new { error = new { message = "Erro interno no servidor", code = 500, details = ex.Message } });
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllAlunoTurmaResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllAlunoTurmaRequest(), cancellationToken);

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<UpdateAlunoTurmaResponse>> Update([FromBody] UpdateAlunoTurmaRequest request, CancellationToken cancellationToken)
        {
            await _mediator.Send(new UpdateAlunoTurmaRequest(request.alunoId, request.turmaId, request.alunoIdOld, request.turmaIdOld, request.ativo), cancellationToken);

            return NoContent();
        }
    }
}
