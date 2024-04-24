using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.Update
{

    public class UpdateTurmaHandler : IRequestHandler<UpdateTurmaRequest, UpdateTurmaResponse>
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly IMapper _mapper;

        public UpdateTurmaHandler(ITurmaRepository TurmaRepository, IMapper mapper)
        {
            _turmaRepository = TurmaRepository;
            _mapper = mapper;
        }

        public async Task<UpdateTurmaResponse> Handle(UpdateTurmaRequest command,
                                             CancellationToken cancellationToken)
        {
            var turma = await _turmaRepository.GetById(command.Id);

            if (turma is null) return default;

            var turmaMap = _mapper.Map(command, turma);

            _turmaRepository.Update(turmaMap);

            return _mapper.Map<UpdateTurmaResponse>(turmaMap);
        }
    }
}
