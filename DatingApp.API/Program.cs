using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    builder.Services.AddControllers();
    builder.Services.AddDbContext<DatingAppDbContext>(opts =>
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        opts.UseSqlite(connectionString);
    });
}

var app = builder.Build();

{
    // Configure the HTTP request pipeline.
    app.MapControllers();

    app.Run();
}
