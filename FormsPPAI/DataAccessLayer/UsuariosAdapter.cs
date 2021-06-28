using System.Collections.Generic;
using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class UsuariosAdapter {
		public static DataTable ReadUsuario(string username, string password) => GeneralAdapter.Query("SELECT * FROM Usuario WHERE nombre = @username AND contraseña = @password", new Dictionary<string, string>() { { "@username", username }, { "@password", password } });
	}
}
