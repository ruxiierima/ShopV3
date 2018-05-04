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
            this.imagine = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(483, 323);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(185, 38);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Adaugare Produs";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTextBox.Location = new System.Drawing.Point(112, 78);
            this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(154, 26);
            this.ProductNameTextBox.TabIndex = 1;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(11, 74);
            this.productName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(78, 29);
            this.productName.TabIndex = 2;
            this.productName.Text = "Nume";
            this.productName.Click += new System.EventHandler(this.productName_Click);
            // 
            // categorie
            // 
            this.categorie.AutoSize = true;
            this.categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorie.Location = new System.Drawing.Point(375, 9);
            this.categorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.checkedListBox1.Location = new System.Drawing.Point(348, 48);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(206, 76);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // detaliiProdus
            // 
            this.detaliiProdus.AutoSize = true;
            this.detaliiProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaliiProdus.Location = new System.Drawing.Point(30, 25);
            this.detaliiProdus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.detaliiProdus.Name = "detaliiProdus";
            this.detaliiProdus.Size = new System.Drawing.Size(164, 29);
            this.detaliiProdus.TabIndex = 5;
            this.detaliiProdus.Text = "Detalii Produs";
            // 
            // pret
            // 
            this.pret.AutoSize = true;
            this.pret.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret.Location = new System.Drawing.Point(11, 123);
            this.pret.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pret.Name = "pret";
            this.pret.Size = new System.Drawing.Size(57, 29);
            this.pret.TabIndex = 6;
            this.pret.Text = "Pret";
            // 
            // pretTExtBox
            // 
            this.pretTExtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretTExtBox.Location = new System.Drawing.Point(112, 126);
            this.pretTExtBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pretTExtBox.Name = "pretTExtBox";
            this.pretTExtBox.Size = new System.Drawing.Size(154, 26);
            this.pretTExtBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stoc";
            // 
            // stoc
            // 
            this.stoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoc.Location = new System.Drawing.Point(112, 171);
            this.stoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stoc.Name = "stoc";
            this.stoc.Size = new System.Drawing.Size(154, 26);
            this.stoc.TabIndex = 9;
            // 
            // caracteristici
            // 
            this.caracteristici.AutoSize = true;
            this.caracteristici.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caracteristici.Location = new System.Drawing.Point(56, 210);
            this.caracteristici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caracteristici.Name = "caracteristici";
            this.caracteristici.Size = new System.Drawing.Size(152, 29);
            this.caracteristici.TabIndex = 10;
            this.caracteristici.Text = "Caracteristici";
            // 
            // imagine
            // 
            this.imagine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.imagine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagine.Location = new System.Drawing.Point(617, 226);
            this.imagine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.imagine.Name = "imagine";
            this.imagine.Size = new System.Drawing.Size(187, 33);
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
            this.textBox1.Location = new System.Drawing.Point(22, 242);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.MaximumSize = new System.Drawing.Size(417, 424);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(214, 129);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Brand";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Apple",
            "Lenovo",
            "Dell",
            "Hp",
            "Samsung",
            "Huawei",
            "Sony",
            "Xiaomi",
            "LG",
            "Allview",
            "Assus",
            "Hurricane",
            "Toshiba"});
            this.checkedListBox2.Location = new System.Drawing.Point(348, 183);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(206, 76);
            this.checkedListBox2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(594, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 413);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label2);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}