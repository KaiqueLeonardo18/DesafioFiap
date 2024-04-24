using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.GetAllAlunos
{
    public sealed record GetAllAlunoRequest : IRequest<List<GetAllAlunoResponse>>;
}
