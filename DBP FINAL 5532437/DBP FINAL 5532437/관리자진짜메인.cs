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
    
    public partial class 관리자_진짜_메인 : Form
    {
        public static String adminid;
        public 관리자_진짜_메인()
        {
            InitializeComponent();
        }

        private void button_review_search_Click(object sender, EventArgs e)
        {
            상품관리 prodcontrol = new 상품관리();
            prodcontrol.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            상품현황통계 prodchart = new 상품현황통계();
            prodchart.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            상품판매현황 prodsituation = new 상품판매현황();
            prodsituation.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            고객관리 customer = new 고객관리();
            customer.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            관리자_공지사항 notice = new 관리자_공지사항();
            notice.ShowDialog();
        }

        private void 관리자_진짜_메인_Load(object sender, EventArgs e)
        {

        }
    }
}
