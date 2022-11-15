namespace MES_FUI
{
    partial class Main_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_WoStop = new System.Windows.Forms.Button();
            this.btn_Wostart = new System.Windows.Forms.Button();
            this.btn_Diary = new System.Windows.Forms.Button();
            this.btn_MoreInfo = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Main = new System.Windows.Forms.Button();
            this.Main_Grid = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "작업지시";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(419, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // btn_WoStop
            // 
            this.btn_WoStop.Location = new System.Drawing.Point(1304, 701);
            this.btn_WoStop.Name = "btn_WoStop";
            this.btn_WoStop.Size = new System.Drawing.Size(200, 60);
            this.btn_WoStop.TabIndex = 32;
            this.btn_WoStop.Text = "작업중지";
            this.btn_WoStop.UseVisualStyleBackColor = true;
            this.btn_WoStop.Click += new System.EventHandler(this.btn_WoStop_Click);
            // 
            // btn_Wostart
            // 
            this.btn_Wostart.Location = new System.Drawing.Point(1079, 701);
            this.btn_Wostart.Name = "btn_Wostart";
            this.btn_Wostart.Size = new System.Drawing.Size(200, 60);
            this.btn_Wostart.TabIndex = 31;
            this.btn_Wostart.Text = "작업시작";
            this.btn_Wostart.UseVisualStyleBackColor = true;
            this.btn_Wostart.Click += new System.EventHandler(this.btn_Wostart_Click);
            // 
            // btn_Diary
            // 
            this.btn_Diary.Location = new System.Drawing.Point(12, 408);
            this.btn_Diary.Name = "btn_Diary";
            this.btn_Diary.Size = new System.Drawing.Size(180, 120);
            this.btn_Diary.TabIndex = 30;
            this.btn_Diary.Text = "일지";
            this.btn_Diary.UseVisualStyleBackColor = true;
            this.btn_Diary.Click += new System.EventHandler(this.btn_Diary_Click);
            // 
            // btn_MoreInfo
            // 
            this.btn_MoreInfo.Location = new System.Drawing.Point(12, 269);
            this.btn_MoreInfo.Name = "btn_MoreInfo";
            this.btn_MoreInfo.Size = new System.Drawing.Size(180, 120);
            this.btn_MoreInfo.TabIndex = 29;
            this.btn_MoreInfo.Text = "상세정보";
            this.btn_MoreInfo.UseVisualStyleBackColor = true;
            this.btn_MoreInfo.Click += new System.EventHandler(this.btn_MoreInfo_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.Location = new System.Drawing.Point(12, 132);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(180, 120);
            this.btn_Status.TabIndex = 28;
            this.btn_Status.Text = "생산현황";
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "C1 : 1차 분쇄",
            "C2 : 2차 분쇄",
            "S : 선별"});
            this.comboBox1.Location = new System.Drawing.Point(213, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 27;
            // 
            // btn_Main
            // 
            this.btn_Main.Location = new System.Drawing.Point(1438, 27);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(66, 60);
            this.btn_Main.TabIndex = 26;
            this.btn_Main.Text = "메인";
            this.btn_Main.UseVisualStyleBackColor = true;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // Main_Grid
            // 
            this.Main_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_Grid.Location = new System.Drawing.Point(209, 132);
            this.Main_Grid.Name = "Main_Grid";
            this.Main_Grid.RowTemplate.Height = 23;
            this.Main_Grid.Size = new System.Drawing.Size(1295, 537);
            this.Main_Grid.TabIndex = 25;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(340, 38);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(98, 38);
            this.btn_Search.TabIndex = 24;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 549);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(180, 120);
            this.btn_Exit.TabIndex = 36;
            this.btn_Exit.Text = "나가기";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 773);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_WoStop);
            this.Controls.Add(this.btn_Wostart);
            this.Controls.Add(this.btn_Diary);
            this.Controls.Add(this.btn_MoreInfo);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.Main_Grid);
            this.Controls.Add(this.btn_Search);
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_WoStop;
        private System.Windows.Forms.Button btn_Wostart;
        private System.Windows.Forms.Button btn_Diary;
        private System.Windows.Forms.Button btn_MoreInfo;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.DataGridView Main_Grid;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Exit;
    }
}

