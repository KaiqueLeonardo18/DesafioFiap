using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection service, IConfiguration configuration)
        {

            service.AddScoped<IAlunoRepository, AlunoRepository>();
            service.AddScoped<ITurmaRepository, TurmaRepository>();
            service.AddScoped<IAlunoTurmaRepository, AlunoTurmaRepository>();
        }
    }
}
