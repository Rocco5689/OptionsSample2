using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace ServiceOptionsSample
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        public IConfiguration Configuration { get; set; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();

            services.Configure<MyOptions>(Configuration);

            services.AddScoped<ValueService>();
            services.AddScoped<IConfigureOptions<MyOptions>, ConfigureMySettings>();

            //services.Configure<MyOptions>(Configuration.GetSection("MyOptions"));
            //services.AddMyService(options =>
            //{
            //    options.MyValue = "This value was set in ConfigureServices";
            //});

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
