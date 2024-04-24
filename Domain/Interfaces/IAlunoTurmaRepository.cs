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
        Task Update(int newAlunoId, int newTurmaId, int alunoId, int turmaId);
        Task<AlunoTurma> GetById(int alunoId, int turmaId);
    }
}
