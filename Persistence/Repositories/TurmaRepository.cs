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
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {

        public TurmaRepository(ISqlConnectionFacoty connectionFacoty) : base(connectionFacoty)
        {
            
        }
    }
}
