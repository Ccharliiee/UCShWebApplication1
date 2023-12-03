using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UCShWebApplication1.DbConnectHelper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProStoreContext>(opt => { opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); });

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

var scope = app.Services.CreateScope();
var appDbContext = scope.ServiceProvider.GetRequiredService<ProStoreContext>();
try
{
    appDbContext.Database.Migrate();
    InitDbTableWithDummyData.InitDbTable(appDbContext);

}
catch (Exception ex)
{
    var appDbExLogger= scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
    appDbExLogger.LogError(ex, "A problem occurred during DB migration");
}

app.Run();
