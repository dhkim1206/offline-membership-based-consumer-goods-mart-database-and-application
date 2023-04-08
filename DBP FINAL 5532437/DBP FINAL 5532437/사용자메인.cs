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
    public partial class 사용자메인 : Form
    {
        //로그인 유저 아이디값 받아오기
        public static string loginid;
        MyPageForm mypage = new MyPageForm();
        DataTable mytable1;
        DataTable ordered_prod;
        public 사용자메인()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ORDERD_PROD' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);
            // TODO: 이 코드는 데이터를 'dataSet1.BASKET' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.bASKETTableAdapter.Fill(this.dataSet1.BASKET);
            // TODO: 이 코드는 데이터를 'dataSet1.PRODUCTS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTSTableAdapter.Fill(this.dataSet1.PRODUCTS);
            this.usersTableAdapter1.Fill(this.dataSet1.USERS);


            bASKETBindingSource.Filter = "USER_ID= '" + loginid+ "'";
            oRDERDPRODBindingSource.Filter = "USER_ID= '" + loginid + "'";


            comboBox2.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyPageForm mypage = new MyPageForm();
            mypage.ShowDialog();
        }

        private void button_basket_Click(object sender, EventArgs e)
        {
            //현재 선택된 열 값 지정
            DataGridViewRow dgr = dataGridView1.SelectedRows[0];

            string prod_kind = dgr.Cells[0].Value.ToString();
            string prod_name = dgr.Cells[1].Value.ToString();
            string prod_count = dgr.Cells[2].Value.ToString();
            string prod_price = dgr.Cells[3].Value.ToString();
            string stor_name = dgr.Cells[4].Value.ToString();
            string prod_id = dgr.Cells[5].Value.ToString();

            //String equal = bASKETTableAdapter.PROD_ID_EQUAL(prod_id).ToString();
            
            //장바구니 테이블에 추가        
            mytable1 = dataSet1.Tables["BASKET"];
            //MessageBox.Show(equal.ToString());
            if(bASKETTableAdapter.PROD_ID_EQUAL(prod_id) == null)
            {
                DataRow mynewDataRow = mytable1.NewRow();
                
                mynewDataRow["USER_ID"] = loginid;
                mynewDataRow["PROD_ID"] = prod_id;
                mynewDataRow["STOR_NAME"] = stor_name;
                mynewDataRow["PROD_KIND"] = prod_kind;
                mynewDataRow["PROD_NAME"] = prod_name;
                mynewDataRow["PROD_PRICE"] = prod_price;
                mynewDataRow["PROD_COUNT"] = "1";
                mynewDataRow["TOTAL_PRICE"] = prod_price;


                mytable1.Rows.Add(mynewDataRow);
                bASKETTableAdapter.Update(this.dataSet1);

                MessageBox.Show("장바구니 추가 완료");
            }
            else
            {
                MessageBox.Show("이미 담은 상품입니다");
            }
            
            
        }

        //주문하기
        private void button_order_Click(object sender, EventArgs e)
        {
            //현재 선택된 열 값 지정
            int count = int.Parse(dataGridView2.Rows.Count.ToString());
            String date = DateTime.Now.Date.ToString();
            //유저 주문량 올려주기
            DataTable usertable = dataSet1.Tables["USERS"];
            DataRow finduser = usertable.Rows.Find(loginid);

            

            if (count >= 5) // 장바구니에 5개 이상 들어있으면
            {
                String seq = oRDERD_PRODTableAdapter.fillbyseq().ToString();
                for (int i = 0; i < count; i++) // 장바구니에 들어있는 ROW수 만큼 반복
                {
                    DataGridViewRow dgr = dataGridView2.Rows[0]; //제일 위에 있는 ROW
                    
                    string prod_kind = dgr.Cells[0].Value.ToString();
                    string prod_name = dgr.Cells[1].Value.ToString();
                    string prod_count = dgr.Cells[3].Value.ToString();
                    string prod_price = dgr.Cells[2].Value.ToString();
                    string total_price = dgr.Cells[4].Value.ToString();
                    string stor_name = dgr.Cells[5].Value.ToString();
                    string prod_id = dgr.Cells[6].Value.ToString();

                    
                    //주문 ROW에 값들 추가
                    ordered_prod = dataSet1.Tables["ORDERD_PROD"];
                    DataRow newDataRow = ordered_prod.NewRow();

                    newDataRow["ORDER_ID"] = seq;
                    newDataRow["PROD_KIND"] = prod_kind;
                    newDataRow["PROD_NAME"] = prod_name;
                    newDataRow["PROD_PRICE"] = prod_price;
                    newDataRow["USER_ID"] = loginid;
                    newDataRow["STOR_NAME"] = stor_name;
                    newDataRow["PROD_ID"] = prod_id;
                    newDataRow["ORDER_DATE"] = date;
                    newDataRow["ORDER_OK"] = "주문요청";
                    newDataRow["PROD_COUNT"] = prod_count;
                    newDataRow["SELLER_ID"] = "미지정";
                    newDataRow["TOTAL_PRICE"] = total_price;

                    //사용자 주문 상품 개수 DB추가
                    //finduser["ORDERCOUNT"] = int.Parse(finduser["ORDERCOUNT"].ToString()) + int.Parse(prod_count.ToString());

                    //주문 추가
                    ordered_prod.Rows.Add(newDataRow);
                    //장바구니 삭제
                    dataGridView2.Rows.Remove(dataGridView2.Rows[0]);
                     

                    DataTable productable = dataSet1.Tables["PRODUCTS"];
                    DataRow findrow = productable.Rows.Find(prod_id);

                    if (findrow != null)
                    {
                        // 프로덕트 개수 줄여주기
                        int result = (int.Parse(findrow["PROD_COUNT"].ToString()) - int.Parse(prod_count));
                        findrow["PROD_COUNT"] = result.ToString();
                    }
                }

                oRDERD_PRODTableAdapter.Update(this.dataSet1);
                bASKETTableAdapter.Update(this.dataSet1);
                
                int numOfRows = pRODUCTSTableAdapter.Update(this.dataSet1);
                if (numOfRows < 1)
                {
                }
                else
                {
                    pRODUCTSTableAdapter.Update(this.dataSet1);
                }
                usersTableAdapter1.Update(this.dataSet1);
                MessageBox.Show("주문 요청 완료");
            }
            else
            {
                MessageBox.Show("장바구니에 5개 이상 담으세요");
            }


        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            string seq = comboBox2.SelectedIndex.ToString();

            pRODUCTSTableAdapter.Fill(dataSet1.PRODUCTS);
            DataTable productable = dataSet1.Tables["PRODUCTS"];
            try
            {
                // 개수가 0 이하로가면 안보이게, 콤보 박스에 설정한 가게 상품만 보이게 필터링
                pRODUCTSBindingSource.Filter = "STOR_NAME= '" +comboBox2.SelectedItem.ToString() +"'" + "AND PROD_COUNT>'0'";
                bASKETBindingSource.Filter = "STOR_NAME= '" + comboBox2.SelectedItem.ToString() +"'" + "AND USER_ID= '" + loginid + "'";
                oRDERDPRODBindingSource.Filter = "STOR_NAME= '" + comboBox2.SelectedItem.ToString() + "'" + "AND USER_ID= '" + loginid + "'";
            }
            catch(Exception ex)
            {

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //현재 선택된 열 값 지정
            DataGridViewRow dgr = dataGridView2.SelectedRows[0];
            String prod_count = pRODUCTSTableAdapter.GET_PROD_COUNT(dataGridView2.CurrentRow.Cells[6].Value.ToString()).ToString();
            
            if (int.Parse(dgr.Cells[3].Value.ToString()) < int.Parse(prod_count))
            {
                dgr.Cells[3].Value = (int.Parse(dgr.Cells[3].Value.ToString()) + 1).ToString();
                dataGridView2.CurrentRow.Cells[4].Value = int.Parse(dgr.Cells[2].Value.ToString()) * int.Parse(dgr.Cells[3].Value.ToString());

                bASKETTableAdapter.Update(this.dataSet1);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //현재 선택된 열 값 지정
            DataGridViewRow dgr = dataGridView2.SelectedRows[0];
            if (int.Parse(dgr.Cells[3].Value.ToString()) >= 1){
                dgr.Cells[3].Value = (int.Parse(dgr.Cells[3].Value.ToString()) - 1).ToString();
                dataGridView2.CurrentRow.Cells[4].Value = int.Parse(dgr.Cells[2].Value.ToString()) * int.Parse(dgr.Cells[3].Value.ToString());
                if (int.Parse(dgr.Cells[3].Value.ToString()) == 0)
                    dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                bASKETTableAdapter.Update(this.dataSet1);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //현재 선택된 열 값 지정
            DataGridViewRow dgr = dataGridView3.SelectedRows[0];

            if (dgr.Cells[7].Value.ToString() == "환불요청")
            {
                MessageBox.Show("이미 환불요청된 건입니다.");
            }
            else if(dgr.Cells[7].Value.ToString() == "주문요청")
            {
            
                 // 주문번호로 주문 다 삭제
                decimal orderid = decimal.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
                oRDERD_PRODTableAdapter.DeleteOrder(orderid);
                MessageBox.Show("주문취소 완료");
                oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);

                /*
                //상품 재고 다시 추가
                pRODUCTSTableAdapter.Fill(dataSet1.PRODUCTS);
                DataTable productable = dataSet1.Tables["PRODUCTS"];
                string string1 = dataGridView3.CurrentRow.Cells[5].Value.ToString();
                DataRow findrow = productable.Rows.Find(dataGridView3.CurrentRow.Cells[5].Value.ToString());
                findrow["PROD_COUNT"] = int.Parse(findrow["PROD_COUNT"].ToString()) + int.Parse(dataGridView3.CurrentRow.Cells[3].Value.ToString());
                pRODUCTSTableAdapter.Update(this.dataSet1);


                dataGridView3.Rows.Remove(dgr);
                oRDERD_PRODTableAdapter.Update(this.dataSet1);
                
                */
            }
            else
            {
                decimal orderid = decimal.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
                oRDERD_PRODTableAdapter.REFUND_REQUEST_BY_ORDERID(orderid);

                /* 이거 상품 하나씩 환불하는거 
                decimal a = decimal.Parse(dgr.Cells[0].Value.ToString());
                string b = dgr.Cells[3].Value.ToString();

                oRDERD_PRODTableAdapter.REFUND_REQUEST(a, b);
                
                oRDERD_PRODTableAdapter.After_Refund(decimal.Parse (dataGridView3.CurrentRow.Cells[0].Value.ToString()), dataGridView3.CurrentRow.Cells[5].Value.ToString(), loginid);
                dataGridView3.CurrentRow.Cells[7].Value = "환불요청";
                */
                
                usersTableAdapter1.Update(this.dataSet1);
                pRODUCTSTableAdapter.Update(this.dataSet1);
                oRDERD_PRODTableAdapter.Update(this.dataSet1);
                oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);
                MessageBox.Show("환불요청 완료");
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MyPageForm.userid = loginid;
            mypage.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            리뷰 review = new 리뷰();
            리뷰.uesrid = loginid;
            review.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_review_search_Click(object sender, EventArgs e)
        {

            if (pRODUCTSBindingSource.Filter == "STOR_NAME= '" + comboBox2.SelectedItem.ToString() + "'" + "AND PROD_COUNT>'0'" + "AND PROD_NAME='" + textBox5.Text + "'")
            {
                pRODUCTSBindingSource.Filter = "STOR_NAME= '" + comboBox2.SelectedItem.ToString() + "'" + "AND PROD_COUNT>'0'";
                button_review_search.Text = "필터";
            }
            else
            {
                pRODUCTSBindingSource.Filter = "STOR_NAME= '" + comboBox2.SelectedItem.ToString() + "'" + "AND PROD_COUNT>'0'" + "AND PROD_NAME='"+textBox5.Text+"'";
                button_review_search.Text = "필터해제";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            사용자_공지사항 notice_user = new 사용자_공지사항();
            notice_user.ShowDialog();

        }
    }
    
}
