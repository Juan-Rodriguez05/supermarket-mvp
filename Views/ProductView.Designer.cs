
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
            PictureBox1 = new PictureBox();
            LblProduct = new Label();
            tabControl1 = new TabControl();
            TabPageProductList = new TabPage();
            BtnSearch = new Button();
            label1 = new Label();
            TxtSearch = new TextBox();
            TabPageProductDetail = new TabPage();
            DgProduct = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label2 = new Label();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            label4 = new Label();
            TxTProductPrice = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            TxTProductCategory = new TextBox();
            label6 = new Label();
            TxtProductStock = new TextBox();
            label7 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            TabPageProductList.SuspendLayout();
            TabPageProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(PictureBox1);
            panel1.Controls.Add(LblProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 114);
            panel1.TabIndex = 0;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPageProductList);
            tabControl1.Controls.Add(TabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 114);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 447);
            tabControl1.TabIndex = 1;
            // 
            // TabPageProductList
            // 
            TabPageProductList.Controls.Add(BtnClose);
            TabPageProductList.Controls.Add(BtnDelete);
            TabPageProductList.Controls.Add(BtnEdit);
            TabPageProductList.Controls.Add(BtnNew);
            TabPageProductList.Controls.Add(DgProduct);
            TabPageProductList.Controls.Add(BtnSearch);
            TabPageProductList.Controls.Add(label1);
            TabPageProductList.Controls.Add(TxtSearch);
            TabPageProductList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabPageProductList.ForeColor = Color.Red;
            TabPageProductList.Location = new Point(4, 24);
            TabPageProductList.Name = "TabPageProductList";
            TabPageProductList.Padding = new Padding(3);
            TabPageProductList.Size = new Size(776, 419);
            TabPageProductList.TabIndex = 0;
            TabPageProductList.Text = "Product List";
            TabPageProductList.UseVisualStyleBackColor = true;
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
            // TxtSearch
            // 
            TxtSearch.Location = new Point(23, 39);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Search Product...";
            TxtSearch.Size = new Size(349, 23);
            TxtSearch.TabIndex = 0;
            // 
            // TabPageProductDetail
            // 
            TabPageProductDetail.BackColor = Color.Transparent;
            TabPageProductDetail.Controls.Add(BtnCancel);
            TabPageProductDetail.Controls.Add(BtnSave);
            TabPageProductDetail.Controls.Add(textBox1);
            TabPageProductDetail.Controls.Add(label5);
            TabPageProductDetail.Controls.Add(TxTProductCategory);
            TabPageProductDetail.Controls.Add(label6);
            TabPageProductDetail.Controls.Add(TxtProductStock);
            TabPageProductDetail.Controls.Add(label7);
            TabPageProductDetail.Controls.Add(TxTProductPrice);
            TabPageProductDetail.Controls.Add(label3);
            TabPageProductDetail.Controls.Add(TxtProductName);
            TabPageProductDetail.Controls.Add(label4);
            TabPageProductDetail.Controls.Add(TxtProductId);
            TabPageProductDetail.Controls.Add(label2);
            TabPageProductDetail.Location = new Point(4, 24);
            TabPageProductDetail.Name = "TabPageProductDetail";
            TabPageProductDetail.Padding = new Padding(3);
            TabPageProductDetail.Size = new Size(776, 419);
            TabPageProductDetail.TabIndex = 1;
            TabPageProductDetail.Text = "Product Detail";
            // 
            // DgProduct
            // 
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(23, 68);
            DgProduct.Name = "DgProduct";
            DgProduct.Size = new Size(576, 343);
            DgProduct.TabIndex = 4;
            // 
            // BtnNew
            // 
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(642, 68);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 68);
            BtnNew.TabIndex = 5;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(642, 142);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 68);
            BtnEdit.TabIndex = 6;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(642, 216);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 68);
            BtnDelete.TabIndex = 7;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(642, 290);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 68);
            BtnClose.TabIndex = 8;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 16);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 3;
            label2.Text = "Product Id";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(24, 40);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(295, 23);
            TxtProductId.TabIndex = 4;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(24, 104);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name...";
            TxtProductName.ReadOnly = true;
            TxtProductName.Size = new Size(295, 23);
            TxtProductName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 80);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 5;
            label4.Text = "Product Name";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label3_Click;
            // 
            // TxTProductPrice
            // 
            TxTProductPrice.Location = new Point(24, 169);
            TxTProductPrice.Name = "TxTProductPrice";
            TxTProductPrice.PlaceholderText = "Product Price...";
            TxTProductPrice.ReadOnly = true;
            TxTProductPrice.Size = new Size(295, 23);
            TxTProductPrice.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 145);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 7;
            label3.Text = "Product Price";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 371);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 14;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 347);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 13;
            label5.Text = "Provider Id";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // TxTProductCategory
            // 
            TxTProductCategory.Location = new Point(24, 306);
            TxTProductCategory.Name = "TxTProductCategory";
            TxTProductCategory.PlaceholderText = "Product Category...";
            TxTProductCategory.ReadOnly = true;
            TxTProductCategory.Size = new Size(295, 23);
            TxTProductCategory.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 282);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 11;
            label6.Text = "Category Name";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(24, 242);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.ReadOnly = true;
            TxtProductStock.Size = new Size(295, 23);
            TxtProductStock.TabIndex = 10;
            TxtProductStock.Text = "0";
            TxtProductStock.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 218);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 9;
            label7.Text = "Product Stock";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnSave
            // 
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(443, 80);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(222, 111);
            BtnSave.TabIndex = 15;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += this.BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(443, 197);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(222, 111);
            BtnCancel.TabIndex = 16;
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
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
            TabPageProductDetail.ResumeLayout(false);
            TabPageProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            ResumeLayout(false);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label LblProduct;
        private PictureBox PictureBox1;
        private TabControl tabControl1;
        private TabPage TabPageProductList;
        private TextBox TxtSearch;
        private TabPage TabPageProductDetail;
        private Button BtnSearch;
        private Label label1;
        private Button BtnNew;
        private DataGridView DgProduct;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Label label2;
        private TextBox TxtProductId;
        private TextBox TxtProductName;
        private Label label4;
        private TextBox TxTProductPrice;
        private Label label3;
        private TextBox textBox1;
        private Label label5;
        private TextBox TxTProductCategory;
        private Label label6;
        private TextBox TxtProductStock;
        private Label label7;
        private Button BtnCancel;
        private Button BtnSave;
    }
}