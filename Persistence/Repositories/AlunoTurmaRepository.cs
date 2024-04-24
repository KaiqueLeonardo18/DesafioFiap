using Azure;
using Dapper.Contrib.Extensions;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Persistence.Repositories
{
    public class AlunoTurmaRepository : BaseRepository<AlunoTurma>, IAlunoTurmaRepository
    {

        private ISqlConnectionFacoty _connectionFactory;

        public AlunoTurmaRepository(ISqlConnectionFacoty connectionFactory) : base(connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<List<AlunoTurmaInfo>> GetAlunoTurma()
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                var sql = @"
                SELECT a.Nome AS NomeAluno, a.Usuario AS UsuarioAluno, t.Nome AS NomeTurma, t.Ano AS AnoTurma, at.AlunoId, at.TurmaId, at.Ativo AS Ativo
                    FROM Aluno_Turma at
                JOIN Aluno a ON at.AlunoId = a.ID
                JOIN Turma t ON at.TurmaId = t.ID";
                return conn.Query<AlunoTurmaInfo>(sql).AsList();
            }
        }

        public async Task Update(int newAlunoId, int newTurmaId, int alunoId, int turmaId, bool ativo)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = @"UPDATE Aluno_Turma
                      SET AlunoId = @NewAlunoId, TurmaId = @NewTurmaId, Ativo = @Ativo
                      WHERE AlunoId = @AlunoId AND TurmaId = @TurmaId";

               await conn.ExecuteAsync(sql, new { NewAlunoId = newAlunoId, NewTurmaId = newTurmaId, AlunoId = alunoId, TurmaId = turmaId, Ativo = Convert.ToInt32(ativo) });
            }
        }

        public async Task<AlunoTurma> GetById(int alunoId, int turmaId)
        {
            var query = @"SELECT * FROM [Aluno_Turma] WHERE AlunoId = @alunoId AND TurmaId = @turmaId";
            using (var conn = _connectionFactory.CreateConnection())
            {
                return await conn.QueryFirstOrDefaultAsync<AlunoTurma>(query, new { AlunoId = alunoId, TurmaId = turmaId });
            }
        }

        public async Task<bool> VerificarSeExisteAlunoTurmaVinculo(int alunoId, int turmaId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                var query = "SELECT COUNT(*) FROM [Aluno_Turma] WHERE AlunoId = @alunoId AND TurmaId = @turmaId";
                var count = await conn.ExecuteScalarAsync<int>(query, new { AlunoId = alunoId, TurmaId = turmaId });

                return count > 0;
            }
        }
    }
}
