using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using TodoApi.Models.Abstract;
using TodoApi.Models;

namespace TodoApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //Ułatwienia dla dodawania Dependency Injection. 
            services.AddSingleton<ITodoRepository, TodoRepository>();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseWelcomePage();
          
        }
    }
}
