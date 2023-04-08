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
    public partial class 관리자_공지사항 : Form
    {
        public 관리자_공지사항()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable notice = dataSet1.Tables["NOTICE"];

            DataRow newrow = notice.NewRow();

            newrow["NOTICE_ID"] = noticeTableAdapter1.FILLSEQ();
            newrow["NOTICE_TITLE"] = textBox1.Text;
            newrow["NOTICE_CONTENT"] = textBox2.Text;

            notice.Rows.Add(newrow);
            noticeTableAdapter1.Update(this.dataSet1);

            textBox1.Text="";
            textBox2.Text="";

            MessageBox.Show("공지사항 업로드 완료");
        }


        private void 관리자_공지사항_Load(object sender, EventArgs e)
        {
            this.noticeTableAdapter1.Fill(this.dataSet1.NOTICE);
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            textBox_notice_title.Text = "";
            textBox_notice_content.Text = "";

            label2.Hide();
            textBox_notice_title.Hide();
            textBox_notice_content.Hide();


            textBox_notice_title.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label2.Show();
            textBox_notice_title.Show();

            textBox_notice_content.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Thread.Sleep(50);
            textBox_notice_content.Show();
        }
    }
}
