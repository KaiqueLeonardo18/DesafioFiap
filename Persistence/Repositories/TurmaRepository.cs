using Dapper;
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
        private ISqlConnectionFacoty _connectionFactory;

        public TurmaRepository(ISqlConnectionFacoty connectionFacoty) : base(connectionFacoty)
        {
            _connectionFactory = connectionFacoty;
        }

        public async Task<bool> VerificarSeExisteTurmaComMesmoNome(string nome)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                var query = "SELECT COUNT(*) FROM Turma WHERE Nome = @nome";
                var count = await conn.ExecuteScalarAsync<int>(query, new { Nome = nome });

                return count > 0;
            }
        }
    }
}
