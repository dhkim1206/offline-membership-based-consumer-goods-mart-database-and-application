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
    public partial class 상품판매현황 : Form
    {
        public 상품판매현황()
        {
            InitializeComponent();
        }

        private void 상품판매현황_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ORDERD_PROD' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);

            comboBox3.SelectedIndex = 0;
            oRDERDPRODBindingSource.Filter = "STOR_NAME= '" + comboBox3.SelectedItem.ToString() + "'" + "AND ORDER_OK= '구매확정'";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //가게 이름 넣기
            label6.Text = comboBox3.SelectedItem.ToString();
            this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);

            //선택한 가게로 필터링, 구매확정만 표시
            oRDERDPRODBindingSource.Filter = "STOR_NAME= '" + comboBox3.SelectedItem.ToString() + "'" + "AND ORDER_OK= '구매확정'";
            int sum = 0;
            int num = dataGridView5.Rows.Count;
            for (int i = 0; i < num; i++)
            {
                sum += int.Parse(dataGridView5.Rows[i].Cells[8].Value.ToString());
            }
            // 가게별 총 매출액 
            textBox1.Text = sum.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (monthCalendar1.SelectionRange.Start == null)
            {
                oRDERDPRODBindingSource.Filter = null;
            }

            else if (monthCalendar1.SelectionRange.Start == monthCalendar1.SelectionRange.End)
            {
                label5.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
                oRDERDPRODBindingSource.Filter = "STOR_NAME= '" + comboBox3.SelectedItem.ToString() + "'" + "AND ORDER_DATE= '" + monthCalendar1.SelectionRange.Start + "'" + "AND ORDER_OK = '구매확정'";
                int sum = 0;
                int num = dataGridView5.Rows.Count;
                for (int i = 0; i < num; i++)
                {
                    sum += int.Parse(dataGridView5.Rows[i].Cells[8].Value.ToString());
                }
                // 가게별 총 매출액 
                textBox1.Text = sum.ToString();
            }
            else
            {
                label5.Text = monthCalendar1.SelectionRange.Start.ToShortDateString() + "~" + monthCalendar1.SelectionRange.End.ToShortDateString();
                oRDERDPRODBindingSource.Filter = "STOR_NAME= '" + comboBox3.SelectedItem.ToString() + "'" + "AND ORDER_DATE >= '" + monthCalendar1.SelectionRange.Start + "'" + "AND ORDER_DATE <= ' " + monthCalendar1.SelectionRange.End + "'" + "AND ORDER_OK = '구매확정'";
                int sum = 0;
                int num = dataGridView5.Rows.Count;
                for (int i = 0; i < num; i++)
                {
                    sum += int.Parse(dataGridView5.Rows[i].Cells[8].Value.ToString());
                }
                // 가게별 총 매출액 
                textBox1.Text = sum.ToString();
            }
            
        }

        private void dataGridView5_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            //가게 이름 넣기
            label6.Text = comboBox3.SelectedItem.ToString();
            this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);

            //선택한 가게로 필터링, 구매확정만 표시
            oRDERDPRODBindingSource.Filter = "STOR_NAME= '" + comboBox3.SelectedItem.ToString() + "'" + "AND ORDER_OK= '구매확정'";
            int sum = 0;
            int num = dataGridView5.Rows.Count;
            for (int i = 0; i < num; i++)
            {
                sum += int.Parse(dataGridView5.Rows[i].Cells[8].Value.ToString());
            }
            // 가게별 총 매출액 
            textBox1.Text = sum.ToString();
        }
    }
}
