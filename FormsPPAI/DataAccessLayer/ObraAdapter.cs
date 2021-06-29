namespace Dashbord.DataAccessLayer {
	public static class ObraAdapter {
		public static int ReadTiempo() => GeneralAdapter.QueryScalar("SELECT SUM(O.duracion_resumida) FROM Sede S JOIN ExposicionPorSede ExS ON S.id = ExS.id_sede JOIN ObraPorExposicion OxE ON ExS.id_exposicion = OxE.id_exposicion JOIN Obra O ON OxE.id_obra = O.id WHERE S.id = 1");
	}
}
