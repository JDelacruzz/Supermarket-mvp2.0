﻿namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            tabPageProductDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgProductList = new DataGridView();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            TxtProductPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtProductStock = new TextBox();
            TxtProductCategoryId = new TextBox();
            BtnCancelar = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            tabPageProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProductList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 516);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 48);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(12, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 143);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 373);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(DgProductList);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 34);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 335);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(BtnCancelar);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(TxtProductCategoryId);
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Location = new Point(4, 34);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 335);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 15);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(27, 54);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(427, 31);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.informacion;
            BtnSearch.Location = new Point(472, 54);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(66, 37);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProductList
            // 
            DgProductList.AllowUserToAddRows = false;
            DgProductList.AllowUserToDeleteRows = false;
            DgProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProductList.Location = new Point(27, 94);
            DgProductList.Name = "DgProductList";
            DgProductList.ReadOnly = true;
            DgProductList.RowHeadersWidth = 62;
            DgProductList.Size = new Size(511, 225);
            DgProductList.TabIndex = 3;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(597, 270);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(112, 38);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(597, 213);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(112, 36);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(597, 152);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(112, 37);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(597, 94);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(112, 40);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(52, 43);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.PlaceholderText = "Product Id";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(197, 31);
            TxtProductId.TabIndex = 0;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(52, 130);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name";
            TxtProductName.Size = new Size(197, 31);
            TxtProductName.TabIndex = 1;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(52, 221);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.PlaceholderText = "$12345";
            TxtProductPrice.Size = new Size(197, 31);
            TxtProductPrice.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 8);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 3;
            label3.Text = "Product Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 93);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 4;
            label4.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 180);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 5;
            label5.Text = "Product Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 8);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 6;
            label6.Text = "Product Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 88);
            label7.Name = "label7";
            label7.Size = new Size(172, 25);
            label7.TabIndex = 7;
            label7.Text = "Product Category Id";
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(341, 39);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.PlaceholderText = "Product Stock";
            TxtProductStock.Size = new Size(199, 31);
            TxtProductStock.TabIndex = 8;
            // 
            // TxtProductCategoryId
            // 
            TxtProductCategoryId.Location = new Point(337, 125);
            TxtProductCategoryId.Name = "TxtProductCategoryId";
            TxtProductCategoryId.PlaceholderText = "Product Category Id";
            TxtProductCategoryId.Size = new Size(203, 31);
            TxtProductCategoryId.TabIndex = 9;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = Properties.Resources.cancel;
            BtnCancelar.Location = new Point(623, 212);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(112, 48);
            BtnCancelar.TabIndex = 11;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(457, 212);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 48);
            BtnSave.TabIndex = 10;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProductList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView DgProductList;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtProductCategoryId;
        private TextBox TxtProductStock;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProductPrice;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
        private Button BtnCancelar;
        private Button BtnSave;
    }
}