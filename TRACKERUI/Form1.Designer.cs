namespace TRACKERUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label screenShotLabel;
            this.rEPORTSSQLDataSet = new TRACKERUI.REPORTSSQLDataSet();
            this.interReportTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interReportTableTableAdapter = new TRACKERUI.REPORTSSQLDataSetTableAdapters.InterReportTableTableAdapter();
            this.tableAdapterManager = new TRACKERUI.REPORTSSQLDataSetTableAdapters.TableAdapterManager();
            this.interReportTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.interReportTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.screenShotPictureBox = new System.Windows.Forms.PictureBox();
            this.interReportTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            screenShotLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTSSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interReportTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interReportTableBindingNavigator)).BeginInit();
            this.interReportTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenShotPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interReportTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rEPORTSSQLDataSet
            // 
            this.rEPORTSSQLDataSet.DataSetName = "REPORTSSQLDataSet";
            this.rEPORTSSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // interReportTableBindingSource
            // 
            this.interReportTableBindingSource.DataMember = "InterReportTable";
            this.interReportTableBindingSource.DataSource = this.rEPORTSSQLDataSet;
            // 
            // interReportTableTableAdapter
            // 
            this.interReportTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InterReportTableTableAdapter = this.interReportTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = TRACKERUI.REPORTSSQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // interReportTableBindingNavigator
            // 
            this.interReportTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.interReportTableBindingNavigator.BindingSource = this.interReportTableBindingSource;
            this.interReportTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.interReportTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.interReportTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.interReportTableBindingNavigatorSaveItem});
            this.interReportTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.interReportTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.interReportTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.interReportTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.interReportTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.interReportTableBindingNavigator.Name = "interReportTableBindingNavigator";
            this.interReportTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.interReportTableBindingNavigator.Size = new System.Drawing.Size(833, 25);
            this.interReportTableBindingNavigator.TabIndex = 0;
            this.interReportTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // interReportTableBindingNavigatorSaveItem
            // 
            this.interReportTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.interReportTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("interReportTableBindingNavigatorSaveItem.Image")));
            this.interReportTableBindingNavigatorSaveItem.Name = "interReportTableBindingNavigatorSaveItem";
            this.interReportTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.interReportTableBindingNavigatorSaveItem.Text = "Save Data";
            this.interReportTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.interReportTableBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(277, 113);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interReportTableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(302, 110);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // screenShotLabel
            // 
            screenShotLabel.AutoSize = true;
            screenShotLabel.Location = new System.Drawing.Point(227, 159);
            screenShotLabel.Name = "screenShotLabel";
            screenShotLabel.Size = new System.Drawing.Size(69, 13);
            screenShotLabel.TabIndex = 4;
            screenShotLabel.Text = "Screen Shot:";
            // 
            // screenShotPictureBox
            // 
            this.screenShotPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenShotPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.interReportTableBindingSource, "ScreenShot", true));
            this.screenShotPictureBox.Location = new System.Drawing.Point(302, 159);
            this.screenShotPictureBox.Name = "screenShotPictureBox";
            this.screenShotPictureBox.Size = new System.Drawing.Size(156, 132);
            this.screenShotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenShotPictureBox.TabIndex = 5;
            this.screenShotPictureBox.TabStop = false;
            // 
            // interReportTableBindingSource1
            // 
            this.interReportTableBindingSource1.DataMember = "InterReportTable";
            this.interReportTableBindingSource1.DataSource = this.rEPORTSSQLDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(screenShotLabel);
            this.Controls.Add(this.screenShotPictureBox);
            this.Controls.Add(this.interReportTableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTSSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interReportTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interReportTableBindingNavigator)).EndInit();
            this.interReportTableBindingNavigator.ResumeLayout(false);
            this.interReportTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenShotPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interReportTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private REPORTSSQLDataSet rEPORTSSQLDataSet;
        private System.Windows.Forms.BindingSource interReportTableBindingSource;
        private REPORTSSQLDataSetTableAdapters.InterReportTableTableAdapter interReportTableTableAdapter;
        private REPORTSSQLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator interReportTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton interReportTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox screenShotPictureBox;
        private System.Windows.Forms.BindingSource interReportTableBindingSource1;
    }
}