using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.Update
{
    public class UpdateAlunoHandler : IRequestHandler<UpdateAlunoRequest, UpdateAlunoResponse>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public UpdateAlunoHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }

        public async Task<UpdateAlunoResponse> Handle(UpdateAlunoRequest command,
                                             CancellationToken cancellationToken)
        {
            var aluno = await _alunoRepository.GetById(command.Id);

            if (aluno is null) return default;

            aluno.Nome = command.nome;
            aluno.Usuario = command.usuario;
            aluno.senha = command.senha;
            aluno.Ativo = command.ativo;

            _alunoRepository.Update(aluno);

            return _mapper.Map<UpdateAlunoResponse>(aluno);
        }
    }
}
