using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_FUI
{
    internal class GridDesign
    {
        static public void SetGridDesign(DataGridView Grid)
        {
            /*
                        Grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                        Grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                        Grid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                        Grid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                        Grid.EnableHeadersVisualStyles = false;
                        Grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                        Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        Grid.Font = new Font("Fixsys", 12, FontStyle.Regular);
                        Grid.AllowUserToAddRows = false;
            */
            Grid.BackgroundColor = Color.FromArgb(45, 60, 91);
            Grid.BorderStyle = BorderStyle.None;
            Grid.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 60, 91);
            Grid.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            Grid.RowsDefaultCellStyle.ForeColor = Color.White;
            Grid.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            Grid.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            Grid.GridColor = Color.SteelBlue;

            Grid.EnableHeadersVisualStyles = false;
            Grid.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            Grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            Grid.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            Grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Grid.ColumnHeadersHeight = 30;

            Grid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 61, 91);
            Grid.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            Grid.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            Grid.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            Grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Grid.RowHeadersVisible = true;
            Grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Grid.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
