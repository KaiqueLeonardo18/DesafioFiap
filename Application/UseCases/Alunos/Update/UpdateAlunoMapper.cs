using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.Update
{
    public class UpdateAlunoMapper : Profile
    {
        public UpdateAlunoMapper()
        {
            CreateMap<UpdateAlunoRequest, Aluno>();
            CreateMap<Aluno, UpdateAlunoResponse>();
        }
    }
}
