using Microsoft.EntityFrameworkCore;
using TrackItAllApi.Data;
using HotChocolate.AspNetCore;
using TrackItAllApi.GraphQL;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// Load environment variables
Env.Load();

// Retrieve the username and password from environment variables
var dbUsername = Env.GetString("DB_USERNAME");
var dbPassword = Env.GetString("DB_PASSWORD");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?.Replace("{DB_USERNAME}", dbUsername)
    .Replace("{DB_PASSWORD}", dbPassword);

// Add DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
		options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention());

// Add GraphQL services
builder.Services
		.AddGraphQLServer()
		.AddQueryType<Query>()
		.AddMutationType<Mutation>()
		.AddProjections()
		.AddFiltering()
		.AddSorting()
		.AddInMemorySubscriptions();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

// TODO Enable this when the certificate is available
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();

public partial class Program { }
