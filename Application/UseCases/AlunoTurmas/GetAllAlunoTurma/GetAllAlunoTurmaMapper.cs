using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmas.GetAllAlunoTurma
{
    public class GetAllAlunoTurmaMapper : Profile
    {
        public GetAllAlunoTurmaMapper()
        {
            CreateMap<AlunoTurmaInfo, GetAllAlunoTurmaResponse>();
        }
    }
}
