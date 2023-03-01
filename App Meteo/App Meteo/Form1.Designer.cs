namespace App_Meteo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Invia = new System.Windows.Forms.Button();
            this.lbl_TempAttuale = new System.Windows.Forms.Label();
            this.lbl_minmax = new System.Windows.Forms.Label();
            this.Panel_Info = new System.Windows.Forms.Panel();
            this.lbl_Umidita = new System.Windows.Forms.Label();
            this.lbl_Percepita = new System.Windows.Forms.Label();
            this.lbl_Pressione = new System.Windows.Forms.Label();
            this.lbl_precipitazioni = new System.Windows.Forms.Label();
            this.lbl_Alba = new System.Windows.Forms.Label();
            this.lbl_tramonto = new System.Windows.Forms.Label();
            this.lbl_ProPrecipita = new System.Windows.Forms.Label();
            this.lbl_Ivento = new System.Windows.Forms.Label();
            this.lbl_DirVento = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_Info.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Invia
            // 
            this.btn_Invia.Location = new System.Drawing.Point(38, 23);
            this.btn_Invia.Name = "btn_Invia";
            this.btn_Invia.Size = new System.Drawing.Size(75, 23);
            this.btn_Invia.TabIndex = 0;
            this.btn_Invia.Text = "Cerca";
            this.btn_Invia.UseVisualStyleBackColor = true;
            this.btn_Invia.Click += new System.EventHandler(this.btn_Invia_Click);
            // 
            // lbl_TempAttuale
            // 
            this.lbl_TempAttuale.AutoSize = true;
            this.lbl_TempAttuale.Location = new System.Drawing.Point(338, 149);
            this.lbl_TempAttuale.Name = "lbl_TempAttuale";
            this.lbl_TempAttuale.Size = new System.Drawing.Size(35, 13);
            this.lbl_TempAttuale.TabIndex = 1;
            this.lbl_TempAttuale.Text = "label1";
            // 
            // lbl_minmax
            // 
            this.lbl_minmax.AutoSize = true;
            this.lbl_minmax.Location = new System.Drawing.Point(338, 188);
            this.lbl_minmax.Name = "lbl_minmax";
            this.lbl_minmax.Size = new System.Drawing.Size(35, 13);
            this.lbl_minmax.TabIndex = 2;
            this.lbl_minmax.Text = "label1";
            // 
            // Panel_Info
            // 
            this.Panel_Info.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Info.Controls.Add(this.lbl_Umidita);
            this.Panel_Info.Controls.Add(this.lbl_Percepita);
            this.Panel_Info.Controls.Add(this.lbl_Pressione);
            this.Panel_Info.Controls.Add(this.lbl_precipitazioni);
            this.Panel_Info.Location = new System.Drawing.Point(12, 284);
            this.Panel_Info.Name = "Panel_Info";
            this.Panel_Info.Size = new System.Drawing.Size(249, 154);
            this.Panel_Info.TabIndex = 3;
            // 
            // lbl_Umidita
            // 
            this.lbl_Umidita.AutoSize = true;
            this.lbl_Umidita.Location = new System.Drawing.Point(24, 19);
            this.lbl_Umidita.Name = "lbl_Umidita";
            this.lbl_Umidita.Size = new System.Drawing.Size(42, 13);
            this.lbl_Umidita.TabIndex = 2;
            this.lbl_Umidita.Text = "Umidità";
            // 
            // lbl_Percepita
            // 
            this.lbl_Percepita.AutoSize = true;
            this.lbl_Percepita.Location = new System.Drawing.Point(24, 54);
            this.lbl_Percepita.Name = "lbl_Percepita";
            this.lbl_Percepita.Size = new System.Drawing.Size(52, 13);
            this.lbl_Percepita.TabIndex = 3;
            this.lbl_Percepita.Text = "Percepita";
            // 
            // lbl_Pressione
            // 
            this.lbl_Pressione.AutoSize = true;
            this.lbl_Pressione.Location = new System.Drawing.Point(24, 91);
            this.lbl_Pressione.Name = "lbl_Pressione";
            this.lbl_Pressione.Size = new System.Drawing.Size(53, 13);
            this.lbl_Pressione.TabIndex = 5;
            this.lbl_Pressione.Text = "Pressione";
            // 
            // lbl_precipitazioni
            // 
            this.lbl_precipitazioni.AutoSize = true;
            this.lbl_precipitazioni.Location = new System.Drawing.Point(24, 126);
            this.lbl_precipitazioni.Name = "lbl_precipitazioni";
            this.lbl_precipitazioni.Size = new System.Drawing.Size(69, 13);
            this.lbl_precipitazioni.TabIndex = 4;
            this.lbl_precipitazioni.Text = "Precipitazioni";
            // 
            // lbl_Alba
            // 
            this.lbl_Alba.AutoSize = true;
            this.lbl_Alba.Location = new System.Drawing.Point(21, 17);
            this.lbl_Alba.Name = "lbl_Alba";
            this.lbl_Alba.Size = new System.Drawing.Size(28, 13);
            this.lbl_Alba.TabIndex = 8;
            this.lbl_Alba.Text = "Alba";
            // 
            // lbl_tramonto
            // 
            this.lbl_tramonto.AutoSize = true;
            this.lbl_tramonto.Location = new System.Drawing.Point(21, 42);
            this.lbl_tramonto.Name = "lbl_tramonto";
            this.lbl_tramonto.Size = new System.Drawing.Size(52, 13);
            this.lbl_tramonto.TabIndex = 7;
            this.lbl_tramonto.Text = "Tramonto";
            // 
            // lbl_ProPrecipita
            // 
            this.lbl_ProPrecipita.AutoSize = true;
            this.lbl_ProPrecipita.Location = new System.Drawing.Point(499, 99);
            this.lbl_ProPrecipita.Name = "lbl_ProPrecipita";
            this.lbl_ProPrecipita.Size = new System.Drawing.Size(64, 13);
            this.lbl_ProPrecipita.TabIndex = 6;
            this.lbl_ProPrecipita.Text = "ProPrecipita";
            // 
            // lbl_Ivento
            // 
            this.lbl_Ivento.AutoSize = true;
            this.lbl_Ivento.Location = new System.Drawing.Point(21, 19);
            this.lbl_Ivento.Name = "lbl_Ivento";
            this.lbl_Ivento.Size = new System.Drawing.Size(47, 13);
            this.lbl_Ivento.TabIndex = 1;
            this.lbl_Ivento.Text = "IntVento";
            // 
            // lbl_DirVento
            // 
            this.lbl_DirVento.AutoSize = true;
            this.lbl_DirVento.Location = new System.Drawing.Point(115, 19);
            this.lbl_DirVento.Name = "lbl_DirVento";
            this.lbl_DirVento.Size = new System.Drawing.Size(48, 13);
            this.lbl_DirVento.TabIndex = 0;
            this.lbl_DirVento.Text = "DirVento";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(144, 25);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 20);
            this.txt_City.TabIndex = 4;
            this.txt_City.Text = "Bergamo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_Ivento);
            this.panel1.Controls.Add(this.lbl_DirVento);
            this.panel1.Location = new System.Drawing.Point(268, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 72);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::App_Meteo.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(737, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_Alba);
            this.panel2.Controls.Add(this.lbl_tramonto);
            this.panel2.Location = new System.Drawing.Point(267, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 70);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 934);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.Panel_Info);
            this.Controls.Add(this.lbl_ProPrecipita);
            this.Controls.Add(this.lbl_minmax);
            this.Controls.Add(this.lbl_TempAttuale);
            this.Controls.Add(this.btn_Invia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel_Info.ResumeLayout(false);
            this.Panel_Info.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Invia;
        private System.Windows.Forms.Label lbl_TempAttuale;
        private System.Windows.Forms.Label lbl_minmax;
        private System.Windows.Forms.Panel Panel_Info;
        private System.Windows.Forms.Label lbl_precipitazioni;
        private System.Windows.Forms.Label lbl_Percepita;
        private System.Windows.Forms.Label lbl_Umidita;
        private System.Windows.Forms.Label lbl_Ivento;
        private System.Windows.Forms.Label lbl_DirVento;
        private System.Windows.Forms.Label lbl_Pressione;
        private System.Windows.Forms.Label lbl_Alba;
        private System.Windows.Forms.Label lbl_tramonto;
        private System.Windows.Forms.Label lbl_ProPrecipita;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

