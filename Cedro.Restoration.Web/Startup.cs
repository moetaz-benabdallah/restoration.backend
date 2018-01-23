using Cedro.Restoration.Repo;
using Cedro.Restoration.Repo.Infrastructure;
using Cedro.Restoration.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cedro.Restoration.Web
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
            services.AddCors();
            services.AddMvc();
            services.AddDbContext<RestaurantContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("RestaurantDatabase"), b => b.MigrationsAssembly("Cedro.Restoration.Web")));

            services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddTransient<IMenuService, MenuService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(
                options => options.WithOrigins("http://localhost:4200").AllowAnyMethod()
            );

            app.UseMvc();
        }
    }
}
