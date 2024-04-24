using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.Create
{
    public sealed record CreateAlunoRequest(string nome, string usuario, string senha, bool ativo) : IRequest<CreateAlunoResponse>;
}
