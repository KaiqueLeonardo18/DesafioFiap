using Application.UseCases.Alunos.GetById;
using MediatR;

namespace Application.UseCases.Turmas.GetById
{
    public sealed record GetByIdTurmaRequest(int id) : IRequest<GetByIdTurmaResponse>;
}
