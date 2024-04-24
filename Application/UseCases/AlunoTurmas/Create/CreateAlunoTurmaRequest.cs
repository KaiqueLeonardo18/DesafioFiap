using Application.UseCases.Alunos.Create;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmas.Create
{
    public sealed record CreateAlunoTurmaRequest(int alunoId, int turmaId, bool ativo) : IRequest<CreateAlunoTurmaResponse>;

}
