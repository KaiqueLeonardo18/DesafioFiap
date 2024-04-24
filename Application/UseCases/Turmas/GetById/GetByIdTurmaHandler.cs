using Application.UseCases.Alunos.GetById;
using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.GetById
{
    public sealed class GetByIdTurmaHandler : IRequestHandler<GetByIdTurmaRequest, GetByIdTurmaResponse>
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly IMapper _mapper;

        public GetByIdTurmaHandler(ITurmaRepository turmaRepository, IMapper mapper)
        {
            _turmaRepository = turmaRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdTurmaResponse> Handle(GetByIdTurmaRequest request, CancellationToken cancellationToken)
        {
            var alunos = await _turmaRepository.GetById(request.id);
            return _mapper.Map<GetByIdTurmaResponse>(alunos);
        }
    }
}
