using Refit;
using Olegacy.FutebolAPI.Clients;
using Olegacy.FutebolAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();

builder.Services.AddRefitClient<IApiFutebolClient>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri("https://api.campeonato-brasileiro.com.br");
    });

builder.Services.AddScoped<IBrasileiraoService, BrasileiraoService>();

var app = builder.Build();

// Swagger sempre ativo (qualquer ambiente)
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();