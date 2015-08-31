namespace CheckInterface
{
    partial class Form1
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DollarTextBox = new System.Windows.Forms.TextBox();
            this.MemoTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.InputMemoLabel = new System.Windows.Forms.Label();
            this.InputNameLabel = new System.Windows.Forms.Label();
            this.RoutingLabel = new System.Windows.Forms.Label();
            this.AccountNumbLabel = new System.Windows.Forms.Label();
            this.SigLabel = new System.Windows.Forms.Label();
            this.MemoStringLabel = new System.Windows.Forms.Label();
            this.MemoLabel = new System.Windows.Forms.Label();
            this.SIUELabel = new System.Windows.Forms.Label();
            this.DollarsTextLabel = new System.Windows.Forms.Label();
            this.AmountStringLabel = new System.Windows.Forms.Label();
            this.InputAmountLabel = new System.Windows.Forms.Label();
            this.CheckNumbBottomLabel = new System.Windows.Forms.Label();
            this.TopRightCheckNumLabel = new System.Windows.Forms.Label();
            this.PartyPaidLabel = new System.Windows.Forms.Label();
            this.PayToLabel = new System.Windows.Forms.Label();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.NumbOfChecksLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.NumberOfChecks = new System.Windows.Forms.Label();
            this.NameFormLabel = new System.Windows.Forms.Label();
            this.DollarTopLabel = new System.Windows.Forms.Label();
            this.MemoTopLabel = new System.Windows.Forms.Label();
            this.NewCheckButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateInputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(13, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // DollarTextBox
            // 
            this.DollarTextBox.Location = new System.Drawing.Point(13, 42);
            this.DollarTextBox.Name = "DollarTextBox";
            this.DollarTextBox.Size = new System.Drawing.Size(100, 22);
            this.DollarTextBox.TabIndex = 1;
            this.DollarTextBox.TextChanged += new System.EventHandler(this.DollarTextBox_TextChanged);
            // 
            // MemoTextBox
            // 
            this.MemoTextBox.Location = new System.Drawing.Point(13, 71);
            this.MemoTextBox.Name = "MemoTextBox";
            this.MemoTextBox.Size = new System.Drawing.Size(100, 22);
            this.MemoTextBox.TabIndex = 2;
            this.MemoTextBox.TextChanged += new System.EventHandler(this.MemoTextBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 99);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(205, 31);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Add Above Info To Check";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(13, 136);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.DateInputLabel);
            this.splitContainer1.Panel1.Controls.Add(this.InputMemoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.InputNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.RoutingLabel);
            this.splitContainer1.Panel1.Controls.Add(this.AccountNumbLabel);
            this.splitContainer1.Panel1.Controls.Add(this.SigLabel);
            this.splitContainer1.Panel1.Controls.Add(this.MemoStringLabel);
            this.splitContainer1.Panel1.Controls.Add(this.MemoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.SIUELabel);
            this.splitContainer1.Panel1.Controls.Add(this.DollarsTextLabel);
            this.splitContainer1.Panel1.Controls.Add(this.AmountStringLabel);
            this.splitContainer1.Panel1.Controls.Add(this.InputAmountLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CheckNumbBottomLabel);
            this.splitContainer1.Panel1.Controls.Add(this.TopRightCheckNumLabel);
            this.splitContainer1.Panel1.Controls.Add(this.PartyPaidLabel);
            this.splitContainer1.Panel1.Controls.Add(this.PayToLabel);
            this.splitContainer1.Panel1.Controls.Add(this.ProjectLabel);
            this.splitContainer1.Panel1.Controls.Add(this.TeamLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SumLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NumbOfChecksLabel);
            this.splitContainer1.Panel2.Controls.Add(this.TotalLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NumberOfChecks);
            this.splitContainer1.Size = new System.Drawing.Size(627, 285);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 4;
            // 
            // InputMemoLabel
            // 
            this.InputMemoLabel.AutoSize = true;
            this.InputMemoLabel.Location = new System.Drawing.Point(67, 166);
            this.InputMemoLabel.Name = "InputMemoLabel";
            this.InputMemoLabel.Size = new System.Drawing.Size(0, 17);
            this.InputMemoLabel.TabIndex = 16;
            // 
            // InputNameLabel
            // 
            this.InputNameLabel.AutoSize = true;
            this.InputNameLabel.Location = new System.Drawing.Point(83, 70);
            this.InputNameLabel.Name = "InputNameLabel";
            this.InputNameLabel.Size = new System.Drawing.Size(0, 17);
            this.InputNameLabel.TabIndex = 15;
            // 
            // RoutingLabel
            // 
            this.RoutingLabel.AutoSize = true;
            this.RoutingLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoutingLabel.Location = new System.Drawing.Point(20, 193);
            this.RoutingLabel.Name = "RoutingLabel";
            this.RoutingLabel.Size = new System.Drawing.Size(81, 16);
            this.RoutingLabel.TabIndex = 14;
            this.RoutingLabel.Text = "|: 123456789";
            // 
            // AccountNumbLabel
            // 
            this.AccountNumbLabel.AutoSize = true;
            this.AccountNumbLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumbLabel.Location = new System.Drawing.Point(107, 193);
            this.AccountNumbLabel.Name = "AccountNumbLabel";
            this.AccountNumbLabel.Size = new System.Drawing.Size(106, 16);
            this.AccountNumbLabel.TabIndex = 13;
            this.AccountNumbLabel.Text = "|:  325001033631";
            // 
            // SigLabel
            // 
            this.SigLabel.AutoSize = true;
            this.SigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigLabel.Location = new System.Drawing.Point(369, 166);
            this.SigLabel.Name = "SigLabel";
            this.SigLabel.Size = new System.Drawing.Size(241, 17);
            this.SigLabel.TabIndex = 12;
            this.SigLabel.Text = "___________// VOID //___________";
            // 
            // MemoStringLabel
            // 
            this.MemoStringLabel.AutoSize = true;
            this.MemoStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoStringLabel.Location = new System.Drawing.Point(57, 167);
            this.MemoStringLabel.Name = "MemoStringLabel";
            this.MemoStringLabel.Size = new System.Drawing.Size(200, 17);
            this.MemoStringLabel.TabIndex = 11;
            this.MemoStringLabel.Text = "________________________";
            // 
            // MemoLabel
            // 
            this.MemoLabel.AutoSize = true;
            this.MemoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoLabel.Location = new System.Drawing.Point(15, 172);
            this.MemoLabel.Name = "MemoLabel";
            this.MemoLabel.Size = new System.Drawing.Size(36, 12);
            this.MemoLabel.TabIndex = 10;
            this.MemoLabel.Text = "MEMO";
            // 
            // SIUELabel
            // 
            this.SIUELabel.AutoSize = true;
            this.SIUELabel.Location = new System.Drawing.Point(16, 119);
            this.SIUELabel.Name = "SIUELabel";
            this.SIUELabel.Size = new System.Drawing.Size(256, 17);
            this.SIUELabel.TabIndex = 9;
            this.SIUELabel.Text = "Southern Illinois University Edwardsville";
            // 
            // DollarsTextLabel
            // 
            this.DollarsTextLabel.AutoSize = true;
            this.DollarsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarsTextLabel.Location = new System.Drawing.Point(483, 103);
            this.DollarsTextLabel.Name = "DollarsTextLabel";
            this.DollarsTextLabel.Size = new System.Drawing.Size(49, 12);
            this.DollarsTextLabel.TabIndex = 8;
            this.DollarsTextLabel.Text = "DOLLARS";
            // 
            // AmountStringLabel
            // 
            this.AmountStringLabel.AutoSize = true;
            this.AmountStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountStringLabel.Location = new System.Drawing.Point(13, 98);
            this.AmountStringLabel.Name = "AmountStringLabel";
            this.AmountStringLabel.Size = new System.Drawing.Size(464, 17);
            this.AmountStringLabel.TabIndex = 7;
            this.AmountStringLabel.Text = "_________________________________________________________";
            // 
            // InputAmountLabel
            // 
            this.InputAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputAmountLabel.Location = new System.Drawing.Point(468, 76);
            this.InputAmountLabel.Name = "InputAmountLabel";
            this.InputAmountLabel.Size = new System.Drawing.Size(100, 19);
            this.InputAmountLabel.TabIndex = 6;
            // 
            // CheckNumbBottomLabel
            // 
            this.CheckNumbBottomLabel.AutoSize = true;
            this.CheckNumbBottomLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumbBottomLabel.Location = new System.Drawing.Point(236, 193);
            this.CheckNumbBottomLabel.Name = "CheckNumbBottomLabel";
            this.CheckNumbBottomLabel.Size = new System.Drawing.Size(36, 16);
            this.CheckNumbBottomLabel.TabIndex = 5;
            this.CheckNumbBottomLabel.Text = "3002";
            // 
            // TopRightCheckNumLabel
            // 
            this.TopRightCheckNumLabel.AutoSize = true;
            this.TopRightCheckNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRightCheckNumLabel.Location = new System.Drawing.Point(549, 14);
            this.TopRightCheckNumLabel.Name = "TopRightCheckNumLabel";
            this.TopRightCheckNumLabel.Size = new System.Drawing.Size(45, 20);
            this.TopRightCheckNumLabel.TabIndex = 4;
            this.TopRightCheckNumLabel.Text = "3002";
            // 
            // PartyPaidLabel
            // 
            this.PartyPaidLabel.AutoSize = true;
            this.PartyPaidLabel.Location = new System.Drawing.Point(73, 77);
            this.PartyPaidLabel.Name = "PartyPaidLabel";
            this.PartyPaidLabel.Size = new System.Drawing.Size(388, 17);
            this.PartyPaidLabel.TabIndex = 3;
            this.PartyPaidLabel.Text = "_____________________________________________   $";
            // 
            // PayToLabel
            // 
            this.PayToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PayToLabel.AutoSize = true;
            this.PayToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayToLabel.Location = new System.Drawing.Point(10, 70);
            this.PayToLabel.Name = "PayToLabel";
            this.PayToLabel.Size = new System.Drawing.Size(57, 24);
            this.PayToLabel.TabIndex = 2;
            this.PayToLabel.Text = "PAY TO THE\r\nORDER OF";
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(10, 25);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(96, 17);
            this.ProjectLabel.TabIndex = 1;
            this.ProjectLabel.Text = "Intro Project 1";
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Location = new System.Drawing.Point(7, 4);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(76, 17);
            this.TeamLabel.TabIndex = 0;
            this.TeamLabel.Text = "Team Djas";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(143, 28);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(36, 17);
            this.SumLabel.TabIndex = 3;
            this.SumLabel.Text = "0.00";
            // 
            // NumbOfChecksLabel
            // 
            this.NumbOfChecksLabel.AutoSize = true;
            this.NumbOfChecksLabel.Location = new System.Drawing.Point(143, 4);
            this.NumbOfChecksLabel.Name = "NumbOfChecksLabel";
            this.NumbOfChecksLabel.Size = new System.Drawing.Size(16, 17);
            this.NumbOfChecksLabel.TabIndex = 2;
            this.NumbOfChecksLabel.Text = "0";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(4, 28);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(48, 17);
            this.TotalLabel.TabIndex = 1;
            this.TotalLabel.Text = "Total: ";
            // 
            // NumberOfChecks
            // 
            this.NumberOfChecks.AutoSize = true;
            this.NumberOfChecks.Location = new System.Drawing.Point(4, 4);
            this.NumberOfChecks.Name = "NumberOfChecks";
            this.NumberOfChecks.Size = new System.Drawing.Size(132, 17);
            this.NumberOfChecks.TabIndex = 0;
            this.NumberOfChecks.Text = "Number of Checks: ";
            // 
            // NameFormLabel
            // 
            this.NameFormLabel.AutoSize = true;
            this.NameFormLabel.Location = new System.Drawing.Point(120, 13);
            this.NameFormLabel.Name = "NameFormLabel";
            this.NameFormLabel.Size = new System.Drawing.Size(45, 17);
            this.NameFormLabel.TabIndex = 5;
            this.NameFormLabel.Text = "Name";
            // 
            // DollarTopLabel
            // 
            this.DollarTopLabel.AutoSize = true;
            this.DollarTopLabel.Location = new System.Drawing.Point(120, 45);
            this.DollarTopLabel.Name = "DollarTopLabel";
            this.DollarTopLabel.Size = new System.Drawing.Size(97, 17);
            this.DollarTopLabel.TabIndex = 6;
            this.DollarTopLabel.Text = "Dollar Amount";
            // 
            // MemoTopLabel
            // 
            this.MemoTopLabel.AutoSize = true;
            this.MemoTopLabel.Location = new System.Drawing.Point(120, 74);
            this.MemoTopLabel.Name = "MemoTopLabel";
            this.MemoTopLabel.Size = new System.Drawing.Size(46, 17);
            this.MemoTopLabel.TabIndex = 7;
            this.MemoTopLabel.Text = "Memo";
            // 
            // NewCheckButton
            // 
            this.NewCheckButton.Location = new System.Drawing.Point(429, 99);
            this.NewCheckButton.Name = "NewCheckButton";
            this.NewCheckButton.Size = new System.Drawing.Size(211, 31);
            this.NewCheckButton.TabIndex = 8;
            this.NewCheckButton.Text = "Submit Check";
            this.NewCheckButton.UseVisualStyleBackColor = true;
            this.NewCheckButton.Click += new System.EventHandler(this.NewCheckButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(413, 45);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 12);
            this.DateLabel.TabIndex = 17;
            this.DateLabel.Text = "DATE";
            // 
            // DateInputLabel
            // 
            this.DateInputLabel.AutoSize = true;
            this.DateInputLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInputLabel.Location = new System.Drawing.Point(449, 41);
            this.DateInputLabel.Name = "DateInputLabel";
            this.DateInputLabel.Size = new System.Drawing.Size(127, 16);
            this.DateInputLabel.TabIndex = 18;
            this.DateInputLabel.Text = "_________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 433);
            this.Controls.Add(this.NewCheckButton);
            this.Controls.Add(this.MemoTopLabel);
            this.Controls.Add(this.DollarTopLabel);
            this.Controls.Add(this.NameFormLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.MemoTextBox);
            this.Controls.Add(this.DollarTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DollarTextBox;
        private System.Windows.Forms.TextBox MemoTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label NumberOfChecks;
        private System.Windows.Forms.Label PayToLabel;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.Label PartyPaidLabel;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label NumbOfChecksLabel;
        private System.Windows.Forms.Label TopRightCheckNumLabel;
        private System.Windows.Forms.Label SIUELabel;
        private System.Windows.Forms.Label DollarsTextLabel;
        private System.Windows.Forms.Label AmountStringLabel;
        private System.Windows.Forms.Label InputAmountLabel;
        private System.Windows.Forms.Label CheckNumbBottomLabel;
        private System.Windows.Forms.Label AccountNumbLabel;
        private System.Windows.Forms.Label SigLabel;
        private System.Windows.Forms.Label MemoStringLabel;
        private System.Windows.Forms.Label MemoLabel;
        private System.Windows.Forms.Label InputMemoLabel;
        private System.Windows.Forms.Label InputNameLabel;
        private System.Windows.Forms.Label RoutingLabel;
        private System.Windows.Forms.Label NameFormLabel;
        private System.Windows.Forms.Label DollarTopLabel;
        private System.Windows.Forms.Label MemoTopLabel;
        private System.Windows.Forms.Button NewCheckButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DateInputLabel;
    }
}

