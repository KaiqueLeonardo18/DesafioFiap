using Application.UseCases.Alunos.GetAllAlunos;
using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.GetAll
{
    public sealed class GetAllTurmaHandler : IRequestHandler<GetAllTurmaRequest, List<GetAllTurmaResponse>>
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly IMapper _mapper;

        public GetAllTurmaHandler(ITurmaRepository turmaRepository, IMapper mapper)
        {
            _turmaRepository = turmaRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllTurmaResponse>> Handle(GetAllTurmaRequest request, CancellationToken cancellationToken)
        {
            var alunos = await _turmaRepository.GetAll();
            return _mapper.Map<List<GetAllTurmaResponse>>(alunos);
        }
    }
}
