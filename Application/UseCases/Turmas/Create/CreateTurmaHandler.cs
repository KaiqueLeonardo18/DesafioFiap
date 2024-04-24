using Application.UseCases.Turmas.Create;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.Create
{
    public class CreateTurmaHandler : IRequestHandler<CreateTurmaRequest, CreateTurmaResponse>
    {
        private ITurmaRepository _TurmaRepository;
        private IMapper _mapper;

        public CreateTurmaHandler(ITurmaRepository TurmaRepository, IMapper mapper)
        {
            _TurmaRepository = TurmaRepository;
            _mapper = mapper;
        }

        public async Task<CreateTurmaResponse> Handle(CreateTurmaRequest request, CancellationToken cancellationToken)
        {
            var turma = _mapper.Map<Turma>(request);
            turma.Ativo = true;
            if(await _TurmaRepository.VerificarSeExisteTurmaComMesmoNome(request.nome))
            {
                throw new TurmaException("Já existe uma turma com este nome");
            }

            if(request.ano < DateTime.Now.Year)
            {
                throw new TurmaException("Não é possível inserir uma Turma com Ano inferior ao atual");
            }

            _TurmaRepository.Create(turma);

            return _mapper.Map<CreateTurmaResponse>(turma);
        }
    }
}
