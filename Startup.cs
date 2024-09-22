using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_session1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); //mvc
                                                //  services.AddRazorPages(); //razor page
                                                //services.AddControllers();//WEb Api
                                                // services.AddMvc();//mix[3project]
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();//get static fills resources
            app.UseRouting();

            
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(

                    name: "default",
                    pattern: "{Controller=Home}/{action=Index}/{id:int?}");
                    //id is option
                    //defaults :new {action="Index"},
                    ////?? ????? action 
                    //constraints: new {id=new IntRouteConstraint()}
                });


            }
            
    }
}
