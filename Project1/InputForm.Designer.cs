namespace Project1
{
    partial class InputForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.MemoLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.MemoTextBox = new System.Windows.Forms.TextBox();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.AmountErrorLabel = new System.Windows.Forms.Label();
            this.AddToCheckButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MemoErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(21, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Pay To:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(12, 87);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(63, 16);
            this.AmountLabel.TabIndex = 1;
            this.AmountLabel.Text = "Amount:";
            // 
            // MemoLabel
            // 
            this.MemoLabel.AutoSize = true;
            this.MemoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoLabel.Location = new System.Drawing.Point(21, 146);
            this.MemoLabel.Name = "MemoLabel";
            this.MemoLabel.Size = new System.Drawing.Size(54, 16);
            this.MemoLabel.TabIndex = 2;
            this.MemoLabel.Text = "Memo:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(84, 28);
            this.NameTextBox.MaxLength = 40;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(175, 22);
            this.NameTextBox.TabIndex = 3;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(84, 87);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(83, 20);
            this.AmountTextBox.TabIndex = 4;
            this.AmountTextBox.Text = "0.00";
            // 
            // MemoTextBox
            // 
            this.MemoTextBox.Location = new System.Drawing.Point(84, 145);
            this.MemoTextBox.MaxLength = 25;
            this.MemoTextBox.Name = "MemoTextBox";
            this.MemoTextBox.Size = new System.Drawing.Size(175, 20);
            this.MemoTextBox.TabIndex = 5;
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLabel.Location = new System.Drawing.Point(274, 31);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(161, 16);
            this.NameErrorLabel.TabIndex = 6;
            this.NameErrorLabel.Text = "* Please enter a name";
            this.NameErrorLabel.Visible = false;
            // 
            // AmountErrorLabel
            // 
            this.AmountErrorLabel.AutoSize = true;
            this.AmountErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.AmountErrorLabel.Location = new System.Drawing.Point(274, 88);
            this.AmountErrorLabel.Name = "AmountErrorLabel";
            this.AmountErrorLabel.Size = new System.Drawing.Size(181, 16);
            this.AmountErrorLabel.TabIndex = 7;
            this.AmountErrorLabel.Text = "* Please enter an amount";
            this.AmountErrorLabel.Visible = false;
            // 
            // AddToCheckButton
            // 
            this.AddToCheckButton.AutoSize = true;
            this.AddToCheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCheckButton.Location = new System.Drawing.Point(45, 196);
            this.AddToCheckButton.Name = "AddToCheckButton";
            this.AddToCheckButton.Size = new System.Drawing.Size(116, 38);
            this.AddToCheckButton.TabIndex = 8;
            this.AddToCheckButton.Text = "Add To Check";
            this.AddToCheckButton.UseVisualStyleBackColor = true;
            this.AddToCheckButton.Click += new System.EventHandler(this.AddToCheckButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(185, 196);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(116, 38);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear Entries";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MemoErrorLabel
            // 
            this.MemoErrorLabel.AutoSize = true;
            this.MemoErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.MemoErrorLabel.Location = new System.Drawing.Point(274, 145);
            this.MemoErrorLabel.Name = "MemoErrorLabel";
            this.MemoErrorLabel.Size = new System.Drawing.Size(211, 16);
            this.MemoErrorLabel.TabIndex = 11;
            this.MemoErrorLabel.Text = "* Max memo length exceeded";
            this.MemoErrorLabel.Visible = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 246);
            this.Controls.Add(this.MemoErrorLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddToCheckButton);
            this.Controls.Add(this.AmountErrorLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.MemoTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.MemoLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "InputForm";
            this.Text = "Check Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label MemoLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox MemoTextBox;
        private System.Windows.Forms.Label NameErrorLabel;
        private System.Windows.Forms.Label AmountErrorLabel;
        private System.Windows.Forms.Button AddToCheckButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label MemoErrorLabel;
    }
}

