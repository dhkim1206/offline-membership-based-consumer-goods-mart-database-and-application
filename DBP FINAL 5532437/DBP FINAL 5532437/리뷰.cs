using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DBP_FINAL_5532437
{
    public partial class 리뷰 : Form
    {
        public static string uesrid;
        public 리뷰()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = usersTableAdapter1.GET_USER_NAME(uesrid);
            
            DataTable review = dataSet1.Tables["REVIEW"];
            DataTable orderprod = dataSet1.Tables["ORDERD_PROD"];
            
            DataRow newrow = review.NewRow();
            String seq = reviewTableAdapter1.fillbyseq().ToString();
            string prodname = orderD_PRODTableAdapter1.GET_PROD_NAME(dataGridView3.CurrentRow.Cells[4].Value.ToString());

            newrow["REVIEW_ID"] = seq;
            newrow["REVIEW_TITLE"] = textBox1.Text;
            newrow["REVIEW_CONTENT"] = textBox2.Text;
            newrow["USER_ID"] = uesrid;
            newrow["REVIEW_DATE"] = DateTime.Now;
            newrow["PROD_ID"] = dataGridView3.CurrentRow.Cells[4].Value;
            newrow["USER_NAME"] = username;
            newrow["PROD_NAME"] = prodname;

            decimal orderprodid = decimal.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            string prodid = dataGridView3.CurrentRow.Cells[4].Value.ToString();

            orderD_PRODTableAdapter1.afterreview(orderprodid, prodid, uesrid);
            //리뷰 추가
            review.Rows.Add(newrow);
            //리뷰 작성 후 데이터그리드뷰에서 삭제
            dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
            reviewTableAdapter1.Update(this.dataSet1);
            
            MessageBox.Show("후기 업로드 완료");
            oRDERDPRODBindingSource.Filter = "ORDER_OK= '구매확정' AND USER_ID = '" + uesrid + "'";
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Hide();
            textBox1.Hide();
            textBox2.Hide();
            button2.Hide();
        }

        private void 리뷰_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ORDERD_PROD' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.orderD_PRODTableAdapter1.Fill(this.dataSet1.ORDERD_PROD);
            this.reviewTableAdapter1.Fill(this.dataSet1.REVIEW);

            textBox1.Hide();
            textBox2.Hide();
            label1.Hide();
            button2.Hide();

            oRDERDPRODBindingSource.Filter = "ORDER_OK= '구매확정' AND USER_ID = '" + uesrid + "'";
        }


        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Hide();
            textBox1.Hide();
            textBox2.Hide();
            button2.Hide();

            Thread.Sleep(100);

            label1.Show();
            textBox1.Show();

            Thread.Sleep(50);
            textBox2.Show();
            Thread.Sleep(30);
            button2.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Hide();
            textBox1.Hide();
            textBox2.Hide();
            button2.Hide();

            Thread.Sleep(100);

            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            label1.Show();
            textBox1.Show();

            Thread.Sleep(50);
            textBox2.Show();
            Thread.Sleep(30);
            button2.Show();

        }

        private void button_review_search_Click(object sender, EventArgs e)
        {
            if (rEVIEWBindingSource.Filter != null)
            {
                rEVIEWBindingSource.RemoveFilter();
                button_review_search.Text = "필터";
            }
            else
            {
                rEVIEWBindingSource.Filter = "PROD_NAME= '" + textBox5.Text + "'";
                button_review_search.Text = "필터해제";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
