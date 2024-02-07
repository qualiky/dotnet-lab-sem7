using ApexRestaurant.Repository;
using ApexRestaurant.Services;


public class Startup
{
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration Configuration)
    {
        this.Configuration = Configuration;
    }

    // This method gets called by the runtime. Use this method to add services to the container.

    public void ConfigureServices(IServiceCollection services)
    {
        //RepositoryModule.Register(services, Configuration.GetConnectionString("DefaultConnection"));
        RepositoryModule.Register(services, Configuration.GetConnectionString("SecondConnection"));
        ServiceModule.Register(services);
        services.AddDbContext<RestaurantContext>();
        services.AddControllers();
        services.AddSwaggerGen();
        services.AddMvc(option => option.EnableEndpointRouting = false);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        else
        {
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapDefaultControllerRoute();
        });

        app.UseStaticFiles();
        app.UseMvc();
        app.UseCors(options => options.AllowAnyOrigin());
    }
}