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
    public partial class MyPageForm : Form
    {
        public static string userid;

        public MyPageForm()
        {
            InitializeComponent();
        }


        private void MyPageForm_Load(object sender, EventArgs e)
        {
            usersTableAdapter1.Fill(dataSet1.USERS);
            DataTable mytable = dataSet1.Tables["USERS"];

            DataRow dataRow = mytable.Rows.Find(userid);


            textBox1.Text = dataRow["USER_NAME"].ToString();
            textBox2.Text = userid;
            textBox3.Text = dataRow["USER_PASSWORD"].ToString();
            textBox4.Text = dataRow["USER_BIRTH"].ToString();
            textBox5.Text = dataRow["USER_TELE"].ToString();
            textBox6.Text = dataRow["USER_ADDR"].ToString();
            textBox7.Text = dataRow["USER_EMAIL"].ToString();
            textBox8.Text = dataRow["USER_GRADE"].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable mytable = dataSet1.Tables["USERS"];

            DataRow dataRow = mytable.Rows.Find(userid);

            dataRow["USER_NOT"] = 1;
            usersTableAdapter1.Update(this.dataSet1);
            MessageBox.Show("그동안 서비스를 이용해주셔서 감사합니다 :) ");
            MessageBox.Show("회원탈퇴 완료");
            Application.Exit();
        }
    }
}
