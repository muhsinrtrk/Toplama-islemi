namespace Toplama
{
    partial class frmToplama
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpToplama = new System.Windows.Forms.TabPage();
            this.lblIkinciSayi = new System.Windows.Forms.Label();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.txtIkinciSayi = new System.Windows.Forms.TextBox();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.tbpLog = new System.Windows.Forms.TabPage();
            this.lstvLog = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tbpToplama.SuspendLayout();
            this.tbpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpToplama);
            this.tabControl1.Controls.Add(this.tbpLog);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 302);
            this.tabControl1.TabIndex = 5;
            // 
            // tbpToplama
            // 
            this.tbpToplama.Controls.Add(this.lblSonuc);
            this.tbpToplama.Controls.Add(this.txtSonuc);
            this.tbpToplama.Controls.Add(this.lblIkinciSayi);
            this.tbpToplama.Controls.Add(this.lblBirinciSayi);
            this.tbpToplama.Controls.Add(this.txtIkinciSayi);
            this.tbpToplama.Controls.Add(this.txtBirinciSayi);
            this.tbpToplama.Controls.Add(this.btnToplama);
            this.tbpToplama.Location = new System.Drawing.Point(4, 22);
            this.tbpToplama.Name = "tbpToplama";
            this.tbpToplama.Padding = new System.Windows.Forms.Padding(3);
            this.tbpToplama.Size = new System.Drawing.Size(354, 276);
            this.tbpToplama.TabIndex = 0;
            this.tbpToplama.Text = "Toplama";
            this.tbpToplama.UseVisualStyleBackColor = true;
            // 
            // lblIkinciSayi
            // 
            this.lblIkinciSayi.AutoSize = true;
            this.lblIkinciSayi.Location = new System.Drawing.Point(78, 107);
            this.lblIkinciSayi.Name = "lblIkinciSayi";
            this.lblIkinciSayi.Size = new System.Drawing.Size(55, 13);
            this.lblIkinciSayi.TabIndex = 9;
            this.lblIkinciSayi.Text = "İkinci Sayı";
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(75, 78);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(58, 13);
            this.lblBirinciSayi.TabIndex = 8;
            this.lblBirinciSayi.Text = "Birinci Sayı";
            // 
            // txtIkinciSayi
            // 
            this.txtIkinciSayi.Location = new System.Drawing.Point(142, 100);
            this.txtIkinciSayi.Name = "txtIkinciSayi";
            this.txtIkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtIkinciSayi.TabIndex = 7;
            this.txtIkinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIkinciSayi_KeyPress);
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(142, 71);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtBirinciSayi.TabIndex = 6;
            this.txtBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirinciSayi_KeyPress);
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(151, 126);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(75, 23);
            this.btnToplama.TabIndex = 5;
            this.btnToplama.Text = "Topla";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(142, 187);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 10;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(78, 194);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 11;
            this.lblSonuc.Text = "Sonuç";
            // 
            // tbpLog
            // 
            this.tbpLog.Controls.Add(this.lstvLog);
            this.tbpLog.Location = new System.Drawing.Point(4, 22);
            this.tbpLog.Name = "tbpLog";
            this.tbpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLog.Size = new System.Drawing.Size(354, 276);
            this.tbpLog.TabIndex = 1;
            this.tbpLog.Text = "Log";
            this.tbpLog.UseVisualStyleBackColor = true;
            // 
            // lstvLog
            // 
            this.lstvLog.Location = new System.Drawing.Point(3, 6);
            this.lstvLog.Name = "lstvLog";
            this.lstvLog.Size = new System.Drawing.Size(345, 267);
            this.lstvLog.TabIndex = 0;
            this.lstvLog.UseCompatibleStateImageBehavior = false;
            this.lstvLog.View = System.Windows.Forms.View.List;
            // 
            // frmToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 326);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmToplama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama İşlemi";
            this.Shown += new System.EventHandler(this.frmToplama_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tbpToplama.ResumeLayout(false);
            this.tbpToplama.PerformLayout();
            this.tbpLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpToplama;
        private System.Windows.Forms.Label lblIkinciSayi;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.TextBox txtIkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TabPage tbpLog;
        private System.Windows.Forms.ListView lstvLog;
    }
}

