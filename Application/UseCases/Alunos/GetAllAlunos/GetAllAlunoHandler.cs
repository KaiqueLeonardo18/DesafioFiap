using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.GetAllAlunos
{
    public sealed class GetAllAlunoHandler : IRequestHandler<GetAllAlunoRequest, List<GetAllAlunoResponse>>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public GetAllAlunoHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllAlunoResponse>> Handle(GetAllAlunoRequest request, CancellationToken cancellationToken)
        {
            var alunos = await _alunoRepository.GetAll();
            return _mapper.Map<List<GetAllAlunoResponse>>(alunos);
        }
    }
}
