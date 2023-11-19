using celilcavus.funi.Interfaces;
using celilcavus.funi.Repository;
using Funi.Databases;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // IConfiguration configuration = new ConfigurationBuilder()
        // .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        // .AddJsonFile("appsettings.json")
        // .Build();
        // // Add services to the container.
        // builder.Services.AddDbContext<FuniContext>(x =>
        // {
        //     x.UseSqlite(configuration.GetConnectionString("ConnectionSqlite"));
        // });

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // scoped
        builder.Services.AddScoped<IShop,ShopRepository>();
        //

        var app = builder.Build();

        // // Configure the HTTP request pipeline.
        // if (app.Environment.IsDevelopment())
        // {
        //     app.UseSwagger();
        //     app.UseSwaggerUI();
        // }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        

        app.MapControllers();

        app.Run();
    }
}