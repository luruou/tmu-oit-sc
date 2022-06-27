using TMU_OIT_SC.Web.Middleware;
using TMU_OIT_SC.Web.Extension;


var builder = WebApplication.CreateBuilder(args);

//services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Extension
builder.Services.AddAutoMapper();
builder.Services.AddTransientServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 存取 SPA 網頁資源
app.UseSPAStaticFiles();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseCors("corsapp");

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<ErrorHandlerMiddleware>();

app.Run();
