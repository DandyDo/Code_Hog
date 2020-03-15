namespace Code_Hog {
    partial class CreateTicketMenu {
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
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextDesc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketArchiveStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TicketReporter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet = new Code_Hog.CodeHogDataSet();
            this.ticketsTableAdapter = new Code_Hog.CodeHogDataSetTableAdapters.TicketsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonReturnMain = new System.Windows.Forms.Button();
            this.RadioPri1 = new System.Windows.Forms.RadioButton();
            this.RadioPri2 = new System.Windows.Forms.RadioButton();
            this.RadioPri3 = new System.Windows.Forms.RadioButton();
            this.RadioPri4 = new System.Windows.Forms.RadioButton();
            this.RadioPri5 = new System.Windows.Forms.RadioButton();
            this.ButtonNewTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(52, 63);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(100, 20);
            this.TextName.TabIndex = 0;
            // 
            // TextDesc
            // 
            this.TextDesc.Location = new System.Drawing.Point(52, 166);
            this.TextDesc.Multiline = true;
            this.TextDesc.Name = "TextDesc";
            this.TextDesc.Size = new System.Drawing.Size(201, 82);
            this.TextDesc.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.ticketNameDataGridViewTextBoxColumn,
            this.TicketStatus,
            this.TicketArchiveStatus,
            this.TicketReporter,
            this.ticketPriorityDataGridViewTextBoxColumn,
            this.ticketDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            // 
            // ticketNameDataGridViewTextBoxColumn
            // 
            this.ticketNameDataGridViewTextBoxColumn.DataPropertyName = "TicketName";
            this.ticketNameDataGridViewTextBoxColumn.HeaderText = "TicketName";
            this.ticketNameDataGridViewTextBoxColumn.Name = "ticketNameDataGridViewTextBoxColumn";
            // 
            // TicketStatus
            // 
            this.TicketStatus.DataPropertyName = "TicketStatus";
            this.TicketStatus.HeaderText = "TicketStatus";
            this.TicketStatus.Name = "TicketStatus";
            // 
            // TicketArchiveStatus
            // 
            this.TicketArchiveStatus.DataPropertyName = "TicketArchiveStatus";
            this.TicketArchiveStatus.HeaderText = "TicketArchiveStatus";
            this.TicketArchiveStatus.Name = "TicketArchiveStatus";
            // 
            // TicketReporter
            // 
            this.TicketReporter.DataPropertyName = "TicketReporter";
            this.TicketReporter.HeaderText = "TicketReporter";
            this.TicketReporter.Name = "TicketReporter";
            // 
            // ticketPriorityDataGridViewTextBoxColumn
            // 
            this.ticketPriorityDataGridViewTextBoxColumn.DataPropertyName = "TicketPriority";
            this.ticketPriorityDataGridViewTextBoxColumn.HeaderText = "TicketPriority";
            this.ticketPriorityDataGridViewTextBoxColumn.Name = "ticketPriorityDataGridViewTextBoxColumn";
            // 
            // ticketDescriptionDataGridViewTextBoxColumn
            // 
            this.ticketDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TicketDescription";
            this.ticketDescriptionDataGridViewTextBoxColumn.HeaderText = "TicketDescription";
            this.ticketDescriptionDataGridViewTextBoxColumn.Name = "ticketDescriptionDataGridViewTextBoxColumn";
            this.ticketDescriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.codeHogDataSetBindingSource;
            // 
            // codeHogDataSetBindingSource
            // 
            this.codeHogDataSetBindingSource.DataSource = this.codeHogDataSet;
            this.codeHogDataSetBindingSource.Position = 0;
            // 
            // codeHogDataSet
            // 
            this.codeHogDataSet.DataSetName = "CodeHogDataSet";
            this.codeHogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // ButtonReturnMain
            // 
            this.ButtonReturnMain.Location = new System.Drawing.Point(382, 61);
            this.ButtonReturnMain.Name = "ButtonReturnMain";
            this.ButtonReturnMain.Size = new System.Drawing.Size(112, 23);
            this.ButtonReturnMain.TabIndex = 6;
            this.ButtonReturnMain.Text = "Return";
            this.ButtonReturnMain.UseVisualStyleBackColor = true;
            this.ButtonReturnMain.Click += new System.EventHandler(this.ButtonReturnMain_Click);
            // 
            // RadioPri1
            // 
            this.RadioPri1.AutoSize = true;
            this.RadioPri1.Location = new System.Drawing.Point(382, 154);
            this.RadioPri1.Name = "RadioPri1";
            this.RadioPri1.Size = new System.Drawing.Size(31, 17);
            this.RadioPri1.TabIndex = 8;
            this.RadioPri1.TabStop = true;
            this.RadioPri1.Text = "1";
            this.RadioPri1.UseVisualStyleBackColor = true;
            this.RadioPri1.CheckedChanged += new System.EventHandler(this.RadioPri1_CheckedChanged);
            // 
            // RadioPri2
            // 
            this.RadioPri2.AutoSize = true;
            this.RadioPri2.Location = new System.Drawing.Point(426, 150);
            this.RadioPri2.Name = "RadioPri2";
            this.RadioPri2.Size = new System.Drawing.Size(31, 17);
            this.RadioPri2.TabIndex = 9;
            this.RadioPri2.TabStop = true;
            this.RadioPri2.Text = "2";
            this.RadioPri2.UseVisualStyleBackColor = true;
            // 
            // RadioPri3
            // 
            this.RadioPri3.AutoSize = true;
            this.RadioPri3.Location = new System.Drawing.Point(463, 150);
            this.RadioPri3.Name = "RadioPri3";
            this.RadioPri3.Size = new System.Drawing.Size(31, 17);
            this.RadioPri3.TabIndex = 10;
            this.RadioPri3.TabStop = true;
            this.RadioPri3.Text = "3";
            this.RadioPri3.UseVisualStyleBackColor = true;
            // 
            // RadioPri4
            // 
            this.RadioPri4.AutoSize = true;
            this.RadioPri4.Location = new System.Drawing.Point(500, 150);
            this.RadioPri4.Name = "RadioPri4";
            this.RadioPri4.Size = new System.Drawing.Size(31, 17);
            this.RadioPri4.TabIndex = 11;
            this.RadioPri4.TabStop = true;
            this.RadioPri4.Text = "4";
            this.RadioPri4.UseVisualStyleBackColor = true;
            // 
            // RadioPri5
            // 
            this.RadioPri5.AutoSize = true;
            this.RadioPri5.Location = new System.Drawing.Point(537, 150);
            this.RadioPri5.Name = "RadioPri5";
            this.RadioPri5.Size = new System.Drawing.Size(31, 17);
            this.RadioPri5.TabIndex = 12;
            this.RadioPri5.TabStop = true;
            this.RadioPri5.Text = "5";
            this.RadioPri5.UseVisualStyleBackColor = true;
            // 
            // ButtonNewTicket
            // 
            this.ButtonNewTicket.Location = new System.Drawing.Point(382, 225);
            this.ButtonNewTicket.Name = "ButtonNewTicket";
            this.ButtonNewTicket.Size = new System.Drawing.Size(112, 23);
            this.ButtonNewTicket.TabIndex = 13;
            this.ButtonNewTicket.Text = "New Ticket";
            this.ButtonNewTicket.UseVisualStyleBackColor = true;
            this.ButtonNewTicket.Click += new System.EventHandler(this.ButtonNewTicket_Click);
            // 
            // CreateTicketMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.ButtonNewTicket);
            this.Controls.Add(this.RadioPri5);
            this.Controls.Add(this.RadioPri4);
            this.Controls.Add(this.RadioPri3);
            this.Controls.Add(this.RadioPri2);
            this.Controls.Add(this.RadioPri1);
            this.Controls.Add(this.ButtonReturnMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextDesc);
            this.Controls.Add(this.TextName);
            this.Name = "CreateTicketMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateTicketMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextDesc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource codeHogDataSetBindingSource;
        private CodeHogDataSet codeHogDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private CodeHogDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonReturnMain;
        private System.Windows.Forms.RadioButton RadioPri1;
        private System.Windows.Forms.RadioButton RadioPri2;
        private System.Windows.Forms.RadioButton RadioPri3;
        private System.Windows.Forms.RadioButton RadioPri4;
        private System.Windows.Forms.RadioButton RadioPri5;
        private System.Windows.Forms.Button ButtonNewTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TicketArchiveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketReporter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDescriptionDataGridViewTextBoxColumn;
    }
}