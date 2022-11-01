namespace CheckBox_kontrola
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dorucak = new System.Windows.Forms.CheckBox();
            this.rucak = new System.Windows.Forms.CheckBox();
            this.Vecera = new System.Windows.Forms.CheckBox();
            this.sakrijNarudzbu = new System.Windows.Forms.CheckBox();
            this.posalji = new System.Windows.Forms.Button();
            this.narudzba = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dorucak
            // 
            this.dorucak.AutoSize = true;
            this.dorucak.Location = new System.Drawing.Point(59, 46);
            this.dorucak.Name = "dorucak";
            this.dorucak.Size = new System.Drawing.Size(80, 20);
            this.dorucak.TabIndex = 0;
            this.dorucak.Text = "Doručak";
            this.dorucak.UseVisualStyleBackColor = true;
            this.dorucak.CheckedChanged += new System.EventHandler(this.dorucak_CheckedChanged);
            // 
            // rucak
            // 
            this.rucak.AutoSize = true;
            this.rucak.Location = new System.Drawing.Point(59, 111);
            this.rucak.Name = "rucak";
            this.rucak.Size = new System.Drawing.Size(68, 20);
            this.rucak.TabIndex = 1;
            this.rucak.Text = "Ručak";
            this.rucak.UseVisualStyleBackColor = true;
            this.rucak.CheckedChanged += new System.EventHandler(this.rucak_CheckedChanged);
            // 
            // Vecera
            // 
            this.Vecera.AutoSize = true;
            this.Vecera.Location = new System.Drawing.Point(59, 193);
            this.Vecera.Name = "Vecera";
            this.Vecera.Size = new System.Drawing.Size(73, 20);
            this.Vecera.TabIndex = 2;
            this.Vecera.Text = "Večera";
            this.Vecera.UseVisualStyleBackColor = true;
            this.Vecera.CheckedChanged += new System.EventHandler(this.Vecera_CheckedChanged);
            // 
            // sakrijNarudzbu
            // 
            this.sakrijNarudzbu.AutoSize = true;
            this.sakrijNarudzbu.Location = new System.Drawing.Point(559, 320);
            this.sakrijNarudzbu.Name = "sakrijNarudzbu";
            this.sakrijNarudzbu.Size = new System.Drawing.Size(121, 20);
            this.sakrijNarudzbu.TabIndex = 3;
            this.sakrijNarudzbu.Text = "Sakrij narudžbu";
            this.sakrijNarudzbu.UseVisualStyleBackColor = true;
            this.sakrijNarudzbu.CheckedChanged += new System.EventHandler(this.sakrijNarudzbu_CheckedChanged);
            // 
            // posalji
            // 
            this.posalji.Location = new System.Drawing.Point(59, 316);
            this.posalji.Name = "posalji";
            this.posalji.Size = new System.Drawing.Size(75, 23);
            this.posalji.TabIndex = 4;
            this.posalji.Text = "Pošalji";
            this.posalji.UseVisualStyleBackColor = true;
            this.posalji.Click += new System.EventHandler(this.posalji_Click);
            // 
            // narudzba
            // 
            this.narudzba.Location = new System.Drawing.Point(452, 46);
            this.narudzba.Name = "narudzba";
            this.narudzba.ReadOnly = true;
            this.narudzba.Size = new System.Drawing.Size(337, 229);
            this.narudzba.TabIndex = 5;
            this.narudzba.Text = "";
            this.narudzba.TextChanged += new System.EventHandler(this.narudzba_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(912, 448);
            this.Controls.Add(this.narudzba);
            this.Controls.Add(this.posalji);
            this.Controls.Add(this.sakrijNarudzbu);
            this.Controls.Add(this.Vecera);
            this.Controls.Add(this.rucak);
            this.Controls.Add(this.dorucak);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox dorucak;
        private System.Windows.Forms.CheckBox rucak;
        private System.Windows.Forms.CheckBox Vecera;
        private System.Windows.Forms.CheckBox sakrijNarudzbu;
        private System.Windows.Forms.Button posalji;
        private System.Windows.Forms.RichTextBox narudzba;
    }
    #endregion
}