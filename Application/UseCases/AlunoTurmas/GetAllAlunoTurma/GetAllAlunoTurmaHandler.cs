using Application.UseCases.AlunoTurmas.GetAllAlunoTurma;
using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmaTurmas.GetAllAlunoTurmaTurma
{
    public class GetAllAlunoTurmaHandler : IRequestHandler<GetAllAlunoTurmaRequest, List<GetAllAlunoTurmaResponse>>
    {
        private readonly IAlunoTurmaRepository _alunoTurmaRepository;
        private readonly IMapper _mapper;

        public GetAllAlunoTurmaHandler(IAlunoTurmaRepository AlunoTurmaRepository, IMapper mapper)
        {
            _alunoTurmaRepository = AlunoTurmaRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllAlunoTurmaResponse>> Handle(GetAllAlunoTurmaRequest request, CancellationToken cancellationToken)
        {
            var AlunoTurmas = await _alunoTurmaRepository.GetAlunoTurma();
            return _mapper.Map<List<GetAllAlunoTurmaResponse>>(AlunoTurmas);
        }
    }
}
