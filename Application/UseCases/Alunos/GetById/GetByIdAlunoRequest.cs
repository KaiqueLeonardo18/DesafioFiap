using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.GetById
{
    public sealed record GetByIdAlunoRequest(int id) : IRequest<GetByIdAlunoResponse>;
}
