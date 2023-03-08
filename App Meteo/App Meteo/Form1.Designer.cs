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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Nminmax5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Nminmax2 = new System.Windows.Forms.Label();
            this.lbl_Nminmax3 = new System.Windows.Forms.Label();
            this.lbl_Nminmax4 = new System.Windows.Forms.Label();
            this.lbl_Stato = new System.Windows.Forms.Label();
            this.lbl_Nminmax = new System.Windows.Forms.Label();
            this.lbl_Giorno = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Info.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel_Air.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lbl_TempAttuale.ForeColor = System.Drawing.Color.White;
            this.lbl_TempAttuale.Location = new System.Drawing.Point(123, 90);
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
            this.lbl_minmax.ForeColor = System.Drawing.Color.White;
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
            this.Panel_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Info.Controls.Add(this.lbl_Umidita);
            this.Panel_Info.Controls.Add(this.lbl_Percepita);
            this.Panel_Info.Controls.Add(this.lbl_Pressione);
            this.Panel_Info.Controls.Add(this.lbl_precipitazioni);
            this.Panel_Info.Controls.Add(this.lbl_ProPrecipita);
            this.Panel_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Info.ForeColor = System.Drawing.Color.White;
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
            this.lbl_Umidita.Size = new System.Drawing.Size(49, 13);
            this.lbl_Umidita.TabIndex = 2;
            this.lbl_Umidita.Text = "Umidità";
            // 
            // lbl_Percepita
            // 
            this.lbl_Percepita.AutoSize = true;
            this.lbl_Percepita.Location = new System.Drawing.Point(24, 54);
            this.lbl_Percepita.Name = "lbl_Percepita";
            this.lbl_Percepita.Size = new System.Drawing.Size(61, 13);
            this.lbl_Percepita.TabIndex = 3;
            this.lbl_Percepita.Text = "Percepita";
            // 
            // lbl_Pressione
            // 
            this.lbl_Pressione.AutoSize = true;
            this.lbl_Pressione.Location = new System.Drawing.Point(24, 91);
            this.lbl_Pressione.Name = "lbl_Pressione";
            this.lbl_Pressione.Size = new System.Drawing.Size(62, 13);
            this.lbl_Pressione.TabIndex = 5;
            this.lbl_Pressione.Text = "Pressione";
            // 
            // lbl_precipitazioni
            // 
            this.lbl_precipitazioni.AutoSize = true;
            this.lbl_precipitazioni.Location = new System.Drawing.Point(24, 126);
            this.lbl_precipitazioni.Name = "lbl_precipitazioni";
            this.lbl_precipitazioni.Size = new System.Drawing.Size(83, 13);
            this.lbl_precipitazioni.TabIndex = 4;
            this.lbl_precipitazioni.Text = "Precipitazioni";
            // 
            // lbl_ProPrecipita
            // 
            this.lbl_ProPrecipita.AutoSize = true;
            this.lbl_ProPrecipita.Location = new System.Drawing.Point(23, 168);
            this.lbl_ProPrecipita.Name = "lbl_ProPrecipita";
            this.lbl_ProPrecipita.Size = new System.Drawing.Size(76, 13);
            this.lbl_ProPrecipita.TabIndex = 6;
            this.lbl_ProPrecipita.Text = "ProPrecipita";
            // 
            // lbl_Alba
            // 
            this.lbl_Alba.AutoSize = true;
            this.lbl_Alba.Location = new System.Drawing.Point(21, 17);
            this.lbl_Alba.Name = "lbl_Alba";
            this.lbl_Alba.Size = new System.Drawing.Size(32, 13);
            this.lbl_Alba.TabIndex = 8;
            this.lbl_Alba.Text = "Alba";
            // 
            // lbl_tramonto
            // 
            this.lbl_tramonto.AutoSize = true;
            this.lbl_tramonto.Location = new System.Drawing.Point(21, 42);
            this.lbl_tramonto.Name = "lbl_tramonto";
            this.lbl_tramonto.Size = new System.Drawing.Size(60, 13);
            this.lbl_tramonto.TabIndex = 7;
            this.lbl_tramonto.Text = "Tramonto";
            // 
            // lbl_Ivento
            // 
            this.lbl_Ivento.AutoSize = true;
            this.lbl_Ivento.Location = new System.Drawing.Point(21, 19);
            this.lbl_Ivento.Name = "lbl_Ivento";
            this.lbl_Ivento.Size = new System.Drawing.Size(55, 13);
            this.lbl_Ivento.TabIndex = 1;
            this.lbl_Ivento.Text = "IntVento";
            // 
            // lbl_DirVento
            // 
            this.lbl_DirVento.AutoSize = true;
            this.lbl_DirVento.Location = new System.Drawing.Point(20, 43);
            this.lbl_DirVento.Name = "lbl_DirVento";
            this.lbl_DirVento.Size = new System.Drawing.Size(56, 13);
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Ivento);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_DirVento);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(268, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 72);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_Alba);
            this.panel2.Controls.Add(this.lbl_tramonto);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(267, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 70);
            this.panel2.TabIndex = 10;
            // 
            // Panel_Air
            // 
            this.Panel_Air.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Air.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Air.Controls.Add(this.lbl_O);
            this.Panel_Air.Controls.Add(this.lbl_Co);
            this.Panel_Air.Controls.Add(this.lbl_pm25);
            this.Panel_Air.Controls.Add(this.lbl_pm10);
            this.Panel_Air.Controls.Add(this.lbl_SO2);
            this.Panel_Air.Controls.Add(this.lbl_NO3);
            this.Panel_Air.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Air.ForeColor = System.Drawing.Color.White;
            this.Panel_Air.Location = new System.Drawing.Point(74, 213);
            this.Panel_Air.Name = "Panel_Air";
            this.Panel_Air.Size = new System.Drawing.Size(249, 226);
            this.Panel_Air.TabIndex = 11;
            this.Panel_Air.Visible = false;
            // 
            // lbl_O
            // 
            this.lbl_O.AutoSize = true;
            this.lbl_O.Location = new System.Drawing.Point(23, 167);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(21, 13);
            this.lbl_O.TabIndex = 7;
            this.lbl_O.Text = "o3";
            // 
            // lbl_Co
            // 
            this.lbl_Co.AutoSize = true;
            this.lbl_Co.Location = new System.Drawing.Point(23, 202);
            this.lbl_Co.Name = "lbl_Co";
            this.lbl_Co.Size = new System.Drawing.Size(22, 13);
            this.lbl_Co.TabIndex = 6;
            this.lbl_Co.Text = "Co";
            // 
            // lbl_pm25
            // 
            this.lbl_pm25.AutoSize = true;
            this.lbl_pm25.Location = new System.Drawing.Point(24, 19);
            this.lbl_pm25.Name = "lbl_pm25";
            this.lbl_pm25.Size = new System.Drawing.Size(45, 13);
            this.lbl_pm25.TabIndex = 2;
            this.lbl_pm25.Text = "pm 2.5";
            // 
            // lbl_pm10
            // 
            this.lbl_pm10.AutoSize = true;
            this.lbl_pm10.Location = new System.Drawing.Point(24, 54);
            this.lbl_pm10.Name = "lbl_pm10";
            this.lbl_pm10.Size = new System.Drawing.Size(37, 13);
            this.lbl_pm10.TabIndex = 3;
            this.lbl_pm10.Text = "pm10";
            // 
            // lbl_SO2
            // 
            this.lbl_SO2.AutoSize = true;
            this.lbl_SO2.Location = new System.Drawing.Point(24, 91);
            this.lbl_SO2.Name = "lbl_SO2";
            this.lbl_SO2.Size = new System.Drawing.Size(29, 13);
            this.lbl_SO2.TabIndex = 5;
            this.lbl_SO2.Text = "So2";
            // 
            // lbl_NO3
            // 
            this.lbl_NO3.AutoSize = true;
            this.lbl_NO3.Location = new System.Drawing.Point(24, 126);
            this.lbl_NO3.Name = "lbl_NO3";
            this.lbl_NO3.Size = new System.Drawing.Size(30, 13);
            this.lbl_NO3.TabIndex = 4;
            this.lbl_NO3.Text = "No3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_qualitàAria);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
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
            this.lbl_qualitàAria.Size = new System.Drawing.Size(45, 13);
            this.lbl_qualitàAria.TabIndex = 3;
            this.lbl_qualitàAria.Text = "pm 2.5";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbl_Nminmax5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbl_Nminmax2);
            this.panel3.Controls.Add(this.lbl_Nminmax3);
            this.panel3.Controls.Add(this.lbl_Nminmax4);
            this.panel3.Controls.Add(this.lbl_Stato);
            this.panel3.Controls.Add(this.lbl_Nminmax);
            this.panel3.Controls.Add(this.lbl_Giorno);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 236);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DOMANI";
            // 
            // lbl_Nminmax5
            // 
            this.lbl_Nminmax5.AutoSize = true;
            this.lbl_Nminmax5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nminmax5.Location = new System.Drawing.Point(384, 193);
            this.lbl_Nminmax5.Name = "lbl_Nminmax5";
            this.lbl_Nminmax5.Size = new System.Drawing.Size(41, 13);
            this.lbl_Nminmax5.TabIndex = 8;
            this.lbl_Nminmax5.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOMANI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DOMANI";
            // 
            // lbl_Nminmax2
            // 
            this.lbl_Nminmax2.AutoSize = true;
            this.lbl_Nminmax2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nminmax2.Location = new System.Drawing.Point(384, 65);
            this.lbl_Nminmax2.Name = "lbl_Nminmax2";
            this.lbl_Nminmax2.Size = new System.Drawing.Size(41, 13);
            this.lbl_Nminmax2.TabIndex = 5;
            this.lbl_Nminmax2.Text = "label2";
            // 
            // lbl_Nminmax3
            // 
            this.lbl_Nminmax3.AutoSize = true;
            this.lbl_Nminmax3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nminmax3.Location = new System.Drawing.Point(384, 109);
            this.lbl_Nminmax3.Name = "lbl_Nminmax3";
            this.lbl_Nminmax3.Size = new System.Drawing.Size(41, 13);
            this.lbl_Nminmax3.TabIndex = 4;
            this.lbl_Nminmax3.Text = "label2";
            // 
            // lbl_Nminmax4
            // 
            this.lbl_Nminmax4.AutoSize = true;
            this.lbl_Nminmax4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nminmax4.Location = new System.Drawing.Point(384, 151);
            this.lbl_Nminmax4.Name = "lbl_Nminmax4";
            this.lbl_Nminmax4.Size = new System.Drawing.Size(41, 13);
            this.lbl_Nminmax4.TabIndex = 3;
            this.lbl_Nminmax4.Text = "label2";
            // 
            // lbl_Stato
            // 
            this.lbl_Stato.AutoSize = true;
            this.lbl_Stato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stato.Location = new System.Drawing.Point(39, 151);
            this.lbl_Stato.Name = "lbl_Stato";
            this.lbl_Stato.Size = new System.Drawing.Size(56, 13);
            this.lbl_Stato.TabIndex = 2;
            this.lbl_Stato.Text = "DOMANI";
            // 
            // lbl_Nminmax
            // 
            this.lbl_Nminmax.AutoSize = true;
            this.lbl_Nminmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nminmax.Location = new System.Drawing.Point(384, 26);
            this.lbl_Nminmax.Name = "lbl_Nminmax";
            this.lbl_Nminmax.Size = new System.Drawing.Size(41, 13);
            this.lbl_Nminmax.TabIndex = 1;
            this.lbl_Nminmax.Text = "label2";
            // 
            // lbl_Giorno
            // 
            this.lbl_Giorno.AutoSize = true;
            this.lbl_Giorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Giorno.Location = new System.Drawing.Point(36, 26);
            this.lbl_Giorno.Name = "lbl_Giorno";
            this.lbl_Giorno.Size = new System.Drawing.Size(56, 13);
            this.lbl_Giorno.TabIndex = 0;
            this.lbl_Giorno.Text = "DOMANI";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(11, 56);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 22);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(11, 100);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 22);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(11, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 22);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(11, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 22);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::App_Meteo.Properties.Resources.Sole;
            this.pictureBox2.Location = new System.Drawing.Point(11, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
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
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 736);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Panel_Air);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.Panel_Info);
            this.Controls.Add(this.lbl_minmax);
            this.Controls.Add(this.lbl_TempAttuale);
            this.Controls.Add(this.btn_Invia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Info.ResumeLayout(false);
            this.Panel_Info.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Panel_Air.ResumeLayout(false);
            this.Panel_Air.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Stato;
        private System.Windows.Forms.Label lbl_Nminmax;
        private System.Windows.Forms.Label lbl_Giorno;
        private System.Windows.Forms.Label lbl_Nminmax2;
        private System.Windows.Forms.Label lbl_Nminmax3;
        private System.Windows.Forms.Label lbl_Nminmax4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Nminmax5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

