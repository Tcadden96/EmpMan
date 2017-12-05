namespace EmpMan
{
    partial class EmpManForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.btnCreateManager = new System.Windows.Forms.Button();
            this.btnCreateWorker = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblFormControls = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(317, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(423, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Data Entry and Display for TomAlex";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblInstructions.Location = new System.Drawing.Point(58, 61);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(649, 17);
            this.lblInstructions.TabIndex = 90;
            this.lblInstructions.Text = "To add a new client, manager or employee always press the corresponding button be" +
    "low";
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Location = new System.Drawing.Point(59, 103);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(209, 17);
            this.lblControls.TabIndex = 91;
            this.lblControls.Text = "Controls for creatinga new entry";
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(62, 124);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(137, 29);
            this.btnCreateClient.TabIndex = 0;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            // 
            // btnCreateManager
            // 
            this.btnCreateManager.Location = new System.Drawing.Point(220, 124);
            this.btnCreateManager.Name = "btnCreateManager";
            this.btnCreateManager.Size = new System.Drawing.Size(137, 29);
            this.btnCreateManager.TabIndex = 1;
            this.btnCreateManager.Text = "Create Manager";
            this.btnCreateManager.UseVisualStyleBackColor = true;
            // 
            // btnCreateWorker
            // 
            this.btnCreateWorker.Location = new System.Drawing.Point(382, 124);
            this.btnCreateWorker.Name = "btnCreateWorker";
            this.btnCreateWorker.Size = new System.Drawing.Size(137, 29);
            this.btnCreateWorker.TabIndex = 2;
            this.btnCreateWorker.Text = "Create Worker";
            this.btnCreateWorker.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSearch.Location = new System.Drawing.Point(62, 191);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(850, 17);
            this.lblSearch.TabIndex = 95;
            this.lblSearch.Text = "To Find/Search, Edit/Update or Delete, enter persons ID and select the appropriat" +
    "e button at the bottom of the form";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(950, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 65);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear Form Entries";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(950, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 65);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(62, 679);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(161, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find/Display";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // lblFormControls
            // 
            this.lblFormControls.AutoSize = true;
            this.lblFormControls.Location = new System.Drawing.Point(59, 649);
            this.lblFormControls.Name = "lblFormControls";
            this.lblFormControls.Size = new System.Drawing.Size(189, 17);
            this.lblFormControls.TabIndex = 115;
            this.lblFormControls.Text = "Controls for Data Processing";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(402, 679);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit/Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(725, 679);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlClient);
            this.panel1.Controls.Add(this.lblPerson);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(66, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 413);
            this.panel1.TabIndex = 116;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblJobTitle);
            this.panel3.Controls.Add(this.txtJobTitle);
            this.panel3.Controls.Add(this.lblEmployee);
            this.panel3.Location = new System.Drawing.Point(25, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 195);
            this.panel3.TabIndex = 134;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(49, 50);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(66, 17);
            this.lblJobTitle.TabIndex = 138;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(121, 47);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.ReadOnly = true;
            this.txtJobTitle.Size = new System.Drawing.Size(376, 22);
            this.txtJobTitle.TabIndex = 10;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(28, 12);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(74, 17);
            this.lblEmployee.TabIndex = 137;
            this.lblEmployee.Text = "Employee:";
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.txtType);
            this.pnlClient.Controls.Add(this.lblType);
            this.pnlClient.Controls.Add(this.lblClient);
            this.pnlClient.Location = new System.Drawing.Point(25, 80);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(284, 100);
            this.pnlClient.TabIndex = 133;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(96, 52);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(158, 22);
            this.txtType.TabIndex = 9;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(46, 55);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 128;
            this.lblType.Text = "Type:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(28, 19);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(47, 17);
            this.lblClient.TabIndex = 127;
            this.lblClient.Text = "Client:";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(21, 16);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(57, 17);
            this.lblPerson.TabIndex = 124;
            this.lblPerson.Text = "Person:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(601, 52);
            this.dtpDOB.MaxDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(244, 22);
            this.dtpDOB.TabIndex = 5;
            this.dtpDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(501, 55);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(94, 17);
            this.lblDOB.TabIndex = 122;
            this.lblDOB.Text = "Date Of Birth:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(197, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 121;
            this.lblName.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(53, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 55);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 120;
            this.lblID.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBonus);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.lblBonus);
            this.panel2.Controls.Add(this.lblSalary);
            this.panel2.Controls.Add(this.lblManager);
            this.panel2.Location = new System.Drawing.Point(31, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 100);
            this.panel2.TabIndex = 144;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(98, 70);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.ReadOnly = true;
            this.txtBonus.Size = new System.Drawing.Size(100, 22);
            this.txtBonus.TabIndex = 12;
            this.txtBonus.Text = "$";
            this.txtBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(98, 38);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 11;
            this.txtSalary.Text = "$";
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(40, 73);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(52, 17);
            this.lblBonus.TabIndex = 146;
            this.lblBonus.Text = "Bonus:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(40, 41);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(52, 17);
            this.lblSalary.TabIndex = 145;
            this.lblSalary.Text = "Salary:";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(18, 9);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(68, 17);
            this.lblManager.TabIndex = 144;
            this.lblManager.Text = "Manager:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPay);
            this.panel4.Controls.Add(this.lblPay);
            this.panel4.Controls.Add(this.lblWorker);
            this.panel4.Location = new System.Drawing.Point(440, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 100);
            this.panel4.TabIndex = 145;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(139, 41);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(100, 22);
            this.txtPay.TabIndex = 13;
            this.txtPay.Tag = "";
            this.txtPay.Text = "$";
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(51, 41);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(81, 17);
            this.lblPay.TabIndex = 146;
            this.lblPay.Text = "Hourly Pay:";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(22, 9);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(58, 17);
            this.lblWorker.TabIndex = 145;
            this.lblWorker.Text = "Worker:";
            // 
            // EmpManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 727);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblFormControls);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCreateWorker);
            this.Controls.Add(this.btnCreateManager);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "EmpManForm";
            this.Text = "EmpMan";
            this.Load += new System.EventHandler(this.EmpManForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Button btnCreateManager;
        private System.Windows.Forms.Button btnCreateWorker;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblFormControls;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblManager;
    }
}

