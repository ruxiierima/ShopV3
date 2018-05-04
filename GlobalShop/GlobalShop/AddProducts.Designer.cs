namespace GlobalShop
{
    partial class AddProducts
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
            this.AddProduct = new System.Windows.Forms.Button();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.Label();
            this.categorie = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.detaliiProdus = new System.Windows.Forms.Label();
            this.pret = new System.Windows.Forms.Label();
            this.pretTExtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stoc = new System.Windows.Forms.TextBox();
            this.caracteristici = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagine = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AddProduct.Location = new System.Drawing.Point(522, 356);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(222, 45);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Adaugare Produs";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(100, 92);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTextBox.TabIndex = 1;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(23, 87);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(62, 24);
            this.productName.TabIndex = 2;
            this.productName.Text = "Nume";
            this.productName.Click += new System.EventHandler(this.productName_Click);
            // 
            // categorie
            // 
            this.categorie.AutoSize = true;
            this.categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.categorie.Location = new System.Drawing.Point(625, 9);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(119, 29);
            this.categorie.TabIndex = 3;
            this.categorie.Text = "Categorie";
            this.categorie.Click += new System.EventHandler(this.categorie_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Laptopuri",
            "Tablete",
            "Telefoane",
            "PC si Periferice",
            "TV si Audio-Video",
            "Gaming",
            "Haine",
            "Carti",
            "Auto si Moto"});
            this.checkedListBox1.Location = new System.Drawing.Point(579, 54);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(247, 196);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // detaliiProdus
            // 
            this.detaliiProdus.AutoSize = true;
            this.detaliiProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.detaliiProdus.Location = new System.Drawing.Point(36, 29);
            this.detaliiProdus.Name = "detaliiProdus";
            this.detaliiProdus.Size = new System.Drawing.Size(164, 29);
            this.detaliiProdus.TabIndex = 5;
            this.detaliiProdus.Text = "Detalii Produs";
            // 
            // pret
            // 
            this.pret.AutoSize = true;
            this.pret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret.Location = new System.Drawing.Point(23, 144);
            this.pret.Name = "pret";
            this.pret.Size = new System.Drawing.Size(43, 24);
            this.pret.TabIndex = 6;
            this.pret.Text = "Pret";
            // 
            // pretTExtBox
            // 
            this.pretTExtBox.Location = new System.Drawing.Point(100, 149);
            this.pretTExtBox.Name = "pretTExtBox";
            this.pretTExtBox.Size = new System.Drawing.Size(100, 20);
            this.pretTExtBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stoc";
            // 
            // stoc
            // 
            this.stoc.Location = new System.Drawing.Point(100, 197);
            this.stoc.Name = "stoc";
            this.stoc.Size = new System.Drawing.Size(100, 20);
            this.stoc.TabIndex = 9;
            // 
            // caracteristici
            // 
            this.caracteristici.AutoSize = true;
            this.caracteristici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caracteristici.Location = new System.Drawing.Point(58, 252);
            this.caracteristici.Name = "caracteristici";
            this.caracteristici.Size = new System.Drawing.Size(115, 24);
            this.caracteristici.TabIndex = 10;
            this.caracteristici.Text = "Caracteristici";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(305, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // imagine
            // 
            this.imagine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.imagine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagine.Location = new System.Drawing.Point(346, 222);
            this.imagine.Name = "imagine";
            this.imagine.Size = new System.Drawing.Size(107, 39);
            this.imagine.TabIndex = 13;
            this.imagine.Text = "Imagine";
            this.imagine.UseVisualStyleBackColor = false;
            this.imagine.Click += new System.EventHandler(this.imagine_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(27, 279);
            this.textBox1.MaximumSize = new System.Drawing.Size(500, 500);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(228, 150);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imagine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.caracteristici);
            this.Controls.Add(this.stoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pretTExtBox);
            this.Controls.Add(this.pret);
            this.Controls.Add(this.detaliiProdus);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.categorie);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.AddProduct);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Label categorie;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label detaliiProdus;
        private System.Windows.Forms.Label pret;
        private System.Windows.Forms.TextBox pretTExtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stoc;
        private System.Windows.Forms.Label caracteristici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button imagine;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}