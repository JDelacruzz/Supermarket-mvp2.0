namespace Supermarket_mvp.Views
{
    partial class MainView
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
            BtnCategories = new Button();
            BtnCustomers = new Button();
            BtnProduct = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtnCustomers);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 910);
            panel1.TabIndex = 0;
            // 
            // BtnCategories
            // 
            BtnCategories.BackgroundImage = Properties.Resources.clasificacion;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(-3, 583);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(240, 150);
            BtnCategories.TabIndex = 5;
            BtnCategories.UseVisualStyleBackColor = true;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackgroundImage = Properties.Resources.satisfaccion_del_consumidor;
            BtnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomers.Location = new Point(-3, 435);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(237, 142);
            BtnCustomers.TabIndex = 4;
            BtnCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnProduct
            // 
            BtnProduct.BackgroundImage = Properties.Resources.products;
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Location = new Point(-3, 287);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(237, 142);
            BtnProduct.TabIndex = 3;
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.Salirverde;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 768);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(237, 142);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(-3, 139);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(237, 142);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Initial_D__Fujiwara_Tofu_Shop___Anime_ver___Gerbe_Dumahil;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(974, 910);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnProduct;
        private Button BtnCustomers;
        private Button BtnCategories;
    }
}