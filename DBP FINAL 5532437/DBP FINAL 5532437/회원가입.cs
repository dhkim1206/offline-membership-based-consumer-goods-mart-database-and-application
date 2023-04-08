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
    public partial class 회원가입 : Form
    {
        public 회원가입()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usersTableAdapter1.Fill(dataSet1.USERS);
            DataTable mytable2 = dataSet1.Tables["USERS"];

            DataRow findrow = mytable2.Rows.Find(textBox1.Text);
            if(findrow != null)
            {
                MessageBox.Show("이미 존재하는 아이디 입니다.");
            }
            if (findrow == null)
            {
                // DataSet의 EMP 테이블에 새로운 레코드 입력 
                DataRow mynewDataRow = mytable2.NewRow();
                mynewDataRow["USER_ID"] = textBox1.Text;
                mynewDataRow["USER_PASSWORD"] = textBox2.Text;
                mynewDataRow["USER_NAME"] = textBox3.Text;
                mynewDataRow["USER_BIRTH"] = textBox4.Text;
                mynewDataRow["USER_TELE"] = textBox5.Text;
                mynewDataRow["USER_ADDR"] = textBox6.Text;
                mynewDataRow["USER_EMAIL"] = textBox7.Text;
                mynewDataRow["USER_NOT"] = "0";
                mynewDataRow["ORDERCOUNT"] = "0";
                mynewDataRow["PAYMONEY"] = "0";
                mynewDataRow["REFUND_COUNT"] = "0";
                mynewDataRow["USER_GRADE"] = "일반고객";

                mytable2.Rows.Add(mynewDataRow);

                MessageBox.Show("회원가입 성공");

                usersTableAdapter1.Update(dataSet1.USERS);

                this.Close();
                
                    
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
