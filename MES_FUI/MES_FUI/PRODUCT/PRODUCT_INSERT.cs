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
    public partial class PRODUCT_INSERT : Form
    {
        public PRODUCT_INSERT()
        {
            InitializeComponent();
        }

        private bool CHECK_INSERT_PRODUCT()
        {
            // select_query에 쿼리문을 저장
            string sel_insert_qry = $"select count(*) from PRODUCT where PRODID = '" + txtINSERT_PRODID.Text.ToString() + "'";


            // select_ID로 조회된 결과를 data_Table에 return값을 저장함
            DataTable data_Table = DBconnection.DB_Connection(sel_insert_qry);

            if (data_Table.Rows[0][0].ToString() == "1")
            {
                return false;
            }

            return true;
        }

        private void btnPRO_INSERT_SAVE_Click(object sender, EventArgs e)
        {
            if (!CHECK_INSERT_PRODUCT())
            {
                MessageBox.Show("이미 존재합니다");
                return;
            }

            if (string.IsNullOrEmpty(txtINSERT_PRONAME.Text))
            {
                MessageBox.Show("필수값이 없습니다!");
                txtINSERT_PRONAME.Focus();
                return;
            }

            string pdcode = txtINSERT_PRODID.Text;
            string pdname = txtINSERT_PRONAME.Text;
            string pdcost = txtINSERT_PRODCOST.Text;
            string pdweight = txtINSERT_PRODWEIGHT.Text;
            string pdspeed = txtINSERT_PROSPEED.Text;
            string pdunit = cbINSERT_PRODUNIT.Text;
            string pdtype = cbINSERT_PRODTYPE.Text;

            string sql = $"INSERT INTO PRODUCT(PRODID, PRODNAME, PRODCOST, PRODWEIGHT, PRODSPEED, PRODUNIT, PRODTYPE) " +
                $"VALUES('{pdcode}', '{pdname}', '{pdcost}', '{pdweight}', '{pdspeed}', '{pdunit}', '{pdtype}')";

            DBconnection.DB_Connection1(sql);
            DialogResult = DialogResult.Yes;
            MessageBox.Show("등록 되었습니다.");
            Close();
        }

        private void btnPRO_INSERT_CANCEL_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
