using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_FUI.DB
{
    class DBconnection
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //    Application.SetHighDpiMode(HighDpiMode.SystemAware);
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Login());
        //}
        static public void SetGridDesign(DataGridView Grid)
        {

            //Grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //Grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //Grid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //Grid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //Grid.BackgroundColor = Color.White;
            //Grid.EnableHeadersVisualStyles = false;
            //Grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Grid.Font = new Font("Fixsys", 12, FontStyle.Regular);


            Grid.BackgroundColor = Color.FromArgb(45, 60, 91);
            Grid.BorderStyle = BorderStyle.None;
            Grid.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 60, 91);
            Grid.RowsDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            Grid.RowsDefaultCellStyle.ForeColor = Color.White;
            Grid.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            Grid.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            Grid.GridColor = Color.SteelBlue;

            Grid.EnableHeadersVisualStyles = false;
            Grid.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            Grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            Grid.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            //Grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Grid.ColumnHeadersHeight = 40;

            Grid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 61, 91);
            Grid.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            Grid.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            Grid.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            Grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Grid.RowHeadersVisible = true;
            Grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Grid.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Grid.ReadOnly = true;
            Grid.AllowUserToAddRows = false;

            Grid.RowTemplate.Height = 37;

        }

        static public void SetDesign(Form form, bool tf = true)
        {
            if (tf)
                form.BackColor = Color.FromArgb(33, 34, 74);

        }

        static public void SetColumnWidth(DataGridView dataGridView, int IndexCol, int widthCol)
        {
            dataGridView.Columns[IndexCol].Width = widthCol;

        }

        static public void DB_Connection(string sql, DataGridView gridView)
        {
            OracleDataAdapter adapter = new OracleDataAdapter(sql, DBHelper.DBconn);
            DataTable data_table = new DataTable();
            adapter.Fill(data_table);
            gridView.DataSource = data_table;
        }
        /// <summary>
        /// SELECT 전용
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        static public DataTable DB_Connection(string sql)
        {
            OracleDataAdapter adapter = new OracleDataAdapter(sql, DBHelper.DBconn);
            DataTable data_table = new DataTable();
            adapter.Fill(data_table);
            return data_table;
        }
        /// <summary>
        /// INSERT/UPDATE 전용
        /// </summary>
        /// <param name="sql"></param>
        static public void DB_Connection1(string sql)
        {
            OracleCommand cmd = new OracleCommand(sql, DBHelper.DBconn);
            cmd.ExecuteNonQuery();

            DBHelper.Close();
            cmd.Dispose();

        }
    }
}
