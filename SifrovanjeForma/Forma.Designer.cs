namespace SifrovanjeForma
{
    partial class MainForm
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
            this.UnosTeksta = new System.Windows.Forms.TextBox();
            this.Sifra = new System.Windows.Forms.TextBox();
            this.SifrujButton = new System.Windows.Forms.Button();
            this.DesifrujButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rezultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Desifra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UnosTeksta
            // 
            this.UnosTeksta.Location = new System.Drawing.Point(181, 36);
            this.UnosTeksta.Name = "UnosTeksta";
            this.UnosTeksta.Size = new System.Drawing.Size(159, 22);
            this.UnosTeksta.TabIndex = 0;
            // 
            // Sifra
            // 
            this.Sifra.Location = new System.Drawing.Point(471, 36);
            this.Sifra.Name = "Sifra";
            this.Sifra.Size = new System.Drawing.Size(159, 22);
            this.Sifra.TabIndex = 1;
            // 
            // SifrujButton
            // 
            this.SifrujButton.Location = new System.Drawing.Point(681, 33);
            this.SifrujButton.Name = "SifrujButton";
            this.SifrujButton.Size = new System.Drawing.Size(130, 23);
            this.SifrujButton.TabIndex = 2;
            this.SifrujButton.Text = "Sifruj";
            this.SifrujButton.UseVisualStyleBackColor = true;
            // 
            // DesifrujButton
            // 
            this.DesifrujButton.Location = new System.Drawing.Point(681, 129);
            this.DesifrujButton.Name = "DesifrujButton";
            this.DesifrujButton.Size = new System.Drawing.Size(113, 23);
            this.DesifrujButton.TabIndex = 3;
            this.DesifrujButton.Text = "Desifruj";
            this.DesifrujButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesite tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unesite sifru";
            // 
            // Rezultat
            // 
            this.Rezultat.Location = new System.Drawing.Point(295, 87);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(305, 22);
            this.Rezultat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tekst nakon sifrovanja";
            // 
            // Desifra
            // 
            this.Desifra.Location = new System.Drawing.Point(295, 129);
            this.Desifra.Name = "Desifra";
            this.Desifra.Size = new System.Drawing.Size(159, 22);
            this.Desifra.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 304);
            this.Controls.Add(this.Desifra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DesifrujButton);
            this.Controls.Add(this.SifrujButton);
            this.Controls.Add(this.Sifra);
            this.Controls.Add(this.UnosTeksta);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnosTeksta;
        private System.Windows.Forms.TextBox Sifra;
        private System.Windows.Forms.Button SifrujButton;
        private System.Windows.Forms.Button DesifrujButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rezultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Desifra;
    }
}

