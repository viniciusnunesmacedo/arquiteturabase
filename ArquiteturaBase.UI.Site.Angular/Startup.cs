using ArquiteturaBase.Infraestrutura.Transversal.InversaoControle;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Text;

namespace ArquiteturaBase.UI.Site.Angular
{
    public class Startup
    {
        private readonly IHostingEnvironment _ambiente;
        private readonly IConfiguration _configuracao;

        public Startup(IHostingEnvironment ambiente,
                       IConfiguration configuracao)
        {
            _ambiente = ambiente;
            _configuracao = configuracao;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection servicos)
        {
            // In production, the Angular files will be served from this directory
            servicos.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            //servicos.AddAuthentication()
            //        .AddCookie()
            //        .AddJwtBearer(cfg =>
            //        {
            //            cfg.TokenValidationParameters = new TokenValidationParameters()
            //            {
            //                ValidIssuer = _configuracao["Tokens:Issuer"],
            //                ValidAudience = _configuracao["Tokens:Audience"],
            //                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuracao["Tokens:Key"]))
            //            };
            //        });

            //servicos.AddMvc(opt =>
            //{
            //    if (_ambiente.IsProduction() && _configuracao["DisableSSL"] != "true")
            //    {
            //        opt.Filters.Add(new RequireHttpsAttribute());
            //    }
            //}).AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
            //  .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // .NET Native DI Abstraction
            return RegistrarServicos(servicos);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder construtorAplicativo, IHostingEnvironment ambienteHospedagem)
        {
            //if (ambienteHospedagem.IsDevelopment())
            //{
            //    construtorAplicativo.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    construtorAplicativo.UseExceptionHandler("/Error");
            //    construtorAplicativo.UseHsts();
            //}

            //construtorAplicativo.UseHttpsRedirection();
            construtorAplicativo.UseStaticFiles();
            construtorAplicativo.UseSpaStaticFiles();
            //construtorAplicativo.UseAuthentication();

            //construtorAplicativo.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller}/{action=Index}/{id?}");
            //});

            construtorAplicativo.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (ambienteHospedagem.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }

        private static IServiceProvider RegistrarServicos(IServiceCollection servicos)
        {
            // Adding dependencies from another layers (isolated from Presentation)
            return AutoFacInjetor.RegistrarServicos(servicos);
        }
    }
}
