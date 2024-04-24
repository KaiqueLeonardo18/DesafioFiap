using Domain.Entities;
using Domain.Interfaces;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(ISqlConnectionFacoty connectionFacoty) : base(connectionFacoty)
        {

        }
    }
}
