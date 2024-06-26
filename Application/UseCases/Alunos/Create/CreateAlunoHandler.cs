﻿using Application.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
namespace Application.UseCases.Alunos.Create
{
    public class CreateAlunoHandler : IRequestHandler<CreateAlunoRequest, CreateAlunoResponse>
    {
        private IAlunoRepository _alunoRepository;
        private IMapper _mapper;

        public CreateAlunoHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }

        public async Task<CreateAlunoResponse> Handle(CreateAlunoRequest request, CancellationToken cancellationToken)
        {
            var aluno = _mapper.Map<Aluno>(request);

            aluno.Ativo = true;
            aluno.senha = Hash.MontarHash(request.senha);

            _alunoRepository.Create(aluno);

            return _mapper.Map<CreateAlunoResponse>(aluno);
        }
    }
}
