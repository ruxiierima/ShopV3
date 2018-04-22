namespace GlobalShop
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.continua = new System.Windows.Forms.Button();
            this.parola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Champagne & Limousines", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salut!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introdu parola contului tau";
            // 
            // continua
            // 
            this.continua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.continua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continua.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continua.Location = new System.Drawing.Point(48, 262);
            this.continua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.continua.Name = "continua";
            this.continua.Size = new System.Drawing.Size(302, 37);
            this.continua.TabIndex = 5;
            this.continua.Text = "Continua";
            this.continua.UseVisualStyleBackColor = false;
            this.continua.Click += new System.EventHandler(this.continua_Click);
            // 
            // parola
            // 
            this.parola.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.parola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parola.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.Location = new System.Drawing.Point(48, 210);
            this.parola.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.parola.MaxLength = 255;
            this.parola.Name = "parola";
            this.parola.PasswordChar = '•';
            this.parola.Size = new System.Drawing.Size(302, 29);
            this.parola.TabIndex = 4;
            this.parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 335);
            this.Controls.Add(this.continua);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Champagne & Limousines", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Log";
            this.Text = "Global Shop";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button continua;
        private System.Windows.Forms.TextBox parola;
    }
}