namespace TRACKERUI
{
    partial class REPORTVIEWERFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPORTVIEWERFORM));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BUTTON = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ReportNameValue = new System.Windows.Forms.TextBox();
            this.ReportIDValue = new System.Windows.Forms.TextBox();
            this.SeverityValue = new System.Windows.Forms.TextBox();
            this.ReportStatusValue = new System.Windows.Forms.TextBox();
            this.FirstReporterValue = new System.Windows.Forms.TextBox();
            this.Solutionvalue = new System.Windows.Forms.TextBox();
            this.CommentValue = new System.Windows.Forms.TextBox();
            this.BugBehaviorValue = new System.Windows.Forms.TextBox();
            this.DetailsValue = new System.Windows.Forms.TextBox();
            this.DateFirstReportedValue = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORT: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "REPORT ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(47, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "SEVERITY: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "REPORT STATUS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "DETAILS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "BUG BEHAVIOR";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(870, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "FIRST REPORTER:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(803, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "DATE FIRST REPORTED:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(637, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "COMMENTS";
            // 
            // BUTTON
            // 
            this.BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BUTTON.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BUTTON.Location = new System.Drawing.Point(505, 54);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(248, 62);
            this.BUTTON.TabIndex = 12;
            this.BUTTON.Text = "CREATE REPORT";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.BUTTON_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(953, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "SOLUTIONS";
            // 
            // ReportNameValue
            // 
            this.ReportNameValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportNameValue.Location = new System.Drawing.Point(248, 6);
            this.ReportNameValue.Name = "ReportNameValue";
            this.ReportNameValue.Size = new System.Drawing.Size(182, 29);
            this.ReportNameValue.TabIndex = 15;
            // 
            // ReportIDValue
            // 
            this.ReportIDValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportIDValue.Location = new System.Drawing.Point(248, 54);
            this.ReportIDValue.Name = "ReportIDValue";
            this.ReportIDValue.Size = new System.Drawing.Size(182, 29);
            this.ReportIDValue.TabIndex = 16;
            // 
            // SeverityValue
            // 
            this.SeverityValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeverityValue.Location = new System.Drawing.Point(248, 105);
            this.SeverityValue.Name = "SeverityValue";
            this.SeverityValue.Size = new System.Drawing.Size(182, 29);
            this.SeverityValue.TabIndex = 17;
            // 
            // ReportStatusValue
            // 
            this.ReportStatusValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportStatusValue.Location = new System.Drawing.Point(248, 155);
            this.ReportStatusValue.Name = "ReportStatusValue";
            this.ReportStatusValue.Size = new System.Drawing.Size(182, 29);
            this.ReportStatusValue.TabIndex = 18;
            // 
            // FirstReporterValue
            // 
            this.FirstReporterValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstReporterValue.Location = new System.Drawing.Point(1085, 44);
            this.FirstReporterValue.Name = "FirstReporterValue";
            this.FirstReporterValue.Size = new System.Drawing.Size(182, 29);
            this.FirstReporterValue.TabIndex = 19;
            // 
            // Solutionvalue
            // 
            this.Solutionvalue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solutionvalue.Location = new System.Drawing.Point(957, 274);
            this.Solutionvalue.Multiline = true;
            this.Solutionvalue.Name = "Solutionvalue";
            this.Solutionvalue.Size = new System.Drawing.Size(310, 292);
            this.Solutionvalue.TabIndex = 21;
            // 
            // CommentValue
            // 
            this.CommentValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentValue.Location = new System.Drawing.Point(641, 274);
            this.CommentValue.Multiline = true;
            this.CommentValue.Name = "CommentValue";
            this.CommentValue.Size = new System.Drawing.Size(310, 292);
            this.CommentValue.TabIndex = 22;
            // 
            // BugBehaviorValue
            // 
            this.BugBehaviorValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BugBehaviorValue.Location = new System.Drawing.Point(325, 274);
            this.BugBehaviorValue.Multiline = true;
            this.BugBehaviorValue.Name = "BugBehaviorValue";
            this.BugBehaviorValue.Size = new System.Drawing.Size(310, 292);
            this.BugBehaviorValue.TabIndex = 23;
            // 
            // DetailsValue
            // 
            this.DetailsValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsValue.Location = new System.Drawing.Point(9, 274);
            this.DetailsValue.Multiline = true;
            this.DetailsValue.Name = "DetailsValue";
            this.DetailsValue.Size = new System.Drawing.Size(310, 292);
            this.DetailsValue.TabIndex = 24;
            // 
            // DateFirstReportedValue
            // 
            this.DateFirstReportedValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFirstReportedValue.Location = new System.Drawing.Point(1085, 113);
            this.DateFirstReportedValue.Name = "DateFirstReportedValue";
            this.DateFirstReportedValue.Size = new System.Drawing.Size(178, 29);
            this.DateFirstReportedValue.TabIndex = 25;
            // 
            // REPORTVIEWERFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 598);
            this.Controls.Add(this.DateFirstReportedValue);
            this.Controls.Add(this.DetailsValue);
            this.Controls.Add(this.BugBehaviorValue);
            this.Controls.Add(this.CommentValue);
            this.Controls.Add(this.Solutionvalue);
            this.Controls.Add(this.FirstReporterValue);
            this.Controls.Add(this.ReportStatusValue);
            this.Controls.Add(this.SeverityValue);
            this.Controls.Add(this.ReportIDValue);
            this.Controls.Add(this.ReportNameValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BUTTON);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "REPORTVIEWERFORM";
            this.Text = "REPORT VIEWER FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ReportNameValue;
        private System.Windows.Forms.TextBox ReportIDValue;
        private System.Windows.Forms.TextBox SeverityValue;
        private System.Windows.Forms.TextBox ReportStatusValue;
        private System.Windows.Forms.TextBox FirstReporterValue;
        private System.Windows.Forms.TextBox Solutionvalue;
        private System.Windows.Forms.TextBox CommentValue;
        private System.Windows.Forms.TextBox BugBehaviorValue;
        private System.Windows.Forms.TextBox DetailsValue;
        private System.Windows.Forms.DateTimePicker DateFirstReportedValue;
    }
}