using Application.UseCases.Alunos.Update;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.Update
{
    public sealed record UpdateTurmaRequest(int Id,
                      string nome, int ano)
                      : IRequest<UpdateTurmaResponse>;
}
