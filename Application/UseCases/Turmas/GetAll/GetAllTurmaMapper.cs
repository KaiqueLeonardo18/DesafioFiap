using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.GetAll
{
    public class GetAllTurmaMapper : Profile
    {
        public GetAllTurmaMapper()
        {
            CreateMap<Turma, GetAllTurmaResponse>();
        }
    }
}
