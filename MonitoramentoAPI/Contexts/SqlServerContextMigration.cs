﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Infra.Contexts
{
    public class SqlServerContextMigration : IDesignTimeDbContextFactory<SqlServerContext>
    {
        public SqlServerContext CreateDbContext(string[] args)
        {
            #region Ler a connectionstring mapeada no appsettings.json 

            var builder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            builder.AddJsonFile(path);

            var root = builder.Build();
            var connectionString = root.GetSection("ConnectionStrings")
                .GetSection("MonitoramentoDB").Value;

            #endregion

            #region Configurando o Migrations 

            var options = new DbContextOptionsBuilder<SqlServerContext>();
            options.UseSqlServer(connectionString);

            return new SqlServerContext(options.Options);

            #endregion
        }
    }
}
