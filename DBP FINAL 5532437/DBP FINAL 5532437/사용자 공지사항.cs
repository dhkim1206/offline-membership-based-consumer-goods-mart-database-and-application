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
    public partial class 사용자_공지사항 : Form
    {
        public 사용자_공지사항()
        {
            InitializeComponent();
        }

        private void 사용자_공지사항_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.NOTICE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.nOTICETableAdapter.Fill(this.dataSet1.NOTICE);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
