using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.GetById
{
    public sealed class GetByIdAlunoHandler : IRequestHandler<GetByIdAlunoRequest, GetByIdAlunoResponse>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public GetByIdAlunoHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdAlunoResponse> Handle(GetByIdAlunoRequest request, CancellationToken cancellationToken)
        {
            var alunos = await _alunoRepository.GetById(request.id);
            return _mapper.Map<GetByIdAlunoResponse>(alunos);
        }
    }
}
