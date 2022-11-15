using MES_FUI.DB;
using MES_FUI.Main;
using MES_FUI.WorkingForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_FUI
{
    public partial class Main_Form : Form
    {
        public static string Selected_woid { get; set; }
        public static string PROCID { get; set; }
        public static string WOSTAT { get; set; }
        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Data_Load_Main_Grid1()
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            string sql = $"SELECT" +
            " WOID              " +
            " ,WOSTAT           " +
            " ,PLANDTTM         " +
            " ,WOSTDTTM         " +
            " ,WOEDDTTM         " +
            " ,PRODID           " +
            " ,PLANQTY          " +
            " ,PRODQTY          " +
            " ,PROCID           " +
            "FROM WORKORDER" ;

            DBconnection dbconnection = new DBconnection();
            DBconnection.DB_Connection(sql, Main_Grid);
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            GridDesign.SetGridDesign(Main_Grid);

            Main_Data_Load_Main_Grid1();

            if (Main_Grid.Rows.Count >= 0)
            {

                string[] header = new string[] { "작업지시코드", "제품코드", "계획수량", "생산수량", "불량수량", "완료수량", "작업하달일", "공정", "작업상태" };
                int[] SetColumnWidth_Main_Grid = new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100 };
                for (int i = 0; i < header.Length; i++)
                {
                    Main_Grid.Columns[i].HeaderText = $"{header[i]}";
                    Main_Grid.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(Main_Grid, i, SetColumnWidth_Main_Grid[i]);
                }
                Main_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                Main_Grid.ColumnHeadersHeight = 30;
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Main_Data_Load_Main_Grid1();
        }
        private void btn_Main_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현재 페이지입니다.");
        }

        private void btn_Wostart_Click(object sender, EventArgs e)
        {
            WOSTAT = Main_Grid.CurrentRow.Cells["WOSTAT"].Value.ToString();
            if (WOSTAT == "대기")
            {
                string sql = "UPDATE WORKORDER SET WOSTAT = 'WORK_P', WOSTDTTM = SYSDATE WHERE WOID = " +
                "'" + Main_Grid.CurrentRow.Cells["WOID"].Value.ToString() + "'"; // WOID를 기준으로 WOSTAT 현재 값을 변경
                DBconnection.DB_Connection1(sql);
            }
            else if (WOSTAT != "대기")
                MessageBox.Show("작업시작을 할 수 없습니다.", "INFORM", MessageBoxButtons.OK);


            Main_Data_Load_Main_Grid1();
        }
        private void btn_WoStop_Click(object sender, EventArgs e)
        {
            WOSTAT = Main_Grid.CurrentRow.Cells["WOSTAT"].Value.ToString();
            if (WOSTAT == "진행중")
            {
                string sql = "UPDATE WORKORDER SET WOSTAT = 'WORK_S' WHERE WOID = " +
                "'" + Main_Grid.CurrentRow.Cells["WOID"].Value.ToString() + "'";
                DBconnection.DB_Connection1(sql);
                Main_Data_Load_Main_Grid1();
            }
            else if (WOSTAT != "진행중")
                MessageBox.Show("중지할 수 없습니다.", "INFORM", MessageBoxButtons.OK);

            Main_Data_Load_Main_Grid1();
        }
        private void btn_Status_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Owner = this;
            status.Show();
            this.Visible = false;
        }
        private void Main_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_woid = Main_Grid.CurrentRow.Cells["WOID"].Value.ToString();
            PROCID = Main_Grid.CurrentRow.Cells["PROCID"].Value.ToString();

                if (PROCID == "C1")
                {
                    Crush1WorkingForm crush1WorkingForm = new Crush1WorkingForm();
                    crush1WorkingForm.ShowDialog();
                }
                else if (PROCID == "C2")
                {
                    Crush2WorkingForm crush2WorkingForm = new Crush2WorkingForm();
                    crush2WorkingForm.ShowDialog();
                }
                else if (PROCID == "S")
                {
                    ScrapWorkingForm scrapWorkingForm = new ScrapWorkingForm();
                    scrapWorkingForm.ShowDialog();
                }
            }
        private void btn_MoreInfo_Click(object sender, EventArgs e)
        {
            Selected_woid = Main_Grid.CurrentRow.Cells["WOID"].Value.ToString();
            PROCID = Main_Grid.CurrentRow.Cells["PROCID"].Value.ToString();
            if (Main_Grid.RowCount == 0)
            {
                MessageBox.Show("작업지시가 없습니다.", "INFORM", MessageBoxButtons.OK);
            }
            else if (Main_Grid.RowCount != 0)
            {
                Selected_woid = Main_Grid.CurrentRow.Cells["WOID"].Value.ToString();

                if (PROCID == "C1")
                {
                    Crush1WorkingForm crush1WorkingForm = new Crush1WorkingForm();
                    crush1WorkingForm.ShowDialog();
                }
                else if (PROCID == "C2")
                {
                    Crush2WorkingForm crush2WorkingForm = new Crush2WorkingForm();
                    crush2WorkingForm.ShowDialog();
                }
                else if (PROCID == "S")
                {
                    ScrapWorkingForm scrapWorkingForm = new ScrapWorkingForm();
                    scrapWorkingForm.ShowDialog();
                }
            }
        }
        private void btn_Diary_Click(object sender, EventArgs e)
        {
            Diary diary = new Diary();
            diary.Owner = this;
            diary.Show();
            this.Visible = false;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
