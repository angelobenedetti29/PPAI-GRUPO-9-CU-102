using System;
using System.Windows.Forms;

namespace Dashbord {
	public partial class OpcionesRV : Form {
		public OpcionesRV() => InitializeComponent();

		private void btnCloseForm_Click(object sender, EventArgs e) => Application.Exit();

		private void btnRegistrarVenta_Click(object sender, EventArgs e) => new TarifasSede().ShowDialog();
	}
}
