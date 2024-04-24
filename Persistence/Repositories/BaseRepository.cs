using Dapper.Contrib.Extensions;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private ISqlConnectionFacoty _connectionFactory;

        public BaseRepository(ISqlConnectionFacoty connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public void Create(T entity)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Insert<T>(entity);
            }
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                return await conn.GetAllAsync<T>();
            }
        }

        public async Task<T> GetById(int id)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                return await conn.GetAsync<T>(id);
            }
        }

        public async void Update(T entity)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                await conn.UpdateAsync<T>(entity);
            }
        }
    }
}
