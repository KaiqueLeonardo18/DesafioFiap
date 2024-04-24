using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.GetAllAlunos
{
    public class GetAllAlunoMapper : Profile
    {
        public GetAllAlunoMapper()
        {
            CreateMap<Aluno, GetAllAlunoResponse>();
        }
    }
}
