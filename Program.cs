using Microsoft.EntityFrameworkCore;
using TrackItAllApi.Data;
using HotChocolate.AspNetCore;
using TrackItAllApi.GraphQL;
using DotNetEnv;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using TrackItAllApi.Auth;

var builder = WebApplication.CreateBuilder(args);

// Load environment variables
Env.Load();

// Retrieve the username and password from environment variables
var dbUsername = Env.GetString("DB_USERNAME");
var dbPassword = Env.GetString("DB_PASSWORD");
var jwtKey = Env.GetString("JWT_KEY");
var jwtIssuer = Env.GetString("JWT_ISSUER");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
		?.Replace("{DB_USERNAME}", dbUsername)
		.Replace("{DB_PASSWORD}", dbPassword);

builder.Services.AddAuthentication(options => {
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options => {
	options.TokenValidationParameters = new TokenValidationParameters {
		ValidateIssuer = true,
		ValidateAudience = false,
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,
		ValidIssuer = jwtIssuer,
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
	};
});

// Add DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
		options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention());

builder.Services.AddSingleton<AuthService>();

// Add GraphQL services
builder.Services
		.AddGraphQLServer()
		.AddAuthorization()
		.AddType<AuthMutation>()
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();

public partial class Program { }
