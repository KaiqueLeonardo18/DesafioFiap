using Application.UseCases.Alunos.Create;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmas.Create
{
    public class CreateAlunoTurmaMapper : Profile
    {
        public CreateAlunoTurmaMapper()
        {
            CreateMap<CreateAlunoTurmaRequest, AlunoTurma>();
            CreateMap<AlunoTurma, CreateAlunoTurmaResponse>();
        }
    }
}
