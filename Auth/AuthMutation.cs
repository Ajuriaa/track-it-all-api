using HotChocolate;
using HotChocolate.Types;
using Microsoft.Extensions.Configuration;

namespace TrackItAllApi.Auth {
public class AuthMutation(AuthService authService) {
	private readonly AuthService _authService = authService;

	public string Login(string username, string password) {
		if (username == "test" && password == "password") {
			return _authService.GenerateJwtToken(username);
		}

		throw new GraphQLException(new Error("Invalid credentials", "INVALID_CREDENTIALS"));
	}
}
}
