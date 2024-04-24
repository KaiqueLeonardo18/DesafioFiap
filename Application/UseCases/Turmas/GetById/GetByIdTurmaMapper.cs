using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.GetById
{
    public class GetByIdTurmaMapper : Profile
    {
        public GetByIdTurmaMapper()
        {
            CreateMap<Turma, GetByIdTurmaResponse>();
        }
    }
}
