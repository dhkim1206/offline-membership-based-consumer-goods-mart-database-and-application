using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_FINAL_5532437
{
    public partial class 상품현황통계 : Form
    {
        public 상품현황통계()
        {
            InitializeComponent();
        }

        private void 상품현황통계_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PROD_REFUND' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pROD_REFUNDTableAdapter.Fill(this.dataSet1.PROD_REFUND);
            // TODO: 이 코드는 데이터를 'dataSet1.PRODUCTS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTSTableAdapter.Fill(this.dataSet1.PRODUCTS);
            // TODO: 이 코드는 데이터를 'dataSet1.ORDERD_PROD' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);
            // TODO: 이 코드는 데이터를 'dataSet1.NEWPROD' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.newprodTableAdapter1.Fill(this.dataSet1.NEWPROD);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable product = dataSet1.Tables["PRODUCTS"];
            DataRow findrow = product.Rows.Find(textBox6.Text.ToString());

            if (pRODUCTSBindingSource.Filter == "PROD_ID = '" + textBox6.Text + "'")
            {
                pRODUCTSBindingSource.RemoveFilter();
                button5.Text = "필터";
            }
            else
            {
                pRODUCTSBindingSource.Filter = "PROD_ID = '" + textBox6.Text + "'";
                button5.Text = "필터해제";
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
