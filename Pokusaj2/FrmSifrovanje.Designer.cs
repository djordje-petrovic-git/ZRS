namespace Pokusaj2
{
    partial class FrmSifrovanje
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
            this.Sifruj = new System.Windows.Forms.Button();
            this.UnosDokumentaTextBox = new System.Windows.Forms.TextBox();
            this.SifraTextBox = new System.Windows.Forms.TextBox();
            this.RezultatTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Desifruj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DesifraTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sifruj
            // 
            this.Sifruj.Location = new System.Drawing.Point(155, 190);
            this.Sifruj.Name = "Sifruj";
            this.Sifruj.Size = new System.Drawing.Size(180, 32);
            this.Sifruj.TabIndex = 0;
            this.Sifruj.Text = "Pokreni šifrovanje";
            this.Sifruj.UseVisualStyleBackColor = true;
            this.Sifruj.Click += new System.EventHandler(this.SifrujButton_Click);
            // 
            // UnosDokumentaTextBox
            // 
            this.UnosDokumentaTextBox.Location = new System.Drawing.Point(155, 42);
            this.UnosDokumentaTextBox.Name = "UnosDokumentaTextBox";
            this.UnosDokumentaTextBox.Size = new System.Drawing.Size(454, 22);
            this.UnosDokumentaTextBox.TabIndex = 1;
            this.UnosDokumentaTextBox.Click += new System.EventHandler(this.UnosDokumentaTextBox_Click);
            // 
            // SifraTextBox
            // 
            this.SifraTextBox.Location = new System.Drawing.Point(155, 109);
            this.SifraTextBox.Name = "SifraTextBox";
            this.SifraTextBox.PasswordChar = '*';
            this.SifraTextBox.Size = new System.Drawing.Size(180, 22);
            this.SifraTextBox.TabIndex = 2;
            // 
            // RezultatTextBox
            // 
            this.RezultatTextBox.Location = new System.Drawing.Point(155, 298);
            this.RezultatTextBox.Name = "RezultatTextBox";
            this.RezultatTextBox.Size = new System.Drawing.Size(349, 22);
            this.RezultatTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Izaberite dokument:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unesite šifru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rezultat sifrovanja: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Desifruj
            // 
            this.Desifruj.Location = new System.Drawing.Point(429, 190);
            this.Desifruj.Name = "Desifruj";
            this.Desifruj.Size = new System.Drawing.Size(180, 32);
            this.Desifruj.TabIndex = 7;
            this.Desifruj.Text = "Pokreni dešifrovanje";
            this.Desifruj.UseVisualStyleBackColor = true;
            this.Desifruj.Click += new System.EventHandler(this.DesifrujButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unesite sifru za desifrovanje";
            // 
            // DesifraTextBox
            // 
            this.DesifraTextBox.Location = new System.Drawing.Point(429, 109);
            this.DesifraTextBox.Name = "DesifraTextBox";
            this.DesifraTextBox.PasswordChar = '*';
            this.DesifraTextBox.Size = new System.Drawing.Size(180, 22);
            this.DesifraTextBox.TabIndex = 9;
            // 
            // FrmSifrovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 375);
            this.Controls.Add(this.DesifraTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Desifruj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RezultatTextBox);
            this.Controls.Add(this.SifraTextBox);
            this.Controls.Add(this.UnosDokumentaTextBox);
            this.Controls.Add(this.Sifruj);
            this.Name = "FrmSifrovanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma za sifrovanje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sifruj;
        private System.Windows.Forms.TextBox UnosDokumentaTextBox;
        private System.Windows.Forms.TextBox SifraTextBox;
        private System.Windows.Forms.TextBox RezultatTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Desifruj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DesifraTextBox;
    }
}

