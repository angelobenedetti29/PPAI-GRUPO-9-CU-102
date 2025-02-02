﻿using Dashbord.DataAccessLayer;
using Dashbord.Forms;
using System.Windows.Forms;

namespace Dashbord {
	public partial class DetalleEntradas : Form {
		private string username;
		private string tipo_entrada;
		private string tipoVisita;
		private bool hayGuia;
		private int cantidad;

		public DetalleEntradas(string username, string tipoEntrada, string tipoVisita, bool hayGuia, int cantidad) {
			InitializeComponent();

			this.username = username;
			tipo_entrada = tipoEntrada;
			this.tipoVisita = tipoVisita;
			this.hayGuia = hayGuia;
			this.cantidad = cantidad;
		}

		private void btnCloseForm_Click(object sender, System.EventArgs e) => Close();

		private void btnAceptar_Click(object sender, System.EventArgs e) {
			EntradaAdapter.UpdateEntradas(cantidad.ToString());

			MessageBox.Show("Exito.");
			new Ticket().ShowDialog();
		}

		private void DetalleEntradas_Load(object sender, System.EventArgs e) {
			lblCargo.Text = UsuarioAdapter.ReadCargo(username).Rows[0][0].ToString();

			dtgDetalleEntradas.Rows.Add(cantidad, tipo_entrada, tipoVisita, hayGuia, PrecioAdapter.ReadPrecio(tipo_entrada, tipoVisita, hayGuia ? "true" : "false"));

			lblTotal.Text = $"Total ${cantidad * PrecioAdapter.ReadPrecio(tipo_entrada, tipoVisita, hayGuia ? "true" : "false")}";
		}
	}
}
