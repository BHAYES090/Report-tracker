using System;

namespace TRACKERUI
{
    partial class CREATEREPORTFORM
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
            this.components = new System.ComponentModel.Container();
            this.HEADERLABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateDateValue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UserNameValue = new System.Windows.Forms.TextBox();
            this.EmailAddressValue = new System.Windows.Forms.TextBox();
            this.phoneNumberValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CommentBoxValue = new System.Windows.Forms.TextBox();
            this.Button1CreateReport = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PictureBoxValue = new System.Windows.Forms.PictureBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
           
            this.interReportTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interReportTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HEADERLABEL
            // 
            this.HEADERLABEL.AutoSize = true;
            this.HEADERLABEL.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEADERLABEL.Location = new System.Drawing.Point(348, 39);
            this.HEADERLABEL.Name = "HEADERLABEL";
            this.HEADERLABEL.Size = new System.Drawing.Size(367, 36);
            this.HEADERLABEL.TabIndex = 0;
            this.HEADERLABEL.Text = "CREATE REPORT FORM ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATE ";
            // 
            // CreateDateValue
            // 
            this.CreateDateValue.Location = new System.Drawing.Point(433, 161);
            this.CreateDateValue.Name = "CreateDateValue";
            this.CreateDateValue.Size = new System.Drawing.Size(278, 26);
            this.CreateDateValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "USER INFORMATION ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "USERNAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "EMAIL ADDRESS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "PHONE NUMBER:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "SCREENSHOT";
            // 
            // UserNameValue
            // 
            this.UserNameValue.Location = new System.Drawing.Point(515, 257);
            this.UserNameValue.Name = "UserNameValue";
            this.UserNameValue.Size = new System.Drawing.Size(196, 26);
            this.UserNameValue.TabIndex = 8;
            //this.UserNameValue.TextChanged += new System.EventHandler(this.UserNameValue_TextChanged);
            // 
            // EmailAddressValue
            // 
            this.EmailAddressValue.Location = new System.Drawing.Point(515, 292);
            this.EmailAddressValue.Name = "EmailAddressValue";
            this.EmailAddressValue.Size = new System.Drawing.Size(196, 26);
            this.EmailAddressValue.TabIndex = 9;
            // 
            // phoneNumberValue
            // 
            this.phoneNumberValue.Location = new System.Drawing.Point(515, 335);
            this.phoneNumberValue.Name = "phoneNumberValue";
            this.phoneNumberValue.Size = new System.Drawing.Size(196, 26);
            this.phoneNumberValue.TabIndex = 10;
            this.phoneNumberValue.TextChanged += new System.EventHandler(this.PhoneNumberValue_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(933, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "COMMENTS";
            // 
            // CommentBoxValue
            // 
            this.CommentBoxValue.Location = new System.Drawing.Point(717, 185);
            this.CommentBoxValue.Multiline = true;
            this.CommentBoxValue.Name = "CommentBoxValue";
            this.CommentBoxValue.Size = new System.Drawing.Size(332, 344);
            this.CommentBoxValue.TabIndex = 13;
            // 
            // Button1CreateReport
            // 
            this.Button1CreateReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button1CreateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button1CreateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Button1CreateReport.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1CreateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button1CreateReport.Location = new System.Drawing.Point(823, 39);
            this.Button1CreateReport.Name = "Button1CreateReport";
            this.Button1CreateReport.Size = new System.Drawing.Size(226, 76);
            this.Button1CreateReport.TabIndex = 14;
            this.Button1CreateReport.Text = "CREATE REPORT";
            this.Button1CreateReport.UseVisualStyleBackColor = true;
            this.Button1CreateReport.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(386, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "ADMIN/HELPDESK INROMATION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(377, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(311, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "ADMIN AND HELP DESK INFORMATION GOES HERE ";
            // 
            // PictureBoxValue
            // 
            this.PictureBoxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxValue.Location = new System.Drawing.Point(16, 118);
            this.PictureBoxValue.Name = "PictureBoxValue";
            this.PictureBoxValue.Size = new System.Drawing.Size(324, 292);
            this.PictureBoxValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxValue.TabIndex = 17;
            this.PictureBoxValue.TabStop = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BrowseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BrowseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BrowseButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BrowseButton.Location = new System.Drawing.Point(37, 476);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(105, 44);
            this.BrowseButton.TabIndex = 18;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SelectImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.SelectImageButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SelectImageButton.Location = new System.Drawing.Point(206, 476);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(105, 44);
            this.SelectImageButton.TabIndex = 20;
            this.SelectImageButton.Text = "Select";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "File Name:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(13, 446);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(15, 17);
            this.lblFileName.TabIndex = 23;
            this.lblFileName.Text = "?";

            this.interReportTableBindingSource.DataMember = "InterReportTable";

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 541);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SelectImageButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PictureBoxValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Button1CreateReport);
            this.Controls.Add(this.CommentBoxValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneNumberValue);
            this.Controls.Add(this.EmailAddressValue);
            this.Controls.Add(this.UserNameValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateDateValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HEADERLABEL);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CREATEREPORTFORM";
            this.Text = "CREATE REPORT FORM ";
            //this.Load += new System.EventHandler(this.CREATEREPORTFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxValue)).EndInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.interReportTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PhoneNumberValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label HEADERLABEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker CreateDateValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserNameValue;
        private System.Windows.Forms.TextBox EmailAddressValue;
        private System.Windows.Forms.TextBox phoneNumberValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CommentBoxValue;
        private System.Windows.Forms.Button Button1CreateReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox PictureBoxValue;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFileName;
     //   private REPORTSSQLDataSet rEPORTSSQLDataSet;
        private System.Windows.Forms.BindingSource interReportTableBindingSource;
       // private REPORTSSQLDataSetTableAdapters.InterReportTableTableAdapter interReportTableTableAdapter;
        //private REPORTSSQLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

