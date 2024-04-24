using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAlunoTurmaRepository : IBaseRepository<AlunoTurma>
    {
        Task<List<AlunoTurmaInfo>> GetAlunoTurma();
        Task Update(int newAlunoId, int newTurmaId, int alunoId, int turmaId, bool ativo);
        Task<AlunoTurma> GetById(int alunoId, int turmaId);
        Task<bool> VerificarSeExisteAlunoTurmaVinculo(int alunoId, int turmaId);
    }
}
