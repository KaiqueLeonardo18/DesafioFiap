using Application.UseCases.Turmas.Create;
using Application.UseCases.Turmas.GetById;
using Application.UseCases.Turmas.Update;
using Application.UseCases.Turmas.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurmaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TurmaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateTurmaResponse>> Create(CreateTurmaRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllTurmaResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllTurmaRequest(), cancellationToken);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetByIdTurmaResponse>> Get(int id, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetByIdTurmaRequest(id), cancellationToken);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateTurmaResponse>> Update(int id, [FromBody] UpdateTurmaRequest request, CancellationToken cancellationToken)
        {
            var Turma = await _mediator.Send(new GetByIdTurmaRequest(id), cancellationToken);

            if (Turma == null) return NotFound();

            await _mediator.Send(new UpdateTurmaRequest(id, request.nome, request.ano), cancellationToken);

            return NoContent();
        }
    }
}
