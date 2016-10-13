using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NetCoreLog.FileSystem;
using NetCoreLog.DocumentDB;

namespace NetCoreLog.Samples.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<NetCoreLog.Core.ILogger, FileSystemLogger>();
            services.AddSingleton<IFileSystemLogger, FileSystemLogger>();
            services.AddSingleton<IDocumentDBLogger, DocumentDBLogger>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IFileSystemLogger fsLogger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                fsLogger.Path = env.ContentRootPath;
                fsLogger.Log(DateTime.Now, context.Request.Path.Value);
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
