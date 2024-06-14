using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace TrackItAllApi.Auth {
public class AuthService(IConfiguration configuration) {
	private readonly IConfiguration _configuration = configuration;

	public string GenerateJwtToken(string username) {
		var jwtKey = _configuration["JWT_KEY"] ?? throw new ArgumentNullException("JWT_KEY environment variable is not set");
		var jwtIssuer = _configuration["JWT_ISSUER"];

		var claims = new[] {
			new Claim(JwtRegisteredClaimNames.Sub, username),
			new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
		};

		var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
		var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

		var token = new JwtSecurityToken(
			issuer: jwtIssuer,
			claims: claims,
			expires: DateTime.Now.AddMinutes(30),
			signingCredentials: creds
		);

		return new JwtSecurityTokenHandler().WriteToken(token);
	}
}
}
