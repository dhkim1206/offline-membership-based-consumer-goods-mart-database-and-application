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
    public partial class 고객관리 : Form
    {
        public 고객관리()
        {
            InitializeComponent();
        }

        private void 고객관리_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ORDERD_PROD' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);
            // TODO: 이 코드는 데이터를 'dataSet1.USERS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.uSERSTableAdapter.Fill(this.dataSet1.USERS);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView3.CurrentRow.Cells[5].Value = "우수고객";
            uSERSTableAdapter.GOOD_USER(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("고객 등급 변경 완료");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.CurrentRow.Cells[5].Value = "불량고객";
            uSERSTableAdapter.USER_BAD(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("고객 등급 변경 완료");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            oRDERDPRODBindingSource.Filter = "USER_ID = '" + dataGridView3.CurrentRow.Cells[0].Value.ToString() + "'";
        }
    }
}
