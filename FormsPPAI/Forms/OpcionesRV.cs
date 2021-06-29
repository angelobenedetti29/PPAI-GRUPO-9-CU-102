using Dashbord.DataAccessLayer;
using System;
using System.Windows.Forms;

namespace Dashbord {
	public partial class OpcionesRV : Form {
		private string username;

		public OpcionesRV(string username) {
			InitializeComponent();

			this.username = username;
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Application.Exit();

		private void btnRegistrarVenta_Click(object sender, EventArgs e) => new TarifasSede(username).ShowDialog();

		private void OpcionesRV_Load(object sender, EventArgs e) => lblCargo.Text = UsuarioAdapter.ReadCargo(username).Rows[0][0].ToString();
	}
}
