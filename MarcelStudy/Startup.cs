using MarcelStudy.Application;
using MarcelStudy.Repository;
using MarcelStudy.Repository.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MarcelStudy
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();           
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Agenda", Version = "v1" });
                
            });

            // Configura o banco de dados
            var studyConnection = "Data Source=SA-BR-SQLTEST;Initial Catalog=Study;Persist Security Info=True; User ID=UserT_Study;Password=ALB2021*"; //Configuration.GetConnectionString("DeltaConnection");
            services.AddDbContext<StudyContext>(option => option.UseSqlServer(studyConnection));

            services.AddScoped<ContatoApplication>();
            services.AddScoped<ContatoRepository>();
            services.AddScoped<EnderecoApplication>();
            services.AddScoped<EnderecoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
                // Configura o Swagger
                app.UseSwagger();
                app.UseSwaggerUI(sw =>
                {
                    sw.SwaggerEndpoint($"/swagger/v1/swagger.json", $"Agenda");
                    
                });
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
