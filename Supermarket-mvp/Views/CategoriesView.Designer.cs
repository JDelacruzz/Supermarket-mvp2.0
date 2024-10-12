namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            tabControl1 = new TabControl();
            tabPageCategoriesList = new TabPage();
            BtnClose = new Button();
            DgCategories = new DataGridView();
            BtnDelete = new Button();
            BtnSearch = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoriesDetail = new TabPage();
            BtnCancelar = new Button();
            BtnSave = new Button();
            TxtCategoriesDescription = new TextBox();
            TxtCategoriesName = new TextBox();
            TxtCategoriesId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabPageCategoriesDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 446);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Location = new Point(0, 102);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 344);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(BtnClose);
            tabPageCategoriesList.Controls.Add(DgCategories);
            tabPageCategoriesList.Controls.Add(BtnDelete);
            tabPageCategoriesList.Controls.Add(BtnSearch);
            tabPageCategoriesList.Controls.Add(BtnEdit);
            tabPageCategoriesList.Controls.Add(BtnNew);
            tabPageCategoriesList.Controls.Add(TxtSearch);
            tabPageCategoriesList.Controls.Add(label2);
            tabPageCategoriesList.Location = new Point(4, 34);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 306);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(602, 240);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(112, 38);
            BtnClose.TabIndex = 17;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(8, 85);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowHeadersWidth = 62;
            DgCategories.Size = new Size(547, 204);
            DgCategories.TabIndex = 13;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(602, 183);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(112, 36);
            BtnDelete.TabIndex = 16;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.informacion;
            BtnSearch.Location = new Point(456, 40);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(99, 39);
            BtnSearch.TabIndex = 12;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(602, 122);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(112, 37);
            BtnEdit.TabIndex = 15;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(602, 64);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(112, 40);
            BtnNew.TabIndex = 14;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(8, 48);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(442, 31);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 20);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Mode";
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(BtnCancelar);
            tabPageCategoriesDetail.Controls.Add(BtnSave);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesDescription);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesName);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesId);
            tabPageCategoriesDetail.Controls.Add(label5);
            tabPageCategoriesDetail.Controls.Add(label4);
            tabPageCategoriesDetail.Controls.Add(label3);
            tabPageCategoriesDetail.Location = new Point(4, 34);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(792, 306);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Categories Detail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = Properties.Resources.cancel;
            BtnCancelar.Location = new Point(558, 75);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(112, 48);
            BtnCancelar.TabIndex = 15;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(392, 75);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 48);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategoriesDescription
            // 
            TxtCategoriesDescription.Location = new Point(56, 222);
            TxtCategoriesDescription.Multiline = true;
            TxtCategoriesDescription.Name = "TxtCategoriesDescription";
            TxtCategoriesDescription.PlaceholderText = "Categories Categories";
            TxtCategoriesDescription.Size = new Size(240, 66);
            TxtCategoriesDescription.TabIndex = 13;
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Location = new Point(56, 135);
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.PlaceholderText = "Categories Name";
            TxtCategoriesName.Size = new Size(233, 31);
            TxtCategoriesName.TabIndex = 12;
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(55, 54);
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.ReadOnly = true;
            TxtCategoriesId.Size = new Size(150, 31);
            TxtCategoriesId.TabIndex = 11;
            TxtCategoriesId.Text = "0";
            TxtCategoriesId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 180);
            label5.Name = "label5";
            label5.Size = new Size(185, 25);
            label5.TabIndex = 10;
            label5.Text = "Categories Categories";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 98);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 9;
            label4.Text = "Categories Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 17);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 8;
            label3.Text = "Categories Id";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clasificacion;
            pictureBox1.Location = new Point(31, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 40);
            label1.Name = "label1";
            label1.Size = new Size(155, 38);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageCategoriesDetail;
        private Button BtnClose;
        private DataGridView DgCategories;
        private Button BtnDelete;
        private Button BtnSearch;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnCancelar;
        private Button BtnSave;
        private TextBox TxtCategoriesDescription;
        private TextBox TxtCategoriesName;
        private TextBox TxtCategoriesId;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}