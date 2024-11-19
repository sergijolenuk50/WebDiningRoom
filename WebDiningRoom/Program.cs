
using Core;
using Data;
using Data.Data;
using Microsoft.EntityFrameworkCore;

namespace WebDiningRoom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DiningRoomDbContextConnection") ?? throw new InvalidOperationException("Connection string 'DiningRoomDbContextConnection' not found.");

            builder.Services.AddDbContext<DiningRoomDbContext>(options => options.UseSqlServer(connectionString));



            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddRepository();


            builder.Services.AddCustomServices();
            builder.Services.AddAutoMapper();
            builder.Services.AddFluentValidators();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
