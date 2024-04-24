using Application.UseCases.Alunos.Create;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.Create
{
    public sealed record CreateTurmaRequest(string nome, int ano, bool ativo) : IRequest<CreateTurmaResponse>;
}
