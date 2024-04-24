using Application.UseCases.Alunos.Update;
using Application.UseCases.Turmas.Update;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.Update
{
    public class UpdateTurmaMapper : Profile
    {
        public UpdateTurmaMapper()
        {
            CreateMap<UpdateTurmaRequest, Turma>();
            CreateMap<Turma, UpdateTurmaResponse>();
        }
    }
}
