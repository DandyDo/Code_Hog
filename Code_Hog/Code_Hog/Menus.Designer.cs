namespace Code_Hog {
    partial class Menus {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TicketsPage = new System.Windows.Forms.TabPage();
            this.UserManagementPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TicketsPage);
            this.tabControl1.Controls.Add(this.UserManagementPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 713);
            this.tabControl1.TabIndex = 0;
            // 
            // TicketsPage
            // 
            this.TicketsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketsPage.Location = new System.Drawing.Point(4, 22);
            this.TicketsPage.Name = "TicketsPage";
            this.TicketsPage.Padding = new System.Windows.Forms.Padding(3);
            this.TicketsPage.Size = new System.Drawing.Size(1233, 687);
            this.TicketsPage.TabIndex = 0;
            this.TicketsPage.Text = "Tickets";
            this.TicketsPage.UseVisualStyleBackColor = true;
            // 
            // UserManagementPage
            // 
            this.UserManagementPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagementPage.Location = new System.Drawing.Point(4, 22);
            this.UserManagementPage.Name = "UserManagementPage";
            this.UserManagementPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserManagementPage.Size = new System.Drawing.Size(1233, 687);
            this.UserManagementPage.TabIndex = 1;
            this.UserManagementPage.Text = "User Management";
            this.UserManagementPage.UseVisualStyleBackColor = true;
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 738);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menus";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TicketsPage;
        private System.Windows.Forms.TabPage UserManagementPage;
    }
}

