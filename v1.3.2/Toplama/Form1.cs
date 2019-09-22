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
        private void EkranDuzenle(bool toplambasarili)
        {
            if (toplambasarili == true)
            {
                txtBirinciSayi.Text = txtIkinciSayi.Text = "0";
            }
            txtBirinciSayi.Focus();
        }
        private void btnToplama_Click(object sender, EventArgs e)
        {
            bool dogrulamaSonucu = Dogrula();
            if (dogrulamaSonucu)
            {
                int toplamdeger = FonkToplama(Convert.ToInt32(txtBirinciSayi.Text), Convert.ToInt32(txtIkinciSayi.Text));

                txtSonuc.Text = toplamdeger.ToString();
            }
            else
            {
                MessageBox.Show("Girdiğiniz değer sayı değildir!!!!");
            }
            EkranDuzenle(dogrulamaSonucu);


        }

        private void frmToplama_Shown(object sender, EventArgs e)
        {
            EkranDuzenle(true);
        }

        private void txtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
            
        }

        private void txtIkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
            
        }
    }
}
