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
    public partial class 판매자메인 : Form
    {
        public static string sellerid;
        public 판매자메인()
        {
            InitializeComponent();
        }

        private void 판매자메인_Load(object sender, EventArgs e)
        {
            
            // TODO: 이 코드는 데이터를 'dataSet1.ORDERD_PROD' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);
            this.pRODUCTSTableAdapter.Fill(this.dataSet1.PRODUCTS);
            this.sellerTableAdapter1.Fill(this.dataSet1.SELLER);
            this.usersTableAdapter1.Fill(this.dataSet1.USERS);
            this.storeTableAdapter1.Fill(this.dataSet1.STORE);


            DataTable seller  = dataSet1.Tables["SELLER"];
            DataRow findrow = seller.Rows.Find(sellerid);

            label1.Text = findrow["STOR_NAME"].ToString();

            if (findrow != null)
            {
                oRDERDPRODBindingSource.Filter = "STOR_NAME= '" + findrow["STOR_NAME"].ToString() + "'";
            }

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() != "주문요청")
            {
                MessageBox.Show("주문요청 상품만 구매확정 할 수 있습니다.");
            }

            else
            {
                decimal orderid = decimal.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                oRDERD_PRODTableAdapter.ORDER_OK_BY_OREDER_ID(sellerid, orderid);

                DataTable reufundtable = oRDERD_PRODTableAdapter.GetDataBy_ORDER_ID(orderid);

                foreach (DataRow datarow in reufundtable.Rows)
                {
                    string prod_id = datarow["PROD_ID"].ToString();
                    string storename = datarow["STOR_NAME"].ToString();
                    string userid = datarow["USER_ID"].ToString();
                    string prod_count = datarow["PROD_COUNT"].ToString();
                    string total_price = datarow["TOTAL_PRICE"].ToString();

                    //유저 주문량 올려주기----------------------------------------------------------------------------------------------------------------------------

                    DataTable usertable = dataSet1.Tables["USERS"];
                    DataRow finduser = usertable.Rows.Find(userid);
                    finduser["ORDERCOUNT"] = int.Parse(finduser["ORDERCOUNT"].ToString()) + int.Parse(prod_count);
                    finduser["PAYMONEY"] = int.Parse(finduser["PAYMONEY"].ToString()) + int.Parse(total_price);
                    
                    /*
                     string userid = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                    int paymoney = int.Parse(usersTableAdapter1.GET_PAYMONEY(userid);
                    paymoney = paymoney + int.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());

                    int ordercount = int.Parse(usersTableAdapter1.GET_ORDERCOUNT(userid).ToString());
                    ordercount = ordercount + int.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());

                    usersTableAdapter1.UPDATE_PAYMONEY(paymoney.ToString(), userid);
                    usersTableAdapter1.UPDATE_ORDERCOUNT(ordercount, userid);
                    */


                    //가게 매출 올려주기----------------------------------------------------------------------------------------------------------------------------
                    DataTable storetable = dataSet1.Tables["STORE"];
                    DataRow findstore = storetable.Rows.Find(label1.Text);
                    findstore["TOTAL_SALE"] = int.Parse(findstore["TOTAL_SALE"].ToString()) + int.Parse(total_price);
                    

                    decimal a = decimal.Parse(orderid.ToString());
                    string b = prod_id;
                    string c = userid;

                    oRDERD_PRODTableAdapter.WHY(sellerid, a, b, c);
                    oRDERD_PRODTableAdapter.ordercheck(a, b, c);

                    //dataGridView1.CurrentRow.Cells[5].Value = "구매확정";
                    //dataGridView1.CurrentRow.Cells[7].Value = sellerid;
                    
                    //상품 테이블 주문수 증가----------------------------------------------------------------------------------------------------------------------------
                    DataTable productable = dataSet1.Tables["PRODUCTS"];
                    DataRow findrow = productable.Rows.Find(prod_id);
                    findrow["ORDER_COUNT"] = int.Parse(findrow["ORDER_COUNT"].ToString()) + int.Parse(prod_count);

                    usersTableAdapter1.Update(this.dataSet1);
                    storeTableAdapter1.Update(this.dataSet1.STORE);
                    oRDERD_PRODTableAdapter.Update(this.dataSet1.ORDERD_PROD);
                    pRODUCTSTableAdapter.Update(this.dataSet1.PRODUCTS);

                }
                MessageBox.Show("구매확정 완료");
                this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);
                this.pRODUCTSTableAdapter.Fill(this.dataSet1.PRODUCTS);
                this.sellerTableAdapter1.Fill(this.dataSet1.SELLER);
                this.usersTableAdapter1.Fill(this.dataSet1.USERS);
                this.storeTableAdapter1.Fill(this.dataSet1.STORE);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "환불요청")
            {
                decimal orderid = decimal.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                oRDERD_PRODTableAdapter.ORDER_OK_BY_OREDER_ID(sellerid, orderid);

                DataTable reufundtable = oRDERD_PRODTableAdapter.GetDataBy_ORDER_ID(orderid);

                foreach (DataRow datarow in reufundtable.Rows)
                {
                    string prod_id = datarow["PROD_ID"].ToString();
                    string storename = datarow["STOR_NAME"].ToString();
                    string userid = datarow["USER_ID"].ToString();
                    string prod_count = datarow["PROD_COUNT"].ToString();
                    string total_price = datarow["TOTAL_PRICE"].ToString();

                     //상품 환불 횟수 증가------------------------------------------------------------------------------
                    DataTable productable = dataSet1.Tables["PRODUCTS"];
                    DataRow findrow = productable.Rows.Find(prod_id);
                    findrow["REFUND_COUNT"] = int.Parse(findrow["REFUND_COUNT"].ToString()) + int.Parse(prod_count);
                    

                     //가게 매출액 줄여주기-----------------------------------------------------------------------------
                    DataTable storetable = dataSet1.Tables["STORE"];
                    DataRow findstore = storetable.Rows.Find(label1.Text);
                    findstore["TOTAL_SALE"] = int.Parse(findstore["TOTAL_SALE"].ToString()) - int.Parse(total_price);
                    

                    //-------------------------------------------------------------------------------------------------
                    DataTable usertable = dataSet1.Tables["USERS"];
                    DataRow finduser = usertable.Rows.Find(userid);

                    // 구매자 환불 횟수 증가
                    finduser["REFUND_COUNT"] = int.Parse(finduser["REFUND_COUNT"].ToString()) + int.Parse(prod_count);
                     // 지불금액 줄여주기
                    finduser["PAYMONEY"] = int.Parse(finduser["PAYMONEY"].ToString()) - int.Parse(total_price);

                    pRODUCTSTableAdapter.Update(this.dataSet1.PRODUCTS);
                    storeTableAdapter1.Update(this.dataSet1.STORE);
                    usersTableAdapter1.Update(this.dataSet1.USERS);
                    oRDERD_PRODTableAdapter.Update(this.dataSet1.ORDERD_PROD);
                }
                this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);
                this.pRODUCTSTableAdapter.Fill(this.dataSet1.PRODUCTS);
                this.sellerTableAdapter1.Fill(this.dataSet1.SELLER);
                this.usersTableAdapter1.Fill(this.dataSet1.USERS);
                this.storeTableAdapter1.Fill(this.dataSet1.STORE);
                MessageBox.Show("환불승인 완료");
                /*
                decimal a = decimal.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string b = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string c = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                oRDERD_PRODTableAdapter.REFUND_OK(a, b, c);

                dataGridView1.CurrentRow.Cells[5].Value = "환불확정";
                dataGridView1.CurrentRow.Cells[7].Value = sellerid;
                */
            }

            else
            {
                MessageBox.Show("환불이 요청된 상품만 환불이 가능합니다.");
            }
            
        }

        private void button_review_search_Click(object sender, EventArgs e)
        {
            DataTable seller = dataSet1.Tables["SELLER"];
            DataRow findrow = seller.Rows.Find(sellerid.ToString());

            if (oRDERDPRODBindingSource.Filter == "STOR_NAME= '" + findrow["STOR_NAME"].ToString() + "'" + "AND ORDER_ID = '" + textBox5.Text + "'")
            {
                oRDERDPRODBindingSource.Filter = "STOR_NAME= '" + findrow["STOR_NAME"].ToString() + "'"; 
                button_review_search.Text = "필터";
            }
            else
            {
                oRDERDPRODBindingSource.Filter = "STOR_NAME= '" + findrow["STOR_NAME"].ToString() + "'" + "AND ORDER_ID = '" + textBox5.Text+ "'";
                button_review_search.Text = "필터해제";
            }
            this.oRDERD_PRODTableAdapter.Fill(this.dataSet1.ORDERD_PROD);
            this.pRODUCTSTableAdapter.Fill(this.dataSet1.PRODUCTS);
            this.sellerTableAdapter1.Fill(this.dataSet1.SELLER);
            this.usersTableAdapter1.Fill(this.dataSet1.USERS);
            this.storeTableAdapter1.Fill(this.dataSet1.STORE);
        }

    }
}
