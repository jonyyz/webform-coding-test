namespace InitechSupportManagerUI
{
    partial class MainForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogEmail = new System.Windows.Forms.Button();
            this.btnLogCall = new System.Windows.Forms.Button();
            this.dgvInteractions = new System.Windows.Forms.DataGridView();
            this.hdrReceiveDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrRespondedTo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(800, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select Customer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditCustomer);
            this.panel1.Controls.Add(this.cboCustomer);
            this.panel1.Controls.Add(this.btnAddNewCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 1;
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(12, 14);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(776, 21);
            this.cboCustomer.TabIndex = 0;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.AutoSize = true;
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewCustomer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(12, 41);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(140, 27);
            this.btnAddNewCustomer.TabIndex = 1;
            this.btnAddNewCustomer.Text = "Add &New Customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interactions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogEmail);
            this.panel2.Controls.Add(this.btnLogCall);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 4;
            // 
            // btnLogEmail
            // 
            this.btnLogEmail.AutoSize = true;
            this.btnLogEmail.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogEmail.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnLogEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogEmail.ForeColor = System.Drawing.Color.White;
            this.btnLogEmail.Location = new System.Drawing.Point(166, 11);
            this.btnLogEmail.Name = "btnLogEmail";
            this.btnLogEmail.Size = new System.Drawing.Size(139, 27);
            this.btnLogEmail.TabIndex = 1;
            this.btnLogEmail.Text = "Log &Email";
            this.btnLogEmail.UseVisualStyleBackColor = false;
            this.btnLogEmail.Click += new System.EventHandler(this.btnLogEmail_Click);
            // 
            // btnLogCall
            // 
            this.btnLogCall.AutoSize = true;
            this.btnLogCall.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogCall.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogCall.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogCall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnLogCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogCall.ForeColor = System.Drawing.Color.White;
            this.btnLogCall.Location = new System.Drawing.Point(12, 11);
            this.btnLogCall.Name = "btnLogCall";
            this.btnLogCall.Size = new System.Drawing.Size(139, 27);
            this.btnLogCall.TabIndex = 0;
            this.btnLogCall.Text = "Log &Call/Voicemail";
            this.btnLogCall.UseVisualStyleBackColor = false;
            this.btnLogCall.Click += new System.EventHandler(this.btnLogCall_Click);
            // 
            // dgvInteractions
            // 
            this.dgvInteractions.AllowUserToAddRows = false;
            this.dgvInteractions.AllowUserToDeleteRows = false;
            this.dgvInteractions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInteractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteractions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hdrReceiveDateTime,
            this.hdrType,
            this.hdrContactName,
            this.hdrRespondedTo});
            this.dgvInteractions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInteractions.Location = new System.Drawing.Point(0, 116);
            this.dgvInteractions.MultiSelect = false;
            this.dgvInteractions.Name = "dgvInteractions";
            this.dgvInteractions.ReadOnly = true;
            this.dgvInteractions.RowHeadersVisible = false;
            this.dgvInteractions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInteractions.Size = new System.Drawing.Size(800, 284);
            this.dgvInteractions.TabIndex = 3;
            this.dgvInteractions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInteractions_CellDoubleClick);
            // 
            // hdrReceiveDateTime
            // 
            this.hdrReceiveDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hdrReceiveDateTime.HeaderText = "Receive Date/Time";
            this.hdrReceiveDateTime.Name = "hdrReceiveDateTime";
            this.hdrReceiveDateTime.ReadOnly = true;
            this.hdrReceiveDateTime.Width = 115;
            // 
            // hdrType
            // 
            this.hdrType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hdrType.HeaderText = "Type";
            this.hdrType.Name = "hdrType";
            this.hdrType.ReadOnly = true;
            this.hdrType.Width = 56;
            // 
            // hdrContactName
            // 
            this.hdrContactName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hdrContactName.HeaderText = "ContactName";
            this.hdrContactName.Name = "hdrContactName";
            this.hdrContactName.ReadOnly = true;
            // 
            // hdrRespondedTo
            // 
            this.hdrRespondedTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hdrRespondedTo.HeaderText = "Responded To";
            this.hdrRespondedTo.Name = "hdrRespondedTo";
            this.hdrRespondedTo.ReadOnly = true;
            this.hdrRespondedTo.Width = 76;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.AutoSize = true;
            this.btnEditCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditCustomer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEditCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Location = new System.Drawing.Point(166, 41);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(140, 27);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "E&dit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInteractions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initech Support Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogEmail;
        private System.Windows.Forms.Button btnLogCall;
        private System.Windows.Forms.DataGridView dgvInteractions;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrReceiveDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrType;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrContactName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hdrRespondedTo;
        private System.Windows.Forms.Button btnEditCustomer;
    }
}

