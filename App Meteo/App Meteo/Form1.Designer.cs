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
            this.SuspendLayout();
            // 
            // btn_Invia
            // 
            this.btn_Invia.Location = new System.Drawing.Point(38, 23);
            this.btn_Invia.Name = "btn_Invia";
            this.btn_Invia.Size = new System.Drawing.Size(75, 23);
            this.btn_Invia.TabIndex = 0;
            this.btn_Invia.Text = "button1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_TempAttuale);
            this.Controls.Add(this.btn_Invia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Invia;
        private System.Windows.Forms.Label lbl_TempAttuale;
    }
}

