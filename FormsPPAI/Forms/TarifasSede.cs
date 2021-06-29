using Dashbord.DataAccessLayer;
using System;
using System.Windows.Forms;

namespace Dashbord {
	public partial class TarifasSede : Form {
		private string username;

		public TarifasSede(string username) {
			InitializeComponent();

			this.username = username;
		}

		private void btnAceptar_Click(object sender, EventArgs e) => new ElegirTarifa(username).ShowDialog();

		private void TarifasSede_Load(object sender, EventArgs e) {
			lblCargo.Text = UsuarioAdapter.ReadCargo(username).Rows[0][0].ToString();

			dtgTarifaSede.DataSource = TarifaAdapter.ReadTarifasWithMontos();
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();
	}
}
