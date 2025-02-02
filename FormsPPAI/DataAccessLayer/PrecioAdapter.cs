﻿using System.Collections.Generic;

namespace Dashbord.DataAccessLayer {
	public static class PrecioAdapter {
		public static int ReadPrecio(string tipoEntrada, string tipoVisita, string hayGuia) => GeneralAdapter.QueryScalar(
				"SELECT E.monto + V.monto + S.monto + CASE @hayGuia WHEN 'true' THEN monto_adicional_guia ELSE 0 END FROM Tarifa T JOIN TipoEntrada E ON T.id_tipo_entrada = E.id JOIN TipoVisita V ON T.id_tipo_visita = V.id JOIN Sede S ON T.id_sede = S.id WHERE E.nombre = @tipoEntrada AND V.nombre = @tipoVisita AND S.id = 1",
				new Dictionary<string, string>() { { "@tipoEntrada", tipoEntrada }, { "@tipoVisita", tipoVisita }, { "@hayGuia", hayGuia } }
			);
	}
}
