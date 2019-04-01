namespace Lab8
{
    partial class Lab8
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
            this.futureLabel = new System.Windows.Forms.Label();
            this.apyLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.presentLabel = new System.Windows.Forms.Label();
            this.futureInput = new System.Windows.Forms.TextBox();
            this.apyInput = new System.Windows.Forms.TextBox();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.presentReport = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futureLabel
            // 
            this.futureLabel.AutoSize = true;
            this.futureLabel.Location = new System.Drawing.Point(12, 9);
            this.futureLabel.Name = "futureLabel";
            this.futureLabel.Size = new System.Drawing.Size(69, 13);
            this.futureLabel.TabIndex = 0;
            this.futureLabel.Text = "Future value:";
            // 
            // apyLabel
            // 
            this.apyLabel.AutoSize = true;
            this.apyLabel.Location = new System.Drawing.Point(12, 33);
            this.apyLabel.Name = "apyLabel";
            this.apyLabel.Size = new System.Drawing.Size(101, 13);
            this.apyLabel.TabIndex = 1;
            this.apyLabel.Text = "Annual interest rate:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 59);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(57, 13);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "# of years:";
            // 
            // presentLabel
            // 
            this.presentLabel.AutoSize = true;
            this.presentLabel.Location = new System.Drawing.Point(12, 85);
            this.presentLabel.Name = "presentLabel";
            this.presentLabel.Size = new System.Drawing.Size(75, 13);
            this.presentLabel.TabIndex = 3;
            this.presentLabel.Text = "Present value:";
            // 
            // futureInput
            // 
            this.futureInput.Location = new System.Drawing.Point(119, 6);
            this.futureInput.Name = "futureInput";
            this.futureInput.Size = new System.Drawing.Size(100, 20);
            this.futureInput.TabIndex = 4;
            // 
            // apyInput
            // 
            this.apyInput.Location = new System.Drawing.Point(119, 30);
            this.apyInput.Name = "apyInput";
            this.apyInput.Size = new System.Drawing.Size(100, 20);
            this.apyInput.TabIndex = 5;
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(119, 56);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(100, 20);
            this.yearInput.TabIndex = 6;
            // 
            // presentReport
            // 
            this.presentReport.Location = new System.Drawing.Point(119, 82);
            this.presentReport.Name = "presentReport";
            this.presentReport.ReadOnly = true;
            this.presentReport.Size = new System.Drawing.Size(100, 20);
            this.presentReport.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(73, 108);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Lab8
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 139);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.presentReport);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.apyInput);
            this.Controls.Add(this.futureInput);
            this.Controls.Add(this.presentLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.apyLabel);
            this.Controls.Add(this.futureLabel);
            this.Name = "Lab8";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureLabel;
        private System.Windows.Forms.Label apyLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label presentLabel;
        private System.Windows.Forms.TextBox futureInput;
        private System.Windows.Forms.TextBox apyInput;
        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.TextBox presentReport;
        private System.Windows.Forms.Button calculateButton;
    }
}

