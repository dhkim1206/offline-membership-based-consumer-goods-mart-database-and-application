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
    public partial class 로그인화면 : Form
    {
        string loginid = "";
        DataTable mytable1;
      
        public 로그인화면()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button_SignUp_Click(object sender, EventArgs e)
        {
            회원가입 singupForm = new 회원가입();
            singupForm.ShowDialog();
        }

        private void button_user_login_Click_1(object sender, EventArgs e)
        {
            //유저 로그인
            if (radioButton_user.Checked)
            {
                사용자메인 usermain = new 사용자메인();
                사용자메인_진짜 realuser = new 사용자메인_진짜();
                //유저테이블 채우기
                usersTableAdapter1.Fill(dataSet1.USERS);

                DataTable usertable = dataSet1.Tables["USERS"];
                DataRow findrow = usertable.Rows.Find(textBox1.Text);
                if (findrow != null)
                {
                    if (findrow["USER_PASSWORD"].ToString() == textBox2.Text)
                    {
                        if (findrow["USER_NOT"].ToString() == "1")
                        {
                            MessageBox.Show("탈퇴한 회원입니다");
                        }
                        else
                        {
                            loginid = textBox1.Text;
                            사용자메인.loginid = loginid;

                            MessageBox.Show("사용자 로그인 성공");
                            usermain.ShowDialog();
                            //realuser.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("로그인 실패");
                }
            }
            else if (radioButton_seller.Checked)
            {
                판매자메인 sellerform = new 판매자메인();
                sellerTableAdapter1.Fill(dataSet1.SELLER);
                DataTable sellertable = dataSet1.Tables["SELLER"];
                DataRow findadmin = sellertable.Rows.Find(textBox1.Text);

                if (findadmin != null)
                {
                    if (findadmin["SELLER_PASSWORD"].ToString() == textBox2.Text)
                    {

                        판매자메인.sellerid = textBox1.Text;
                        MessageBox.Show("판매자 로그인 성공");
                        sellerform.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("로그인 실패");
                }

            }
            else if (radioButton_admin.Checked)
            {
                //관리자 로그인
                관리자_진짜_메인 adminForm = new 관리자_진짜_메인();

                adminTableAdapter1.Fill(dataSet1.ADMIN);
                DataTable admintable = dataSet1.Tables["ADMIN"];
                DataRow findadmin = admintable.Rows.Find(textBox1.Text);

                if (findadmin != null)
                {
                    if (findadmin["ADMIN_PASSWORD"].ToString() == textBox2.Text)
                    {
                        관리자_진짜_메인.adminid = textBox1.Text;
                        MessageBox.Show("관리자 로그인 성공");
                        adminForm.ShowDialog();
                        

                    }
                }
                else
                {
                    MessageBox.Show("로그인 실패");
                }

            }
        }

        private void button_SignUp_Click_1(object sender, EventArgs e)
        {
            회원가입 singnup = new 회원가입();
            singnup.ShowDialog();
        }
    }
}
