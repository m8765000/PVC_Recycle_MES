namespace DoIT_IUI.PRODUCT
{
    partial class PRODUCT_DELETE
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
            this.lblPRO_DELETE = new System.Windows.Forms.Label();
            this.btnPRO_DELETE_Y = new System.Windows.Forms.Button();
            this.btnPRO_DELETE_N = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPRO_DELETE
            // 
            this.lblPRO_DELETE.AutoSize = true;
            this.lblPRO_DELETE.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPRO_DELETE.Location = new System.Drawing.Point(99, 62);
            this.lblPRO_DELETE.Name = "lblPRO_DELETE";
            this.lblPRO_DELETE.Size = new System.Drawing.Size(382, 24);
            this.lblPRO_DELETE.TabIndex = 0;
            this.lblPRO_DELETE.Text = "데이터 정보를 삭제하시겠습니까?";
            // 
            // btnPRO_DELETE_Y
            // 
            this.btnPRO_DELETE_Y.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPRO_DELETE_Y.Location = new System.Drawing.Point(109, 139);
            this.btnPRO_DELETE_Y.Name = "btnPRO_DELETE_Y";
            this.btnPRO_DELETE_Y.Size = new System.Drawing.Size(143, 59);
            this.btnPRO_DELETE_Y.TabIndex = 1;
            this.btnPRO_DELETE_Y.Text = "YES";
            this.btnPRO_DELETE_Y.UseVisualStyleBackColor = true;
            this.btnPRO_DELETE_Y.Click += new System.EventHandler(this.btnPRO_DELETE_Y_Click);
            // 
            // btnPRO_DELETE_N
            // 
            this.btnPRO_DELETE_N.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPRO_DELETE_N.Location = new System.Drawing.Point(329, 139);
            this.btnPRO_DELETE_N.Name = "btnPRO_DELETE_N";
            this.btnPRO_DELETE_N.Size = new System.Drawing.Size(143, 59);
            this.btnPRO_DELETE_N.TabIndex = 1;
            this.btnPRO_DELETE_N.Text = "NO";
            this.btnPRO_DELETE_N.UseVisualStyleBackColor = true;
            this.btnPRO_DELETE_N.Click += new System.EventHandler(this.btnPRO_DELETE_N_Click);
            // 
            // PRODUCT_DELETE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 242);
            this.Controls.Add(this.btnPRO_DELETE_N);
            this.Controls.Add(this.btnPRO_DELETE_Y);
            this.Controls.Add(this.lblPRO_DELETE);
            this.Name = "PRODUCT_DELETE";
            this.Text = "PRODUCT_DELETE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPRO_DELETE;
        private System.Windows.Forms.Button btnPRO_DELETE_Y;
        private System.Windows.Forms.Button btnPRO_DELETE_N;
    }
}