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
            this.lbl_ProPrecipita = new System.Windows.Forms.Label();
            this.lbl_Alba = new System.Windows.Forms.Label();
            this.lbl_tramonto = new System.Windows.Forms.Label();
            this.lbl_Ivento = new System.Windows.Forms.Label();
            this.lbl_DirVento = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_Air = new System.Windows.Forms.Panel();
            this.lbl_O = new System.Windows.Forms.Label();
            this.lbl_Co = new System.Windows.Forms.Label();
            this.lbl_pm25 = new System.Windows.Forms.Label();
            this.lbl_pm10 = new System.Windows.Forms.Label();
            this.lbl_SO2 = new System.Windows.Forms.Label();
            this.lbl_NO3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_qualitàAria = new System.Windows.Forms.Label();
            this.Panel_Info.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.Panel_Air.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Invia
            // 
            this.btn_Invia.Location = new System.Drawing.Point(144, 25);
            this.btn_Invia.Name = "btn_Invia";
            this.btn_Invia.Size = new System.Drawing.Size(75, 23);
            this.btn_Invia.TabIndex = 0;
            this.btn_Invia.Text = "Cerca";
            this.btn_Invia.UseVisualStyleBackColor = true;
            this.btn_Invia.Click += new System.EventHandler(this.btn_Invia_Click);
            // 
            // lbl_TempAttuale
            // 
            this.lbl_TempAttuale.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TempAttuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TempAttuale.Location = new System.Drawing.Point(160, 86);
            this.lbl_TempAttuale.Name = "lbl_TempAttuale";
            this.lbl_TempAttuale.Size = new System.Drawing.Size(176, 51);
            this.lbl_TempAttuale.TabIndex = 1;
            this.lbl_TempAttuale.Text = "10.5°C";
            // 
            // lbl_minmax
            // 
            this.lbl_minmax.AutoSize = true;
            this.lbl_minmax.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minmax.Location = new System.Drawing.Point(139, 153);
            this.lbl_minmax.Name = "lbl_minmax";
            this.lbl_minmax.Size = new System.Drawing.Size(125, 25);
            this.lbl_minmax.TabIndex = 2;
            this.lbl_minmax.Text = "10.5/10.5°C";
            this.lbl_minmax.Click += new System.EventHandler(this.lbl_minmax_Click);
            // 
            // Panel_Info
            // 
            this.Panel_Info.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Info.Controls.Add(this.lbl_Umidita);
            this.Panel_Info.Controls.Add(this.lbl_Percepita);
            this.Panel_Info.Controls.Add(this.lbl_Pressione);
            this.Panel_Info.Controls.Add(this.lbl_precipitazioni);
            this.Panel_Info.Controls.Add(this.lbl_ProPrecipita);
            this.Panel_Info.Location = new System.Drawing.Point(12, 284);
            this.Panel_Info.Name = "Panel_Info";
            this.Panel_Info.Size = new System.Drawing.Size(249, 198);
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
            // lbl_ProPrecipita
            // 
            this.lbl_ProPrecipita.AutoSize = true;
            this.lbl_ProPrecipita.Location = new System.Drawing.Point(23, 168);
            this.lbl_ProPrecipita.Name = "lbl_ProPrecipita";
            this.lbl_ProPrecipita.Size = new System.Drawing.Size(64, 13);
            this.lbl_ProPrecipita.TabIndex = 6;
            this.lbl_ProPrecipita.Text = "ProPrecipita";
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
            this.lbl_DirVento.Location = new System.Drawing.Point(20, 43);
            this.lbl_DirVento.Name = "lbl_DirVento";
            this.lbl_DirVento.Size = new System.Drawing.Size(48, 13);
            this.lbl_DirVento.TabIndex = 0;
            this.lbl_DirVento.Text = "DirVento";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(38, 25);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 20);
            this.txt_City.TabIndex = 4;
            this.txt_City.Text = "Bergamo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_Ivento);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_DirVento);
            this.panel1.Location = new System.Drawing.Point(268, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 72);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::App_Meteo.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(113, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_Alba);
            this.panel2.Controls.Add(this.lbl_tramonto);
            this.panel2.Location = new System.Drawing.Point(267, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 70);
            this.panel2.TabIndex = 10;
            // 
            // Panel_Air
            // 
            this.Panel_Air.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Air.Controls.Add(this.lbl_O);
            this.Panel_Air.Controls.Add(this.lbl_Co);
            this.Panel_Air.Controls.Add(this.lbl_pm25);
            this.Panel_Air.Controls.Add(this.lbl_pm10);
            this.Panel_Air.Controls.Add(this.lbl_SO2);
            this.Panel_Air.Controls.Add(this.lbl_NO3);
            this.Panel_Air.Location = new System.Drawing.Point(197, 498);
            this.Panel_Air.Name = "Panel_Air";
            this.Panel_Air.Size = new System.Drawing.Size(249, 233);
            this.Panel_Air.TabIndex = 11;
            this.Panel_Air.Visible = false;
            // 
            // lbl_O
            // 
            this.lbl_O.AutoSize = true;
            this.lbl_O.Location = new System.Drawing.Point(23, 167);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(19, 13);
            this.lbl_O.TabIndex = 7;
            this.lbl_O.Text = "o3";
            // 
            // lbl_Co
            // 
            this.lbl_Co.AutoSize = true;
            this.lbl_Co.Location = new System.Drawing.Point(23, 202);
            this.lbl_Co.Name = "lbl_Co";
            this.lbl_Co.Size = new System.Drawing.Size(20, 13);
            this.lbl_Co.TabIndex = 6;
            this.lbl_Co.Text = "Co";
            // 
            // lbl_pm25
            // 
            this.lbl_pm25.AutoSize = true;
            this.lbl_pm25.Location = new System.Drawing.Point(24, 19);
            this.lbl_pm25.Name = "lbl_pm25";
            this.lbl_pm25.Size = new System.Drawing.Size(39, 13);
            this.lbl_pm25.TabIndex = 2;
            this.lbl_pm25.Text = "pm 2.5";
            // 
            // lbl_pm10
            // 
            this.lbl_pm10.AutoSize = true;
            this.lbl_pm10.Location = new System.Drawing.Point(24, 54);
            this.lbl_pm10.Name = "lbl_pm10";
            this.lbl_pm10.Size = new System.Drawing.Size(33, 13);
            this.lbl_pm10.TabIndex = 3;
            this.lbl_pm10.Text = "pm10";
            // 
            // lbl_SO2
            // 
            this.lbl_SO2.AutoSize = true;
            this.lbl_SO2.Location = new System.Drawing.Point(24, 91);
            this.lbl_SO2.Name = "lbl_SO2";
            this.lbl_SO2.Size = new System.Drawing.Size(26, 13);
            this.lbl_SO2.TabIndex = 5;
            this.lbl_SO2.Text = "So2";
            // 
            // lbl_NO3
            // 
            this.lbl_NO3.AutoSize = true;
            this.lbl_NO3.Location = new System.Drawing.Point(24, 126);
            this.lbl_NO3.Name = "lbl_NO3";
            this.lbl_NO3.Size = new System.Drawing.Size(27, 13);
            this.lbl_NO3.TabIndex = 4;
            this.lbl_NO3.Text = "No3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lbl_qualitàAria);
            this.panel4.Location = new System.Drawing.Point(267, 445);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 37);
            this.panel4.TabIndex = 12;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            // 
            // lbl_qualitàAria
            // 
            this.lbl_qualitàAria.AutoSize = true;
            this.lbl_qualitàAria.Location = new System.Drawing.Point(10, 7);
            this.lbl_qualitàAria.Name = "lbl_qualitàAria";
            this.lbl_qualitàAria.Size = new System.Drawing.Size(39, 13);
            this.lbl_qualitàAria.TabIndex = 3;
            this.lbl_qualitàAria.Text = "pm 2.5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 934);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Panel_Air);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.Panel_Info);
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
            this.Panel_Air.ResumeLayout(false);
            this.Panel_Air.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel Panel_Air;
        private System.Windows.Forms.Label lbl_O;
        private System.Windows.Forms.Label lbl_Co;
        private System.Windows.Forms.Label lbl_pm25;
        private System.Windows.Forms.Label lbl_pm10;
        private System.Windows.Forms.Label lbl_SO2;
        private System.Windows.Forms.Label lbl_NO3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_qualitàAria;
    }
}

