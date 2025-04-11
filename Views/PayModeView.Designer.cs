namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label1 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            paymodeobservation = new Label();
            TxtPayModeName = new TextBox();
            paymodename = new Label();
            TxtPayModeId = new TextBox();
            label31 = new Label();
            panelTop = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Location = new Point(12, 144);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 370);
            tabControl1.TabIndex = 0;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label1);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(768, 342);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnClose.BackColor = Color.White;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(473, 249);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(290, 70);
            BtnClose.TabIndex = 9;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnDelete.BackColor = Color.White;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(473, 173);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(290, 70);
            BtnDelete.TabIndex = 8;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnEdit.BackColor = Color.White;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(473, 97);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(290, 70);
            BtnEdit.TabIndex = 7;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnNew.BackColor = Color.White;
            BtnNew.FlatStyle = FlatStyle.Flat;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(472, 21);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(290, 70);
            BtnNew.TabIndex = 6;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(21, 61);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(445, 258);
            DgPayMode.TabIndex = 4;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSearch.Location = new Point(424, 14);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(42, 41);
            BtnSearch.TabIndex = 5;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(21, 32);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(397, 23);
            TxtSearch.TabIndex = 4;
            TxtSearch.Text = "Data to search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(paymodeobservation);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(paymodename);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label31);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(768, 342);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.White;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(178, 256);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(127, 70);
            BtnCancel.TabIndex = 8;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.White;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(25, 256);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(127, 70);
            BtnSave.TabIndex = 7;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.ForeColor = SystemColors.WindowFrame;
            TxtPayModeObservation.HideSelection = false;
            TxtPayModeObservation.Location = new Point(25, 166);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Enter observation";
            TxtPayModeObservation.Size = new Size(332, 75);
            TxtPayModeObservation.TabIndex = 5;
            TxtPayModeObservation.Text = "Pay Mode Observation";
            TxtPayModeObservation.TextChanged += TxtPayModeObservation_TextChanged;
            // 
            // paymodeobservation
            // 
            paymodeobservation.AutoSize = true;
            paymodeobservation.Location = new Point(25, 148);
            paymodeobservation.Name = "paymodeobservation";
            paymodeobservation.Size = new Size(127, 15);
            paymodeobservation.TabIndex = 4;
            paymodeobservation.Text = "Pay Mode Observation";
            paymodeobservation.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.ForeColor = SystemColors.WindowFrame;
            TxtPayModeName.HideSelection = false;
            TxtPayModeName.Location = new Point(25, 103);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(332, 23);
            TxtPayModeName.TabIndex = 3;
            TxtPayModeName.Text = "Pay Mode Name";
            // 
            // paymodename
            // 
            paymodename.AutoSize = true;
            paymodename.Location = new Point(25, 85);
            paymodename.Name = "paymodename";
            paymodename.Size = new Size(95, 15);
            paymodename.TabIndex = 2;
            paymodename.Text = "Pay Mode Name";
            paymodename.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(25, 44);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(201, 23);
            TxtPayModeId.TabIndex = 1;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(25, 26);
            label31.Name = "label31";
            label31.Size = new Size(73, 15);
            label31.TabIndex = 0;
            label31.Text = "Pay Mode Id";
            label31.TextAlign = ContentAlignment.TopRight;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBox2);
            panelTop.Controls.Add(label2);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(800, 138);
            panelTop.TabIndex = 1;
            panelTop.Paint += panelTop_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 56);
            label2.Name = "label2";
            label2.Size = new Size(114, 27);
            label2.TabIndex = 1;
            label2.Text = "Pay Mode";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(panelTop);
            Controls.Add(tabControl1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            Load += PayModeView_Load;
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Panel panelTop;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label31;
        private TextBox TxtPayModeName;
        private Label paymodename;
        private TextBox TxtPayModeId;
        private TextBox TxtPayModeObservation;
        private Label paymodeobservation;
        private Button BtnCancel;
        private Button BtnSave;
    }
}