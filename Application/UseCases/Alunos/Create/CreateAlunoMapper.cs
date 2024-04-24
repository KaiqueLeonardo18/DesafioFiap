using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Alunos.Create
{
    public class CreateAlunoMapper : Profile
    {
        public CreateAlunoMapper()
        {
            CreateMap<CreateAlunoRequest, Aluno>();
            CreateMap<Aluno, CreateAlunoResponse>();
        }
    }
}
