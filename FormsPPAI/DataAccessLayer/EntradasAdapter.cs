using System.Collections.Generic;

namespace Dashbord.DataAccessLayer {
	public static class EntradasAdapter {
		public static int ReadEntradas() => GeneralAdapter.QueryScalar("SELECT cantidad FROM EntradasPorSede WHERE id_sede = 1");

		public static void UpdateEntradas(string cantidad) => GeneralAdapter.Execute("UPDATE EntradasPorSede SET cantidad = cantidad + @cantidad WHERE id_sede = 1", new Dictionary<string, string>() { { "@cantidad", cantidad } });
	}
}
