using Asp.Versioning;
using Banking_Management_System.Data;
using Banking_Management_System.Middleware;
using Banking_Management_System.Repositorys;
using Banking_Management_System.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
})
    .AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'V";
        options.SubstituteApiVersionInUrl = true;
    });
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Demo API",
        Version = "v1"
    });

    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Title = "Demo API",
        Version = "v2"
    });
    options.SwaggerDoc("v3", new OpenApiInfo
    {
        Title = "Demo API",
        Version = "v3"
    });
    options.EnableAnnotations();
});


//builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddScoped<IBankRepository ,BankRepository>();
builder.Services.AddScoped<IBankService,BankService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo V1");
    options.SwaggerEndpoint("/swagger/v2/swagger.json", "Demo V2");
   options.SwaggerEndpoint("/swagger/v3/swagger.json", "Demo V3");
});
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
}

//var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();