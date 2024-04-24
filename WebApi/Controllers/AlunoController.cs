using Application.UseCases.Alunos.Create;
using Application.UseCases.Alunos.GetAllAlunos;
using Application.UseCases.Alunos.GetById;
using Application.UseCases.Alunos.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlunoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateAlunoResponse>> Create(CreateAlunoRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllAlunoResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllAlunoRequest(), cancellationToken);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetByIdAlunoResponse>> Get(int id, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetByIdAlunoRequest(id), cancellationToken);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateAlunoResponse>> Update(int id, [FromBody]UpdateAlunoRequest request, CancellationToken cancellationToken)
        {
            var aluno = await _mediator.Send(new GetByIdAlunoRequest(id), cancellationToken);

            if(aluno == null) return NotFound();

            await _mediator.Send(new UpdateAlunoRequest(id, request.nome, request.usuario, request.senha), cancellationToken);

            return NoContent();
        }
    }
}
