
namespace DBP_FINAL_5532437
{
    partial class 로그인화면
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_seller = new System.Windows.Forms.RadioButton();
            this.button_user_login = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.dataSet1 = new DBP_FINAL_5532437.DataSet1();
            this.adminTableAdapter1 = new DBP_FINAL_5532437.DataSet1TableAdapters.ADMINTableAdapter();
            this.usersTableAdapter1 = new DBP_FINAL_5532437.DataSet1TableAdapters.USERSTableAdapter();
            this.sellerTableAdapter1 = new DBP_FINAL_5532437.DataSet1TableAdapters.SELLERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_seller
            // 
            this.radioButton_seller.AutoSize = true;
            this.radioButton_seller.Font = new System.Drawing.Font("함초롬바탕 확장", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_seller.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_seller.Location = new System.Drawing.Point(231, 41);
            this.radioButton_seller.Name = "radioButton_seller";
            this.radioButton_seller.Size = new System.Drawing.Size(76, 25);
            this.radioButton_seller.TabIndex = 20;
            this.radioButton_seller.Text = "판매자";
            this.radioButton_seller.UseVisualStyleBackColor = true;
            // 
            // button_user_login
            // 
            this.button_user_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_user_login.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.button_user_login.FlatAppearance.BorderSize = 3;
            this.button_user_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_user_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button_user_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user_login.Font = new System.Drawing.Font("함초롬바탕 확장", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_user_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_user_login.Location = new System.Drawing.Point(116, 213);
            this.button_user_login.Name = "button_user_login";
            this.button_user_login.Size = new System.Drawing.Size(305, 53);
            this.button_user_login.TabIndex = 19;
            this.button_user_login.Text = " 로그인";
            this.button_user_login.UseVisualStyleBackColor = false;
            this.button_user_login.Click += new System.EventHandler(this.button_user_login_Click_1);
            // 
            // button_SignUp
            // 
            this.button_SignUp.Font = new System.Drawing.Font("함초롬바탕 확장", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_SignUp.Location = new System.Drawing.Point(116, 275);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(305, 32);
            this.button_SignUp.TabIndex = 18;
            this.button_SignUp.Text = "회원가입";
            this.button_SignUp.UseVisualStyleBackColor = true;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬바탕 확장", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "비밀번호";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 142);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 40);
            this.textBox2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬바탕 확장", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(34, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "아이디";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 40);
            this.textBox1.TabIndex = 14;
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Checked = true;
            this.radioButton_user.Font = new System.Drawing.Font("함초롬바탕 확장", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_user.Location = new System.Drawing.Point(147, 41);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(76, 25);
            this.radioButton_user.TabIndex = 21;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "사용자";
            this.radioButton_user.UseVisualStyleBackColor = true;
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Font = new System.Drawing.Font("함초롬바탕 확장", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_admin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_admin.Location = new System.Drawing.Point(316, 41);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(76, 25);
            this.radioButton_admin.TabIndex = 22;
            this.radioButton_admin.Text = "관리자";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // sellerTableAdapter1
            // 
            this.sellerTableAdapter1.ClearBeforeFill = true;
            // 
            // 로그인화면
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(506, 360);
            this.Controls.Add(this.radioButton_admin);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.radioButton_seller);
            this.Controls.Add(this.button_user_login);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "로그인화면";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.ADMINTableAdapter adminTableAdapter1;
        private DataSet1TableAdapters.USERSTableAdapter usersTableAdapter1;
        private System.Windows.Forms.RadioButton radioButton_seller;
        private System.Windows.Forms.Button button_user_login;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private DataSet1TableAdapters.SELLERTableAdapter sellerTableAdapter1;
    }
}

