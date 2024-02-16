namespace HourOne
{
    partial class FereastraParole
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.fp_exit = new System.Windows.Forms.Button();
            this.fp_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(388, 296);
            this.dataGrid.TabIndex = 0;
            // 
            // fp_exit
            // 
            this.fp_exit.Location = new System.Drawing.Point(325, 314);
            this.fp_exit.Name = "fp_exit";
            this.fp_exit.Size = new System.Drawing.Size(75, 23);
            this.fp_exit.TabIndex = 1;
            this.fp_exit.Text = "Exit";
            this.fp_exit.UseVisualStyleBackColor = true;
            this.fp_exit.Click += new System.EventHandler(this.fp_exit_Click);
            // 
            // fp_add
            // 
            this.fp_add.Location = new System.Drawing.Point(12, 314);
            this.fp_add.Name = "fp_add";
            this.fp_add.Size = new System.Drawing.Size(75, 23);
            this.fp_add.TabIndex = 2;
            this.fp_add.Text = "Add";
            this.fp_add.UseVisualStyleBackColor = true;
            // 
            // FereastraParole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 351);
            this.Controls.Add(this.fp_add);
            this.Controls.Add(this.fp_exit);
            this.Controls.Add(this.dataGrid);
            this.MaximumSize = new System.Drawing.Size(428, 390);
            this.MinimumSize = new System.Drawing.Size(428, 390);
            this.Name = "FereastraParole";
            this.Text = "FereastraParole";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button fp_exit;
        private System.Windows.Forms.Button fp_add;
    }
}