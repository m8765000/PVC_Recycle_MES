using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoIT_IUI.PRODUCT
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            GridDesign.SetGridDesign(GridView_PRODUCT);
        }

        private void btnPRO_SEARCH_Click(object sender, EventArgs e)
        {
            DataSearch();
        }

        // PRODUCT(제품코드, 제품명, 삭제여부) 조회
        private void DataSearch()
        {
            string sel_product = $"SELECT \n" +
                     "  PRODID \n" +
                     " ,PRODNAME \n" +
                     " ,PRODUNIT \n" +
                     " ,PRODCOST \n" +
                     " ,PRODTYPE \n" +
                     " ,PRODWEIGHT \n" +
                     " ,NVL(DEL_YN, 'N') \n" +
                     " ,PRODUCTSPEED \n" +
                   "   FROM PRODUCT \n" +
                   "  WHERE 1=1 \n";

            if (!string.IsNullOrEmpty(txt_PRODID.Text))
            {
                string PRODID = txt_PRODID.Text;
                sel_product += $" AND PRODID LIKE '%{PRODID}%' \n";
            }
            if (!string.IsNullOrEmpty(txt_PRODNAME.Text))
            {
                string PRODNAME = txt_PRODNAME.Text;
                sel_product += $" AND PRODNAME LIKE '%{PRODNAME}%' \n";
            }

            if (cbPRO_DELETE.SelectedItem.ToString() != "ALL")
            {
                sel_product += $" AND NVL(DEL_YN, 'N') = '" + cbPRO_DELETE.SelectedItem.ToString() + "'";
            }

            DBconnection.DB_Connection(sel_product, GridView_PRODUCT);



            if (GridView_PRODUCT.Rows.Count > 0)
            {
                GridView_PRODUCT.Columns[0].HeaderText = "제품코드";
                GridView_PRODUCT.Columns[1].HeaderText = "제품명";
                GridView_PRODUCT.Columns[2].HeaderText = "단위";
                GridView_PRODUCT.Columns[3].HeaderText = "단가";
                GridView_PRODUCT.Columns[4].HeaderText = "타입";
                GridView_PRODUCT.Columns[5].HeaderText = "중량";
                GridView_PRODUCT.Columns[6].HeaderText = "삭제여부";
                GridView_PRODUCT.Columns[7].HeaderText = "생산속도";

                GridView_PRODUCT.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                GridView_PRODUCT.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                GridView_PRODUCT.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                GridView_PRODUCT.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GridView_PRODUCT.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GridView_PRODUCT.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GridView_PRODUCT.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GridView_PRODUCT.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            GridView_PRODUCT.Columns["PRODID"].ReadOnly = true;
        }

        // 데이터 추가
        private void btnPRO_ADD_Click(object sender, EventArgs e)
        {
            PRODUCT_INSERT prodinsert = new PRODUCT_INSERT();
            if (prodinsert.ShowDialog() == DialogResult.Yes)
            {
                DataSearch();
            }
        }

        // 데이터 저장
        private void btnPRO_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_PRODUCT.RowCount == 0) return;

                // GetChanges 함수 = 값 변경
                DataTable dtChanges = new DataTable();
                DataTable PRODUCT = (DataTable)GridView_PRODUCT.DataSource;
                dtChanges = PRODUCT.GetChanges(DataRowState.Modified);

                if (dtChanges == null) return;

                string update_query = string.Empty;

                // 수정 쿼리문
                if (dtChanges != null)
                {
                    for (int i = 0; i < dtChanges.Rows.Count; i++)
                    {
                        update_query = $"UPDATE PRODUCT SET          \n" +
                                      $" PRODNAME =     '#PRODNAME'  \n" +
                                      $",PRODUNIT =     '#PRODUNIT'  \n" +
                                      $",PRODCOST =     '#PRODCOST'   \n" +
                                      $",PRODTYPE =     '#PRODTYPE'  \n" +
                                      $",PRODWEIGHT =   '#PRODWEIGHT' \n" +
                                      $",PRODUCTSPEED = '#PRODUCTSPEED' \n" +
                                      $" WHERE PRODID = '#PRODID'";
                        // update_query에서 PRODNAME 을 #PRODNAME 으로 Replace한다
                        update_query = update_query.Replace("#PRODNAME", dtChanges.Rows[i]["PRODNAME"].ToString());
                        update_query = update_query.Replace("#PRODUNIT", dtChanges.Rows[i]["PRODUNIT"].ToString());
                        update_query = update_query.Replace("#PRODCOST", dtChanges.Rows[i]["PRODCOST"].ToString());
                        update_query = update_query.Replace("#PRODTYPE", dtChanges.Rows[i]["PRODTYPE"].ToString());
                        update_query = update_query.Replace("#PRODWEIGHT", dtChanges.Rows[i]["PRODWEIGHT"].ToString());
                        update_query = update_query.Replace("#PRODUCTSPEED", dtChanges.Rows[i]["PRODUCTSPEED"].ToString());
                        update_query = update_query.Replace("#PRODID", dtChanges.Rows[i]["PRODID"].ToString());

                        DBconnection.DB_Connection1(update_query);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataSearch();
            MessageBox.Show("수정 되었습니다.");
        }

        // 데이터 삭제
        private void btnPRO_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_PRODUCT.RowCount == 0) return;

                string delete_query = string.Empty;

                PRODUCT_DELETE proddelete = new PRODUCT_DELETE();
                if (proddelete.ShowDialog() == DialogResult.Yes)
                {
                    //수정쿼리문                        
                    delete_query = $"UPDATE PRODUCT SET          \n" +
                                          $"DEL_YN =     'Y'  \n" +
                                          $"WHERE PRODID = '" + GridView_PRODUCT.CurrentRow.Cells["PRODID"].Value.ToString() + "'";

                    DBconnection.DB_Connection1(delete_query);

                    DataSearch();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
