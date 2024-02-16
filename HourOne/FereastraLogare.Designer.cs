namespace HourOne
{
    partial class fp
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
            this.components = new System.ComponentModel.Container();
            this.fp_bunVenit = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fp_utilizator = new System.Windows.Forms.TextBox();
            this.fp_parola = new System.Windows.Forms.TextBox();
            this.fp_eroriNumeParola = new System.Windows.Forms.ErrorProvider(this.components);
            this.fp_logare = new System.Windows.Forms.Button();
            this.deschideFisiere = new System.Windows.Forms.OpenFileDialog();
            this.fp_recuperare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fp_eroriNumeParola)).BeginInit();
            this.SuspendLayout();
            // 
            // fp_bunVenit
            // 
            this.fp_bunVenit.AutoSize = true;
            this.fp_bunVenit.Location = new System.Drawing.Point(71, 27);
            this.fp_bunVenit.Name = "fp_bunVenit";
            this.fp_bunVenit.Size = new System.Drawing.Size(55, 13);
            this.fp_bunVenit.TabIndex = 0;
            this.fp_bunVenit.Text = "Bun venit ";
            this.fp_bunVenit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // fp_utilizator
            // 
            this.fp_utilizator.Location = new System.Drawing.Point(60, 43);
            this.fp_utilizator.Name = "fp_utilizator";
            this.fp_utilizator.Size = new System.Drawing.Size(100, 20);
            this.fp_utilizator.TabIndex = 2;
            // 
            // fp_parola
            // 
            this.fp_parola.Location = new System.Drawing.Point(60, 69);
            this.fp_parola.Name = "fp_parola";
            this.fp_parola.PasswordChar = '*';
            this.fp_parola.Size = new System.Drawing.Size(100, 20);
            this.fp_parola.TabIndex = 3;
            // 
            // fp_eroriNumeParola
            // 
            this.fp_eroriNumeParola.ContainerControl = this;
            // 
            // fp_logare
            // 
            this.fp_eroriNumeParola.SetIconAlignment(this.fp_logare, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.fp_logare.Location = new System.Drawing.Point(74, 95);
            this.fp_logare.Name = "fp_logare";
            this.fp_logare.Size = new System.Drawing.Size(75, 23);
            this.fp_logare.TabIndex = 4;
            this.fp_logare.Text = "Logare";
            this.fp_logare.UseVisualStyleBackColor = true;
            this.fp_logare.Click += new System.EventHandler(this.fp_logare_Click);
            // 
            // fp_recuperare
            // 
            this.fp_recuperare.Location = new System.Drawing.Point(147, 150);
            this.fp_recuperare.Name = "fp_recuperare";
            this.fp_recuperare.Size = new System.Drawing.Size(75, 23);
            this.fp_recuperare.TabIndex = 5;
            this.fp_recuperare.Text = "Recuperare";
            this.fp_recuperare.UseVisualStyleBackColor = true;
            this.fp_recuperare.Click += new System.EventHandler(this.fp_recuperare_Click);
            // 
            // fp
            // 
            this.AcceptButton = this.fp_logare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.fp_recuperare);
            this.Controls.Add(this.fp_logare);
            this.Controls.Add(this.fp_parola);
            this.Controls.Add(this.fp_utilizator);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.fp_bunVenit);
            this.MaximumSize = new System.Drawing.Size(250, 250);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "fp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PassManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fp_eroriNumeParola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fp_bunVenit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox fp_utilizator;
        private System.Windows.Forms.TextBox fp_parola;
        private System.Windows.Forms.ErrorProvider fp_eroriNumeParola;
        private System.Windows.Forms.Button fp_logare;
        private System.Windows.Forms.OpenFileDialog deschideFisiere;
        private System.Windows.Forms.Button fp_recuperare;
    }
}

