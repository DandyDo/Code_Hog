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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.TicketsPage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.dependenciesLabel = new System.Windows.Forms.Label();
            this.editTicketButton = new System.Windows.Forms.Button();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.reporterNameLabel = new System.Windows.Forms.Label();
            this.ticketIDLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketArchiveStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ticketsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet = new Code_Hog.CodeHogDataSet();
            this.createNewTicketButton = new System.Windows.Forms.Button();
            this.archiveCheckBox = new System.Windows.Forms.CheckBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.UserManagementPage = new System.Windows.Forms.TabPage();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet1 = new Code_Hog.CodeHogDataSet1();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new Code_Hog.CodeHogDataSetTableAdapters.TicketsTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_RolesTableAdapter = new Code_Hog.CodeHogDataSet1TableAdapters.User_RolesTableAdapter();
            this.usersTableAdapter = new Code_Hog.CodeHogDataSet1TableAdapters.UsersTableAdapter();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.menuTabControl.SuspendLayout();
            this.TicketsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.TicketsPage);
            this.menuTabControl.Controls.Add(this.UserManagementPage);
            this.menuTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTabControl.Location = new System.Drawing.Point(13, 13);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(1241, 713);
            this.menuTabControl.TabIndex = 0;
            // 
            // TicketsPage
            // 
            this.TicketsPage.Controls.Add(this.label10);
            this.TicketsPage.Controls.Add(this.label1);
            this.TicketsPage.Controls.Add(this.statusLabel);
            this.TicketsPage.Controls.Add(this.priorityLabel);
            this.TicketsPage.Controls.Add(this.dependenciesLabel);
            this.TicketsPage.Controls.Add(this.editTicketButton);
            this.TicketsPage.Controls.Add(this.addNoteButton);
            this.TicketsPage.Controls.Add(this.noteTextBox);
            this.TicketsPage.Controls.Add(this.descriptionTextBox);
            this.TicketsPage.Controls.Add(this.nameTextBox);
            this.TicketsPage.Controls.Add(this.reporterNameLabel);
            this.TicketsPage.Controls.Add(this.ticketIDLabel);
            this.TicketsPage.Controls.Add(this.label9);
            this.TicketsPage.Controls.Add(this.label8);
            this.TicketsPage.Controls.Add(this.label7);
            this.TicketsPage.Controls.Add(this.label6);
            this.TicketsPage.Controls.Add(this.label5);
            this.TicketsPage.Controls.Add(this.label4);
            this.TicketsPage.Controls.Add(this.label3);
            this.TicketsPage.Controls.Add(this.label2);
            this.TicketsPage.Controls.Add(this.ticketDataGridView);
            this.TicketsPage.Controls.Add(this.createNewTicketButton);
            this.TicketsPage.Controls.Add(this.archiveCheckBox);
            this.TicketsPage.Controls.Add(this.activeCheckBox);
            this.TicketsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketsPage.Location = new System.Drawing.Point(4, 25);
            this.TicketsPage.Name = "TicketsPage";
            this.TicketsPage.Padding = new System.Windows.Forms.Padding(3);
            this.TicketsPage.Size = new System.Drawing.Size(1233, 684);
            this.TicketsPage.TabIndex = 0;
            this.TicketsPage.Text = "Tickets";
            this.TicketsPage.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Select The Data Grid Headers To Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Filter by:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(710, 55);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(14, 16);
            this.statusLabel.TabIndex = 26;
            this.statusLabel.Text = "..";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(833, 17);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(14, 16);
            this.priorityLabel.TabIndex = 25;
            this.priorityLabel.Text = "..";
            // 
            // dependenciesLabel
            // 
            this.dependenciesLabel.AutoSize = true;
            this.dependenciesLabel.Location = new System.Drawing.Point(762, 86);
            this.dependenciesLabel.Name = "dependenciesLabel";
            this.dependenciesLabel.Size = new System.Drawing.Size(14, 16);
            this.dependenciesLabel.TabIndex = 1;
            this.dependenciesLabel.Text = "..";
            // 
            // editTicketButton
            // 
            this.editTicketButton.Location = new System.Drawing.Point(1131, 77);
            this.editTicketButton.Name = "editTicketButton";
            this.editTicketButton.Size = new System.Drawing.Size(95, 34);
            this.editTicketButton.TabIndex = 24;
            this.editTicketButton.Text = "Edit Ticket";
            this.editTicketButton.UseVisualStyleBackColor = true;
            this.editTicketButton.Click += new System.EventHandler(this.EditTicketButton_Click);
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(1143, 471);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(84, 27);
            this.addNoteButton.TabIndex = 23;
            this.addNoteButton.Text = "Add Note";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(660, 501);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ReadOnly = true;
            this.noteTextBox.Size = new System.Drawing.Size(566, 180);
            this.noteTextBox.TabIndex = 22;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(660, 169);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(566, 296);
            this.descriptionTextBox.TabIndex = 21;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(710, 117);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(516, 22);
            this.nameTextBox.TabIndex = 20;
            // 
            // reporterNameLabel
            // 
            this.reporterNameLabel.AutoSize = true;
            this.reporterNameLabel.Location = new System.Drawing.Point(983, 55);
            this.reporterNameLabel.Name = "reporterNameLabel";
            this.reporterNameLabel.Size = new System.Drawing.Size(14, 16);
            this.reporterNameLabel.TabIndex = 17;
            this.reporterNameLabel.Text = "..";
            // 
            // ticketIDLabel
            // 
            this.ticketIDLabel.AutoSize = true;
            this.ticketIDLabel.Location = new System.Drawing.Point(720, 17);
            this.ticketIDLabel.Name = "ticketIDLabel";
            this.ticketIDLabel.Size = new System.Drawing.Size(14, 16);
            this.ticketIDLabel.TabIndex = 14;
            this.ticketIDLabel.Text = "..";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Notes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Dependencies:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(913, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reporter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status:";
            this.toolTip3.SetToolTip(this.label5, "1 = unresolved\r\n2 = Currently Being Addressed\r\n3 = Archived/Completed/Ignored");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Priority:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ticket #:";
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.AllowUserToAddRows = false;
            this.ticketDataGridView.AllowUserToDeleteRows = false;
            this.ticketDataGridView.AllowUserToResizeColumns = false;
            this.ticketDataGridView.AllowUserToResizeRows = false;
            this.ticketDataGridView.AutoGenerateColumns = false;
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.ticketPriorityDataGridViewTextBoxColumn,
            this.ticketNameDataGridViewTextBoxColumn,
            this.TicketArchiveStatus});
            this.ticketDataGridView.DataSource = this.ticketsBindingSource1;
            this.ticketDataGridView.Location = new System.Drawing.Point(10, 69);
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ticketDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ticketDataGridView.Size = new System.Drawing.Size(640, 612);
            this.ticketDataGridView.TabIndex = 5;
            this.ticketDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TicketDataGridView_RowHeaderMouseClick);
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "Ticket #";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // ticketPriorityDataGridViewTextBoxColumn
            // 
            this.ticketPriorityDataGridViewTextBoxColumn.DataPropertyName = "TicketPriority";
            this.ticketPriorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.ticketPriorityDataGridViewTextBoxColumn.Name = "ticketPriorityDataGridViewTextBoxColumn";
            this.ticketPriorityDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketPriorityDataGridViewTextBoxColumn.Width = 55;
            // 
            // ticketNameDataGridViewTextBoxColumn
            // 
            this.ticketNameDataGridViewTextBoxColumn.DataPropertyName = "TicketName";
            this.ticketNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.ticketNameDataGridViewTextBoxColumn.Name = "ticketNameDataGridViewTextBoxColumn";
            this.ticketNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketNameDataGridViewTextBoxColumn.Width = 400;
            // 
            // TicketArchiveStatus
            // 
            this.TicketArchiveStatus.DataPropertyName = "TicketArchiveStatus";
            this.TicketArchiveStatus.HeaderText = "Archived";
            this.TicketArchiveStatus.Name = "TicketArchiveStatus";
            this.TicketArchiveStatus.ReadOnly = true;
            this.TicketArchiveStatus.Width = 65;
            // 
            // ticketsBindingSource1
            // 
            this.ticketsBindingSource1.DataMember = "Tickets";
            this.ticketsBindingSource1.DataSource = this.codeHogDataSet;
            // 
            // codeHogDataSet
            // 
            this.codeHogDataSet.DataSetName = "CodeHogDataSet";
            this.codeHogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createNewTicketButton
            // 
            this.createNewTicketButton.Location = new System.Drawing.Point(477, 14);
            this.createNewTicketButton.Name = "createNewTicketButton";
            this.createNewTicketButton.Size = new System.Drawing.Size(173, 26);
            this.createNewTicketButton.TabIndex = 3;
            this.createNewTicketButton.Text = "Create New Ticket";
            this.createNewTicketButton.UseVisualStyleBackColor = true;
            this.createNewTicketButton.Click += new System.EventHandler(this.CreateNewTicketButton_Click);
            // 
            // archiveCheckBox
            // 
            this.archiveCheckBox.AutoSize = true;
            this.archiveCheckBox.Location = new System.Drawing.Point(71, 39);
            this.archiveCheckBox.Name = "archiveCheckBox";
            this.archiveCheckBox.Size = new System.Drawing.Size(72, 20);
            this.archiveCheckBox.TabIndex = 1;
            this.archiveCheckBox.Text = "Archive";
            this.archiveCheckBox.UseVisualStyleBackColor = true;
            this.archiveCheckBox.CheckedChanged += new System.EventHandler(this.FilterDataGridChange);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Checked = true;
            this.activeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeCheckBox.Location = new System.Drawing.Point(71, 9);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(64, 20);
            this.activeCheckBox.TabIndex = 0;
            this.activeCheckBox.Text = "Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            this.activeCheckBox.CheckedChanged += new System.EventHandler(this.FilterDataGridChange);
            // 
            // UserManagementPage
            // 
            this.UserManagementPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagementPage.Location = new System.Drawing.Point(4, 25);
            this.UserManagementPage.Name = "UserManagementPage";
            this.UserManagementPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserManagementPage.Size = new System.Drawing.Size(1233, 684);
            this.UserManagementPage.TabIndex = 1;
            this.UserManagementPage.Text = "User Management";
            this.UserManagementPage.UseVisualStyleBackColor = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.codeHogDataSet1BindingSource;
            // 
            // codeHogDataSet1BindingSource
            // 
            this.codeHogDataSet1BindingSource.DataSource = this.codeHogDataSet1;
            this.codeHogDataSet1BindingSource.Position = 0;
            // 
            // codeHogDataSet1
            // 
            this.codeHogDataSet1.DataSetName = "CodeHogDataSet1";
            this.codeHogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.codeHogDataSet;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userRolesBindingSource
            // 
            this.userRolesBindingSource.DataMember = "User_Roles";
            this.userRolesBindingSource.DataSource = this.codeHogDataSet1BindingSource;
            // 
            // user_RolesTableAdapter
            // 
            this.user_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 738);
            this.Controls.Add(this.menuTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Hog";
            this.Load += new System.EventHandler(this.Menus_Load);
            this.menuTabControl.ResumeLayout(false);
            this.TicketsPage.ResumeLayout(false);
            this.TicketsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage TicketsPage;
        private System.Windows.Forms.TabPage UserManagementPage;
        private System.Windows.Forms.CheckBox archiveCheckBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.Button createNewTicketButton;
        private CodeHogDataSet codeHogDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private CodeHogDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridView ticketDataGridView;
        private System.Windows.Forms.BindingSource ticketsBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ticketIDLabel;
        private System.Windows.Forms.Label reporterNameLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.BindingSource codeHogDataSet1BindingSource;
        private CodeHogDataSet1 codeHogDataSet1;
        private System.Windows.Forms.BindingSource userRolesBindingSource;
        private CodeHogDataSet1TableAdapters.User_RolesTableAdapter user_RolesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private CodeHogDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label dependenciesLabel;
        private System.Windows.Forms.Button editTicketButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TicketArchiveStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}

