namespace DoIT_IUI.PRODUCT
{
    partial class Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PRODID = new System.Windows.Forms.Label();
            this.txt_PRODID = new System.Windows.Forms.TextBox();
            this.lbl_PRODNAME = new System.Windows.Forms.Label();
            this.txt_PRODNAME = new System.Windows.Forms.TextBox();
            this.lbl_DELETE = new System.Windows.Forms.Label();
            this.cbPRO_DELETE = new System.Windows.Forms.ComboBox();
            this.GridView_PRODUCT = new System.Windows.Forms.DataGridView();
            this.btnPRO_SAVE = new System.Windows.Forms.Button();
            this.btnPRO_DELETE = new System.Windows.Forms.Button();
            this.btnPRO_SEARCH = new System.Windows.Forms.Button();
            this.btnPRO_ADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PRODUCT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕코딩", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "제품 등록";
            // 
            // lbl_PRODID
            // 
            this.lbl_PRODID.AutoSize = true;
            this.lbl_PRODID.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_PRODID.Location = new System.Drawing.Point(47, 87);
            this.lbl_PRODID.Name = "lbl_PRODID";
            this.lbl_PRODID.Size = new System.Drawing.Size(110, 21);
            this.lbl_PRODID.TabIndex = 1;
            this.lbl_PRODID.Text = "제품코드 :";
            // 
            // txt_PRODID
            // 
            this.txt_PRODID.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_PRODID.Location = new System.Drawing.Point(163, 84);
            this.txt_PRODID.Name = "txt_PRODID";
            this.txt_PRODID.Size = new System.Drawing.Size(182, 28);
            this.txt_PRODID.TabIndex = 2;
            // 
            // lbl_PRODNAME
            // 
            this.lbl_PRODNAME.AutoSize = true;
            this.lbl_PRODNAME.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_PRODNAME.Location = new System.Drawing.Point(396, 87);
            this.lbl_PRODNAME.Name = "lbl_PRODNAME";
            this.lbl_PRODNAME.Size = new System.Drawing.Size(90, 21);
            this.lbl_PRODNAME.TabIndex = 1;
            this.lbl_PRODNAME.Text = "제품명 :";
            // 
            // txt_PRODNAME
            // 
            this.txt_PRODNAME.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_PRODNAME.Location = new System.Drawing.Point(512, 84);
            this.txt_PRODNAME.Name = "txt_PRODNAME";
            this.txt_PRODNAME.Size = new System.Drawing.Size(182, 28);
            this.txt_PRODNAME.TabIndex = 2;
            // 
            // lbl_DELETE
            // 
            this.lbl_DELETE.AutoSize = true;
            this.lbl_DELETE.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_DELETE.Location = new System.Drawing.Point(741, 87);
            this.lbl_DELETE.Name = "lbl_DELETE";
            this.lbl_DELETE.Size = new System.Drawing.Size(110, 21);
            this.lbl_DELETE.TabIndex = 1;
            this.lbl_DELETE.Text = "삭제여부 :";
            // 
            // cbPRO_DELETE
            // 
            this.cbPRO_DELETE.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbPRO_DELETE.FormattingEnabled = true;
            this.cbPRO_DELETE.Items.AddRange(new object[] {
            "ALL",
            "Y",
            "N"});
            this.cbPRO_DELETE.Location = new System.Drawing.Point(870, 83);
            this.cbPRO_DELETE.Name = "cbPRO_DELETE";
            this.cbPRO_DELETE.Size = new System.Drawing.Size(167, 29);
            this.cbPRO_DELETE.TabIndex = 3;
            // 
            // GridView_PRODUCT
            // 
            this.GridView_PRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_PRODUCT.Location = new System.Drawing.Point(50, 149);
            this.GridView_PRODUCT.Name = "GridView_PRODUCT";
            this.GridView_PRODUCT.RowTemplate.Height = 23;
            this.GridView_PRODUCT.Size = new System.Drawing.Size(1195, 262);
            this.GridView_PRODUCT.TabIndex = 4;
            // 
            // btnPRO_SAVE
            // 
            this.btnPRO_SAVE.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPRO_SAVE.Location = new System.Drawing.Point(577, 441);
            this.btnPRO_SAVE.Name = "btnPRO_SAVE";
            this.btnPRO_SAVE.Size = new System.Drawing.Size(149, 50);
            this.btnPRO_SAVE.TabIndex = 5;
            this.btnPRO_SAVE.Text = "저장";
            this.btnPRO_SAVE.UseVisualStyleBackColor = true;
            this.btnPRO_SAVE.Click += new System.EventHandler(this.btnPRO_SAVE_Click);
            // 
            // btnPRO_DELETE
            // 
            this.btnPRO_DELETE.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPRO_DELETE.Location = new System.Drawing.Point(1096, 441);
            this.btnPRO_DELETE.Name = "btnPRO_DELETE";
            this.btnPRO_DELETE.Size = new System.Drawing.Size(149, 50);
            this.btnPRO_DELETE.TabIndex = 5;
            this.btnPRO_DELETE.Text = "삭제";
            this.btnPRO_DELETE.UseVisualStyleBackColor = true;
            this.btnPRO_DELETE.Click += new System.EventHandler(this.btnPRO_DELETE_Click);
            // 
            // btnPRO_SEARCH
            // 
            this.btnPRO_SEARCH.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPRO_SEARCH.Location = new System.Drawing.Point(1096, 72);
            this.btnPRO_SEARCH.Name = "btnPRO_SEARCH";
            this.btnPRO_SEARCH.Size = new System.Drawing.Size(149, 50);
            this.btnPRO_SEARCH.TabIndex = 5;
            this.btnPRO_SEARCH.Text = "조회";
            this.btnPRO_SEARCH.UseVisualStyleBackColor = true;
            this.btnPRO_SEARCH.Click += new System.EventHandler(this.btnPRO_SEARCH_Click);
            // 
            // btnPRO_ADD
            // 
            this.btnPRO_ADD.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPRO_ADD.Location = new System.Drawing.Point(51, 441);
            this.btnPRO_ADD.Name = "btnPRO_ADD";
            this.btnPRO_ADD.Size = new System.Drawing.Size(149, 50);
            this.btnPRO_ADD.TabIndex = 5;
            this.btnPRO_ADD.Text = "추가";
            this.btnPRO_ADD.UseVisualStyleBackColor = true;
            this.btnPRO_ADD.Click += new System.EventHandler(this.btnPRO_ADD_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 522);
            this.Controls.Add(this.btnPRO_ADD);
            this.Controls.Add(this.btnPRO_SEARCH);
            this.Controls.Add(this.btnPRO_DELETE);
            this.Controls.Add(this.btnPRO_SAVE);
            this.Controls.Add(this.GridView_PRODUCT);
            this.Controls.Add(this.cbPRO_DELETE);
            this.Controls.Add(this.txt_PRODNAME);
            this.Controls.Add(this.lbl_DELETE);
            this.Controls.Add(this.lbl_PRODNAME);
            this.Controls.Add(this.txt_PRODID);
            this.Controls.Add(this.lbl_PRODID);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PRODUCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PRODID;
        private System.Windows.Forms.TextBox txt_PRODID;
        private System.Windows.Forms.Label lbl_PRODNAME;
        private System.Windows.Forms.TextBox txt_PRODNAME;
        private System.Windows.Forms.Label lbl_DELETE;
        private System.Windows.Forms.ComboBox cbPRO_DELETE;
        private System.Windows.Forms.DataGridView GridView_PRODUCT;
        private System.Windows.Forms.Button btnPRO_SAVE;
        private System.Windows.Forms.Button btnPRO_DELETE;
        private System.Windows.Forms.Button btnPRO_SEARCH;
        private System.Windows.Forms.Button btnPRO_ADD;
    }
}