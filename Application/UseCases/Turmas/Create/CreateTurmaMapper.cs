using Application.UseCases.Alunos.Create;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.Create
{
    public class CreateTurmaMapper : Profile
    {
        public CreateTurmaMapper()
        {
            CreateMap<CreateTurmaRequest, Turma>();
            CreateMap<Turma, CreateTurmaResponse>();
        }
    }
}
