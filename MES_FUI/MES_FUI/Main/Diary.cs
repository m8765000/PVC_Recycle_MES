using MES_FUI.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_FUI.Main
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }
        private void Diary_Load(object sender, EventArgs e)
        {
            GridDesign.SetGridDesign(DiarydataGridView);
            Diary_Data_Load_dataGridView();

            if (DiarydataGridView.Rows.Count >= 0)
            {

                string[] header = new string[] { "일정일자", "일정제목", "일정내용", "일정중요도" };
                int[] SetColumnWidth_Main_Grid1 = new int[] { 100, 100, 100, 100 };
                for (int i = 0; i < header.Length; i++)
                {
                    DiarydataGridView.Columns[i].HeaderText = $"{header[i]}";
                    DiarydataGridView.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(DiarydataGridView, i, SetColumnWidth_Main_Grid1[i]);
                }
                DiarydataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                DiarydataGridView.ColumnHeadersHeight = 30;
            }
        }
        private void Diary_Data_Load_dataGridView()
        {
            string sql = $"SELECT DTTM, TITLE, MEMO, IMP FROM PLANCALENDAR";
/*            string sql = $"SELECT" +
                "DTTM" +
                ",TITLE" +
                ",MEMO" +
                ",IMP" +
                "FROM PLANCALENDAR";*/

            DBconnection dbconnection = new DBconnection();
            DBconnection.DB_Connection(sql, DiarydataGridView);

            CalendarBolding();
        }
        private void CalendarBolding()
        {

            //굵게 표시될 날짜를 저장할 배열선언(일정개수만큼 확보)
            DateTime[] bold = new DateTime[DiarydataGridView.Rows.Count];
            int i = 0; //배열요소 접근을 위한 변수 및 초기화

            for (int j = 0; j < DiarydataGridView.Rows.Count-1; j++)
            {
                DateTime date = Convert.ToDateTime(DiarydataGridView.Rows[i].Cells[0].Value.ToString());
                bold[i++] = date;
            }

            this.monthCalendar1.BoldedDates = bold;
            //this.monthCalendar1.ForeColor = Color.Red;
        }
        private void btn_PlanSrch_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;

            string sql = $"SELECT MEMO FROM PLANCALENDAR WHERE DTTM = '{date1.ToString("yyyy-MM-dd")}'";

            DBconnection dbconnection = new DBconnection();
            DBconnection.DB_Connection(sql, DiarydataGridView);
        }

        private void btn_AllPlan_Click(object sender, EventArgs e)
        {
            Diary_Data_Load_dataGridView();

            if (DiarydataGridView.Rows.Count >= 0)
            {

                string[] header = new string[] { "일정일자", "일정제목", "일정내용", "일정중요도" };
                int[] SetColumnWidth_Main_Grid1 = new int[] { 100, 100, 100, 100 };
                for (int i = 0; i < header.Length; i++)
                {
                    DiarydataGridView.Columns[i].HeaderText = $"{header[i]}";
                    DiarydataGridView.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(DiarydataGridView, i, SetColumnWidth_Main_Grid1[i]);
                }
                DiarydataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                DiarydataGridView.ColumnHeadersHeight = 30;
            }
        }

        private void btn_AddPlan_Click(object sender, EventArgs e)
        {
            string sDTTM = this.monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"); //일정일자 
            string sTitle = this.Title.Text; //일정제목
            string sMemo = this.Memo.Text; //일정내용
            string sImp = "";

            //일정중요도
            if (this.radioButton1.Checked) sImp = this.radioButton1.Text;
            else if (this.radioButton2.Checked) sImp = this.radioButton2.Text;
            else if (this.radioButton3.Checked) sImp = this.radioButton3.Text;
            else sImp = "보통";

            string sql = $"INSERT INTO PLANCALENDAR (DTTM, TITLE, MEMO, IMP) VALUES('{sDTTM}', '{sTitle}','{sMemo}', '{sImp}')";

            DBconnection.DB_Connection1(sql);

            Diary_Data_Load_dataGridView();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Main_Form main = new Main_Form();
            main.Owner = this;
            main.Show();
            this.Visible = false;
        }
    }
}
