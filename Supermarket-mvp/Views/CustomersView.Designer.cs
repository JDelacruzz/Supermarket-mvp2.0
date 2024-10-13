namespace Supermarket_mvp.Views
{
    partial class CustomersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersView));
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageCustomersList = new TabPage();
            BtnClose = new Button();
            DgCustomers = new DataGridView();
            BtnDelete = new Button();
            BtnSearch = new Button();
            BtnEdit = new Button();
            TxtSearch = new TextBox();
            BtnNew = new Button();
            label2 = new Label();
            tabPageCustomersDetail = new TabPage();
            TxtBirthDay = new TextBox();
            label10 = new Label();
            BtnCancelar = new Button();
            BtnSave = new Button();
            TxtCustomersEmail = new TextBox();
            TxtCustomersPhone = new TextBox();
            TxtCustomersAddress = new TextBox();
            TxtCustomersLast = new TextBox();
            TxtCustomersFirst = new TextBox();
            TxtCustomersDocument = new TextBox();
            TxtCustomersId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
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
            panel1.Size = new Size(800, 549);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Location = new Point(0, 114);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 435);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(BtnClose);
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(BtnDelete);
            tabPageCustomersList.Controls.Add(BtnSearch);
            tabPageCustomersList.Controls.Add(BtnEdit);
            tabPageCustomersList.Controls.Add(TxtSearch);
            tabPageCustomersList.Controls.Add(BtnNew);
            tabPageCustomersList.Controls.Add(label2);
            tabPageCustomersList.Location = new Point(4, 34);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(792, 397);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "Customers List";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(571, 307);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(186, 82);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(26, 69);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.RowHeadersWidth = 62;
            DgCustomers.Size = new Size(494, 320);
            DgCustomers.TabIndex = 3;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(571, 212);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(186, 82);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.informacion;
            BtnSearch.Location = new Point(404, 15);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(116, 47);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(571, 115);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(186, 82);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(30, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(368, 31);
            TxtSearch.TabIndex = 1;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(571, 15);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(186, 82);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 3);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Customers";
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(TxtBirthDay);
            tabPageCustomersDetail.Controls.Add(label10);
            tabPageCustomersDetail.Controls.Add(BtnCancelar);
            tabPageCustomersDetail.Controls.Add(BtnSave);
            tabPageCustomersDetail.Controls.Add(TxtCustomersEmail);
            tabPageCustomersDetail.Controls.Add(TxtCustomersPhone);
            tabPageCustomersDetail.Controls.Add(TxtCustomersAddress);
            tabPageCustomersDetail.Controls.Add(TxtCustomersLast);
            tabPageCustomersDetail.Controls.Add(TxtCustomersFirst);
            tabPageCustomersDetail.Controls.Add(TxtCustomersDocument);
            tabPageCustomersDetail.Controls.Add(TxtCustomersId);
            tabPageCustomersDetail.Controls.Add(label9);
            tabPageCustomersDetail.Controls.Add(label8);
            tabPageCustomersDetail.Controls.Add(label7);
            tabPageCustomersDetail.Controls.Add(label6);
            tabPageCustomersDetail.Controls.Add(label5);
            tabPageCustomersDetail.Controls.Add(label4);
            tabPageCustomersDetail.Controls.Add(label3);
            tabPageCustomersDetail.Location = new Point(4, 34);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(792, 397);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Detail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtBirthDay
            // 
            TxtBirthDay.Location = new Point(544, 21);
            TxtBirthDay.Name = "TxtBirthDay";
            TxtBirthDay.PlaceholderText = "02/13/1999";
            TxtBirthDay.Size = new Size(166, 31);
            TxtBirthDay.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(406, 24);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 16;
            label10.Text = "Birth Day";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = Properties.Resources.cancel;
            BtnCancelar.Location = new Point(572, 187);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(112, 48);
            BtnCancelar.TabIndex = 15;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(406, 187);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 48);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersEmail
            // 
            TxtCustomersEmail.Location = new Point(544, 132);
            TxtCustomersEmail.Name = "TxtCustomersEmail";
            TxtCustomersEmail.PlaceholderText = "juan@hotmail.com";
            TxtCustomersEmail.Size = new Size(166, 31);
            TxtCustomersEmail.TabIndex = 13;
            // 
            // TxtCustomersPhone
            // 
            TxtCustomersPhone.Location = new Point(544, 80);
            TxtCustomersPhone.Name = "TxtCustomersPhone";
            TxtCustomersPhone.PlaceholderText = "30000000";
            TxtCustomersPhone.Size = new Size(166, 31);
            TxtCustomersPhone.TabIndex = 12;
            // 
            // TxtCustomersAddress
            // 
            TxtCustomersAddress.Location = new Point(173, 226);
            TxtCustomersAddress.Name = "TxtCustomersAddress";
            TxtCustomersAddress.PlaceholderText = "Carrera 1 #4-56";
            TxtCustomersAddress.Size = new Size(168, 31);
            TxtCustomersAddress.TabIndex = 11;
            // 
            // TxtCustomersLast
            // 
            TxtCustomersLast.Location = new Point(173, 167);
            TxtCustomersLast.Name = "TxtCustomersLast";
            TxtCustomersLast.PlaceholderText = "Varela";
            TxtCustomersLast.Size = new Size(168, 31);
            TxtCustomersLast.TabIndex = 10;
            // 
            // TxtCustomersFirst
            // 
            TxtCustomersFirst.Location = new Point(173, 117);
            TxtCustomersFirst.Name = "TxtCustomersFirst";
            TxtCustomersFirst.PlaceholderText = "Sam";
            TxtCustomersFirst.Size = new Size(168, 31);
            TxtCustomersFirst.TabIndex = 9;
            // 
            // TxtCustomersDocument
            // 
            TxtCustomersDocument.Location = new Point(173, 74);
            TxtCustomersDocument.Name = "TxtCustomersDocument";
            TxtCustomersDocument.PlaceholderText = "10087234";
            TxtCustomersDocument.Size = new Size(168, 31);
            TxtCustomersDocument.TabIndex = 8;
            // 
            // TxtCustomersId
            // 
            TxtCustomersId.Location = new Point(173, 32);
            TxtCustomersId.Name = "TxtCustomersId";
            TxtCustomersId.PlaceholderText = "0";
            TxtCustomersId.ReadOnly = true;
            TxtCustomersId.Size = new Size(168, 31);
            TxtCustomersId.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(411, 135);
            label9.Name = "label9";
            label9.Size = new Size(54, 25);
            label9.TabIndex = 6;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(406, 80);
            label8.Name = "label8";
            label8.Size = new Size(132, 25);
            label8.TabIndex = 5;
            label8.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 226);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 4;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 167);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 3;
            label6.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 117);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 2;
            label5.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 74);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 1;
            label4.Text = "Document";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 24);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 0;
            label3.Text = "Id Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.satisfaccion_del_consumidor;
            pictureBox1.Location = new Point(12, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 45);
            label1.Name = "label1";
            label1.Size = new Size(143, 38);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 545);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "Customers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageCustomersDetail;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView DgCustomers;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label4;
        private Label label3;
        private TextBox TxtCustomersEmail;
        private TextBox TxtCustomersPhone;
        private TextBox TxtCustomersAddress;
        private TextBox TxtCustomersLast;
        private TextBox TxtCustomersFirst;
        private TextBox TxtCustomersDocument;
        private TextBox TxtCustomersId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button BtnCancelar;
        private Button BtnSave;
        private TextBox TxtBirthDay;
        private Label label10;
    }
}