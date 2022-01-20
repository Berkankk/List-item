
namespace DXApplication1
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblProduct = new DevExpress.XtraEditors.LabelControl();
            this.txtProduct = new DevExpress.XtraEditors.TextEdit();
            this.lblStartDate = new DevExpress.XtraEditors.LabelControl();
            this.dtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblFinishDate = new DevExpress.XtraEditors.LabelControl();
            this.dtFinishDate = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinishDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinishDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(608, 292);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // lblProduct
            // 
            this.lblProduct.Location = new System.Drawing.Point(12, 12);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(114, 13);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Mal Kodu veya Mal Adı :";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(132, 9);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(129, 20);
            this.txtProduct.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(267, 12);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(80, 13);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Başlangıç Tarihi :";
            // 
            // dtStartDate
            // 
            this.dtStartDate.EditValue = null;
            this.dtStartDate.Location = new System.Drawing.Point(353, 9);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStartDate.Size = new System.Drawing.Size(100, 20);
            this.dtStartDate.TabIndex = 4;
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.Location = new System.Drawing.Point(459, 12);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(55, 13);
            this.lblFinishDate.TabIndex = 5;
            this.lblFinishDate.Text = "Bitiş Tarihi :";
            // 
            // dtFinishDate
            // 
            this.dtFinishDate.EditValue = null;
            this.dtFinishDate.Location = new System.Drawing.Point(520, 9);
            this.dtFinishDate.Name = "dtFinishDate";
            this.dtFinishDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinishDate.Size = new System.Drawing.Size(100, 20);
            this.dtFinishDate.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(626, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Ara";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 368);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtFinishDate);
            this.Controls.Add(this.lblFinishDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinishDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinishDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblProduct;
        private DevExpress.XtraEditors.TextEdit txtProduct;
        private DevExpress.XtraEditors.LabelControl lblStartDate;
        private DevExpress.XtraEditors.DateEdit dtStartDate;
        private DevExpress.XtraEditors.LabelControl lblFinishDate;
        private DevExpress.XtraEditors.DateEdit dtFinishDate;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

