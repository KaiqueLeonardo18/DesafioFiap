using Application.UseCases.Alunos.GetAllAlunos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmas.GetAllAlunoTurma
{
    public sealed record GetAllAlunoTurmaRequest : IRequest<List<GetAllAlunoTurmaResponse>>;
}
