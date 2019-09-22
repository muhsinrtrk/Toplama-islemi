using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplama
{
    public partial class frmToplama : Form
    {
        public frmToplama()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int birincideger, ikincideger, toplamdeger;

            birincideger = Convert.ToInt32(txtBirinciSayi.Text);
            ikincideger = Convert.ToInt32(txtIkinciSayi.Text);
            toplamdeger = birincideger + ikincideger;
            MessageBox.Show("Sonuç: " + toplamdeger);
        }
    }
}
