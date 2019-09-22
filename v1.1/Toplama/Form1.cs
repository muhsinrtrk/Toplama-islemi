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

        private int FonkToplama(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2);
        }

        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(txtBirinciSayi.Text);
                Convert.ToInt32(txtIkinciSayi.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
        }
        private void btnToplama_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                int toplamdeger = FonkToplama(Convert.ToInt32(txtBirinciSayi.Text), Convert.ToInt32(txtIkinciSayi.Text));
                MessageBox.Show("Sonuç: " + toplamdeger);

            }
            else
            {
                MessageBox.Show("Girdiğiniz değer sayı değildir!!!!");
            }
            
        }
    }
}
