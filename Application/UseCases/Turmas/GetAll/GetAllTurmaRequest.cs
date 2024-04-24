
using MediatR;

namespace Application.UseCases.Turmas.GetAll
{
    public sealed record GetAllTurmaRequest : IRequest<List<GetAllTurmaResponse>>;

}
