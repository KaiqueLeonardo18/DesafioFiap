using Application.UseCases.Alunos.Create;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmas.Create
{
    public class CreateAlunoTurmaHandler : IRequestHandler<CreateAlunoTurmaRequest, CreateAlunoTurmaResponse>
    {
        private IAlunoTurmaRepository _alunoTurmaRepository;
        private IMapper _mapper;

        public CreateAlunoTurmaHandler(IAlunoTurmaRepository alunoTurmaRepository, IMapper mapper)
        {
            _alunoTurmaRepository = alunoTurmaRepository;
            _mapper = mapper;
        }

        public async Task<CreateAlunoTurmaResponse> Handle(CreateAlunoTurmaRequest request, CancellationToken cancellationToken)
        {
            var alunoTurma = _mapper.Map<AlunoTurma>(request);

            _alunoTurmaRepository.Create(alunoTurma);

            return _mapper.Map<CreateAlunoTurmaResponse>(alunoTurma);
        }
    }
}
