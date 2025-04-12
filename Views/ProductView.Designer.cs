namespace Supermarket_mvp.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            panel1 = new Panel();
            LblProduct = new Label();
            PictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            TabPageProductList = new TabPage();
            tabPage2 = new TabPage();
            TxtSearch = new TextBox();
            label1 = new Label();
            BtnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            TabPageProductList.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PictureBox1);
            panel1.Controls.Add(LblProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 114);
            panel1.TabIndex = 0;
            // 
            // LblProduct
            // 
            LblProduct.AutoSize = true;
            LblProduct.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LblProduct.Location = new Point(310, 38);
            LblProduct.Name = "LblProduct";
            LblProduct.Size = new Size(93, 30);
            LblProduct.TabIndex = 1;
            LblProduct.Text = "Product";
            LblProduct.TextAlign = ContentAlignment.TopCenter;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(218, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(86, 70);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 2;
            PictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPageProductList);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 114);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 447);
            tabControl1.TabIndex = 1;
            // 
            // TabPageProductList
            // 
            TabPageProductList.Controls.Add(BtnSearch);
            TabPageProductList.Controls.Add(label1);
            TabPageProductList.Controls.Add(TxtSearch);
            TabPageProductList.Location = new Point(4, 24);
            TabPageProductList.Name = "TabPageProductList";
            TabPageProductList.Padding = new Padding(3);
            TabPageProductList.Size = new Size(776, 419);
            TabPageProductList.TabIndex = 0;
            TabPageProductList.Text = "Product List";
            TabPageProductList.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(776, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(23, 39);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Search Product...";
            TxtSearch.Size = new Size(349, 23);
            TxtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnSearch
            // 
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(378, 15);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(46, 47);
            BtnSearch.TabIndex = 3;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            TabPageProductList.ResumeLayout(false);
            TabPageProductList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LblProduct;
        private PictureBox PictureBox1;
        private TabControl tabControl1;
        private TabPage TabPageProductList;
        private TextBox TxtSearch;
        private TabPage tabPage2;
        private Button BtnSearch;
        private Label label1;
    }
}