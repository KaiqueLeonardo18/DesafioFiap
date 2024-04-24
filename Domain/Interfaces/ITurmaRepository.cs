using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITurmaRepository : IBaseRepository<Turma>
    {
        Task<bool> VerificarSeExisteTurmaComMesmoNome(string nome);
    }
}
