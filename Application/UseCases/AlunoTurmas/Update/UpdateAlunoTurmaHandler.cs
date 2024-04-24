using Application.UseCases.Alunos.Update;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmas.Update
{
    public class UpdateAlunoTurmaHandler : IRequestHandler<UpdateAlunoTurmaRequest, UpdateAlunoTurmaResponse>
    {
        private readonly IAlunoTurmaRepository _alunoTurmaRepository;
        private readonly IMapper _mapper;

        public UpdateAlunoTurmaHandler(IAlunoTurmaRepository alunoTurmaRepository, IMapper mapper)
        {
            _alunoTurmaRepository = alunoTurmaRepository;
            _mapper = mapper;
        }

        public async Task<UpdateAlunoTurmaResponse> Handle(UpdateAlunoTurmaRequest command,
                                      CancellationToken cancellationToken)
        {
            await _alunoTurmaRepository.Update(command.alunoId, command.turmaId, command.alunoIdOld, command.turmaIdOld);

            var alunoTurma = await _alunoTurmaRepository.GetById(command.alunoId, command.turmaId);

            return _mapper.Map<UpdateAlunoTurmaResponse>(alunoTurma);
        }
    }
}
