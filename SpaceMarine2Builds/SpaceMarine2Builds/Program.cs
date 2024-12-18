using SpaceMarine2Builds.DAO;

var builder = WebApplication.CreateBuilder(args);

// Add CORS
builder.Services.AddCors(options =>
{
	options.AddPolicy("blazorApp", policy =>
	{
		policy.WithOrigins("https://localhost:7213")
			  .AllowAnyHeader()
			  .AllowAnyMethod();
	});
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFileStorageAccess, FileStorageAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("blazorApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
