namespace GlobalShop
{
    partial class AdministrationShop
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
            this.viewUsersLIst = new System.Windows.Forms.ListBox();
            this.viewUser = new System.Windows.Forms.Button();
            this.deleteUsers = new System.Windows.Forms.Button();
            this.viewProduct = new System.Windows.Forms.Button();
            this.info_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewUsersLIst
            // 
            this.viewUsersLIst.FormattingEnabled = true;
            this.viewUsersLIst.Location = new System.Drawing.Point(12, 12);
            this.viewUsersLIst.Name = "viewUsersLIst";
            this.viewUsersLIst.Size = new System.Drawing.Size(239, 342);
            this.viewUsersLIst.TabIndex = 0;
            this.viewUsersLIst.SelectedIndexChanged += new System.EventHandler(this.viewUsersLIst_SelectedIndexChanged);
            // 
            // viewUser
            // 
            this.viewUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.viewUser.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewUser.Location = new System.Drawing.Point(357, 35);
            this.viewUser.Name = "viewUser";
            this.viewUser.Size = new System.Drawing.Size(187, 39);
            this.viewUser.TabIndex = 1;
            this.viewUser.Text = "Vizualizare Utilizatori";
            this.viewUser.UseVisualStyleBackColor = false;
            this.viewUser.Click += new System.EventHandler(this.viewUser_Click);
            // 
            // deleteUsers
            // 
            this.deleteUsers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteUsers.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteUsers.Location = new System.Drawing.Point(357, 108);
            this.deleteUsers.Name = "deleteUsers";
            this.deleteUsers.Size = new System.Drawing.Size(187, 39);
            this.deleteUsers.TabIndex = 2;
            this.deleteUsers.Text = "Stergere Utilizatori";
            this.deleteUsers.UseVisualStyleBackColor = false;
            this.deleteUsers.Click += new System.EventHandler(this.deleteUsers_Click);
            // 
            // viewProduct
            // 
            this.viewProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.viewProduct.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewProduct.Location = new System.Drawing.Point(357, 185);
            this.viewProduct.Name = "viewProduct";
            this.viewProduct.Size = new System.Drawing.Size(187, 39);
            this.viewProduct.TabIndex = 3;
            this.viewProduct.Text = "Vizualizare produse ";
            this.viewProduct.UseVisualStyleBackColor = false;
            this.viewProduct.Click += new System.EventHandler(this.viewProduct_Click);
            // 
            // info_user
            // 
            this.info_user.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.info_user.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info_user.Location = new System.Drawing.Point(357, 267);
            this.info_user.Name = "info_user";
            this.info_user.Size = new System.Drawing.Size(187, 39);
            this.info_user.TabIndex = 6;
            this.info_user.Text = "Informatii Utilizator";
            this.info_user.UseVisualStyleBackColor = false;
            this.info_user.Click += new System.EventHandler(this.info_user_Click);
            // 
            // AdministrationShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.info_user);
            this.Controls.Add(this.viewProduct);
            this.Controls.Add(this.deleteUsers);
            this.Controls.Add(this.viewUser);
            this.Controls.Add(this.viewUsersLIst);
            this.Name = "AdministrationShop";
            this.Text = "AdministrationShop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox viewUsersLIst;
        private System.Windows.Forms.Button viewUser;
        private System.Windows.Forms.Button deleteUsers;
        private System.Windows.Forms.Button viewProduct;
        private System.Windows.Forms.Button info_user;
    }
}