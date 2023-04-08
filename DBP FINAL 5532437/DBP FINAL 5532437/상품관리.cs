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
    public partial class 상품관리 : Form
    {
        public 상품관리()
        {
            InitializeComponent();
        }

        private void 상품관리_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.ORDERD_PROD' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);
            comboBox2.SelectedIndex = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seq = comboBox2.SelectedIndex.ToString();


            pRODUCTSTableAdapter.Fill(dataSet1.PRODUCTS);

            pRODUCTSBindingSource.Filter = "STOR_NAME= '" + comboBox2.SelectedItem.ToString() + "'";
        }

        private void button_review_search_Click(object sender, EventArgs e)
        {

            pRODUCTSBindingSource.AddNew();

            dataGridView1.CurrentRow.Cells[2].Value = pRODUCTSTableAdapter.fillbyseq();
            dataGridView1.CurrentRow.Cells[0].Value = dataGridView1.Rows[0].Cells[0].Value.ToString();
            MessageBox.Show("입력 창 추가 완료");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pRODUCTSBindingSource.RemoveCurrent();
            MessageBox.Show("삭제 완료");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pRODUCTSTableAdapter.Update(this.dataSet1.PRODUCTS);

            MessageBox.Show("저장 완료");
        }

        
    }
}
