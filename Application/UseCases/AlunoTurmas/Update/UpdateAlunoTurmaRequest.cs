using Application.UseCases.Alunos.Update;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmas.Update
{
    public sealed record UpdateAlunoTurmaRequest(int alunoId,
                  int turmaId, int alunoIdOld, int turmaIdOld)
                  : IRequest<UpdateAlunoTurmaResponse>;
}
