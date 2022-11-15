namespace MES_FUI.Main
{
    partial class Diary
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
            this.btn_PlanSrch = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_AddPlan = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AllPlan = new System.Windows.Forms.Button();
            this.Memo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.DiarydataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiarydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PlanSrch
            // 
            this.btn_PlanSrch.Location = new System.Drawing.Point(399, 345);
            this.btn_PlanSrch.Name = "btn_PlanSrch";
            this.btn_PlanSrch.Size = new System.Drawing.Size(75, 25);
            this.btn_PlanSrch.TabIndex = 34;
            this.btn_PlanSrch.Text = "일정검색";
            this.btn_PlanSrch.UseVisualStyleBackColor = true;
            this.btn_PlanSrch.Click += new System.EventHandler(this.btn_PlanSrch_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(481, 79);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(150, 21);
            this.Title.TabIndex = 33;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("휴먼고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monthCalendar1.Location = new System.Drawing.Point(142, 79);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 32;
            // 
            // btn_AddPlan
            // 
            this.btn_AddPlan.Location = new System.Drawing.Point(471, 281);
            this.btn_AddPlan.Name = "btn_AddPlan";
            this.btn_AddPlan.Size = new System.Drawing.Size(160, 25);
            this.btn_AddPlan.TabIndex = 31;
            this.btn_AddPlan.Text = "일정추가";
            this.btn_AddPlan.UseVisualStyleBackColor = true;
            this.btn_AddPlan.Click += new System.EventHandler(this.btn_AddPlan_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "높음";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(153, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 57);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "일정중요도";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton3.Location = new System.Drawing.Point(108, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "낮음";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(59, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "보통";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "일정삭제";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_AllPlan
            // 
            this.btn_AllPlan.Location = new System.Drawing.Point(481, 345);
            this.btn_AllPlan.Name = "btn_AllPlan";
            this.btn_AllPlan.Size = new System.Drawing.Size(75, 25);
            this.btn_AllPlan.TabIndex = 41;
            this.btn_AllPlan.Text = "전체일정";
            this.btn_AllPlan.UseVisualStyleBackColor = true;
            this.btn_AllPlan.Click += new System.EventHandler(this.btn_AllPlan_Click);
            // 
            // Memo
            // 
            this.Memo.Location = new System.Drawing.Point(481, 132);
            this.Memo.Multiline = true;
            this.Memo.Name = "Memo";
            this.Memo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Memo.Size = new System.Drawing.Size(150, 122);
            this.Memo.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 344);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(397, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "일정내용";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(397, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "일정제목";
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Quit.Location = new System.Drawing.Point(562, 347);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(75, 23);
            this.btn_Quit.TabIndex = 43;
            this.btn_Quit.Text = "나가기";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // DiarydataGridView
            // 
            this.DiarydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiarydataGridView.Location = new System.Drawing.Point(70, 392);
            this.DiarydataGridView.Name = "DiarydataGridView";
            this.DiarydataGridView.RowTemplate.Height = 23;
            this.DiarydataGridView.Size = new System.Drawing.Size(661, 162);
            this.DiarydataGridView.TabIndex = 45;
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.DiarydataGridView);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_PlanSrch);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_AddPlan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AllPlan);
            this.Controls.Add(this.Memo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Diary";
            this.Text = "DIary";
            this.Load += new System.EventHandler(this.Diary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiarydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PlanSrch;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_AddPlan;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_AllPlan;
        private System.Windows.Forms.TextBox Memo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.DataGridView DiarydataGridView;
    }
}