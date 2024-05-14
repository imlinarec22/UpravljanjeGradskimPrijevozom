namespace UpravljanjeGradskimPrijevozom
{
    partial class FrmPocetna
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnGost = new System.Windows.Forms.Button();
            this.btnZaposlenik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(111, 105);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(529, 33);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Gradski autobusni prijevoz Varaždin";
            // 
            // btnGost
            // 
            this.btnGost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGost.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGost.Location = new System.Drawing.Point(244, 177);
            this.btnGost.Name = "btnGost";
            this.btnGost.Size = new System.Drawing.Size(234, 49);
            this.btnGost.TabIndex = 1;
            this.btnGost.Text = "Nastavi kao gost";
            this.btnGost.UseVisualStyleBackColor = false;
            this.btnGost.Click += new System.EventHandler(this.btnGost_Click);
            // 
            // btnZaposlenik
            // 
            this.btnZaposlenik.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnZaposlenik.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposlenik.Location = new System.Drawing.Point(244, 244);
            this.btnZaposlenik.Name = "btnZaposlenik";
            this.btnZaposlenik.Size = new System.Drawing.Size(234, 49);
            this.btnZaposlenik.TabIndex = 2;
            this.btnZaposlenik.Text = "Prijavi se kao zaposlenik";
            this.btnZaposlenik.UseVisualStyleBackColor = false;
            this.btnZaposlenik.Click += new System.EventHandler(this.btnZaposlenik_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 437);
            this.Controls.Add(this.btnZaposlenik);
            this.Controls.Add(this.btnGost);
            this.Controls.Add(this.lblNaslov);
            this.Name = "FrmPocetna";
            this.Text = "Gradski prijevoz Varaždin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnGost;
        private System.Windows.Forms.Button btnZaposlenik;
    }
}

