﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace CurrencyConverterService
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("Cors", p =>
                    p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            });

            services.AddMvc().AddJsonOptions(options => options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver()); ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(config => config.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());

            app.UseMvc(routes =>
            {
                routes.MapRoute("currencyconverterservice", "api/{controller}/{action}/{id?}", new { controller = "CurrencyToWordConverter", action = "Convert" });
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync(DefaultShow());
            });
        }

        private string DefaultShow()
        {
            string html = "<html><head>";
            html += "<style>.loader{border: 16px solid #f3f3f3;border-radius: 50%;border-top: 16px solid blue;";
            html += "border-bottom: 16px solid blue;width: 120px;height: 120px;-webkit-animation: spin 2s linear infinite;";
            html += "animation: spin 2s linear infinite;}";
            html += "@-webkit-keyframes spin{0% { -webkit-transform: rotate(0deg); }100% { -webkit-transform: rotate(360deg); }}";
            html += "@keyframes spin {0% { transform: rotate(0deg); }100% { transform: rotate(360deg); }}";
            html += "</style></head>";
            html += "<body><div style='margin-top:10%'>";
            html += "<div class='loader' style ='margin-left:46%;'></div>";
            html += "<br/>";
            html += "<div style ='text-align: center;'><h1>Currency to word converter service is running</h1>";
            html += "</div></div></body></html>";
            return html;
        }
    }
}
