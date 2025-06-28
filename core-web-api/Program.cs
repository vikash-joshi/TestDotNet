using core_web_api.middlewares;
using core_web_api.single_scope_transient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<Guid>(provider => Guid.NewGuid());   
builder.Services.AddScoped<IScoped,OperationService>();
builder.Services.AddTransient<ITransient,OperationService>();
builder.Services.AddSingleton<ISingleton,OperationService>();
builder.Services.AddControllers(options =>
    {
        options.RespectBrowserAcceptHeader = true;
        options.ReturnHttpNotAcceptable=true;
    });

//cors
builder.Services.AddCors(optiosn=>
{
    optiosn.AddPolicy("AllowAccess",policy=>{
        policy.WithOrigins("/").AllowAnyHeader().AllowAnyMethod();

    });
}); 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseMiddleware<FirstMiddlewareClass>();
//app.UseMiddleware<SecondMiddlewareClass>();

app.UseRouting();
////app.UseHttpsRedirection();
///a
//app.UseExceptionHandler("/error");
//app.MapGet("/",() =>  "first api");
app.MapControllers();

app.Run();
