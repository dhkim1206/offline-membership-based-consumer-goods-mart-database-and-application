
namespace DBP_FINAL_5532437
{
    partial class 고객관리
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DBP_FINAL_5532437.DataSet1();
            this.uSERSTableAdapter = new DBP_FINAL_5532437.DataSet1TableAdapters.USERSTableAdapter();
            this.oRDERDPRODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERD_PRODTableAdapter = new DBP_FINAL_5532437.DataSet1TableAdapters.ORDERD_PRODTableAdapter();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.sTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDEROKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sELLERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMONEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDPRODBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("함초롬바탕 확장", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(588, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 23);
            this.button3.TabIndex = 142;
            this.button3.Text = "불량고객";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("함초롬바탕 확장", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(514, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 23);
            this.button4.TabIndex = 141;
            this.button4.Text = "우수고객";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬바탕 확장", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(29, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 140;
            this.label3.Text = "사용자 주문 정보";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("함초롬바탕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.oRDERCOUNTDataGridViewTextBoxColumn,
            this.rEFUNDCOUNTDataGridViewTextBoxColumn,
            this.pAYMONEYDataGridViewTextBoxColumn,
            this.uSERGRADEDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.uSERSBindingSource;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.Location = new System.Drawing.Point(12, 51);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(654, 192);
            this.dataGridView3.TabIndex = 139;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseClick);
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // oRDERDPRODBindingSource
            // 
            this.oRDERDPRODBindingSource.DataMember = "ORDERD_PROD";
            this.oRDERDPRODBindingSource.DataSource = this.dataSet1;
            // 
            // oRDERD_PRODTableAdapter
            // 
            this.oRDERD_PRODTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("함초롬바탕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTORNAMEDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn,
            this.oRDERIDDataGridViewTextBoxColumn,
            this.pRODIDDataGridViewTextBoxColumn,
            this.pRODNAMEDataGridViewTextBoxColumn,
            this.pRODPRICEDataGridViewTextBoxColumn,
            this.oRDEROKDataGridViewTextBoxColumn,
            this.pRODCOUNTDataGridViewTextBoxColumn,
            this.tOTALPRICEDataGridViewTextBoxColumn,
            this.sELLERIDDataGridViewTextBoxColumn,
            this.oRDERDATEDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.oRDERDPRODBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(12, 292);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView5.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(930, 150);
            this.dataGridView5.TabIndex = 166;
            // 
            // sTORNAMEDataGridViewTextBoxColumn
            // 
            this.sTORNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "STOR_NAME";
            this.sTORNAMEDataGridViewTextBoxColumn.HeaderText = "매장";
            this.sTORNAMEDataGridViewTextBoxColumn.Name = "sTORNAMEDataGridViewTextBoxColumn";
            this.sTORNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTORNAMEDataGridViewTextBoxColumn.Width = 64;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "구매자ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            this.uSERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // oRDERIDDataGridViewTextBoxColumn
            // 
            this.oRDERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oRDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn.HeaderText = "주문번호";
            this.oRDERIDDataGridViewTextBoxColumn.Name = "oRDERIDDataGridViewTextBoxColumn";
            this.oRDERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERIDDataGridViewTextBoxColumn.Width = 94;
            // 
            // pRODIDDataGridViewTextBoxColumn
            // 
            this.pRODIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODIDDataGridViewTextBoxColumn.DataPropertyName = "PROD_ID";
            this.pRODIDDataGridViewTextBoxColumn.HeaderText = "상품번호";
            this.pRODIDDataGridViewTextBoxColumn.Name = "pRODIDDataGridViewTextBoxColumn";
            this.pRODIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODIDDataGridViewTextBoxColumn.Width = 94;
            // 
            // pRODNAMEDataGridViewTextBoxColumn
            // 
            this.pRODNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROD_NAME";
            this.pRODNAMEDataGridViewTextBoxColumn.HeaderText = "상품이름";
            this.pRODNAMEDataGridViewTextBoxColumn.Name = "pRODNAMEDataGridViewTextBoxColumn";
            this.pRODNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODNAMEDataGridViewTextBoxColumn.Width = 94;
            // 
            // pRODPRICEDataGridViewTextBoxColumn
            // 
            this.pRODPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODPRICEDataGridViewTextBoxColumn.DataPropertyName = "PROD_PRICE";
            this.pRODPRICEDataGridViewTextBoxColumn.HeaderText = "상품가격";
            this.pRODPRICEDataGridViewTextBoxColumn.Name = "pRODPRICEDataGridViewTextBoxColumn";
            this.pRODPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODPRICEDataGridViewTextBoxColumn.Width = 94;
            // 
            // oRDEROKDataGridViewTextBoxColumn
            // 
            this.oRDEROKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oRDEROKDataGridViewTextBoxColumn.DataPropertyName = "ORDER_OK";
            this.oRDEROKDataGridViewTextBoxColumn.HeaderText = "주문상태";
            this.oRDEROKDataGridViewTextBoxColumn.Name = "oRDEROKDataGridViewTextBoxColumn";
            this.oRDEROKDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDEROKDataGridViewTextBoxColumn.Width = 94;
            // 
            // pRODCOUNTDataGridViewTextBoxColumn
            // 
            this.pRODCOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODCOUNTDataGridViewTextBoxColumn.DataPropertyName = "PROD_COUNT";
            this.pRODCOUNTDataGridViewTextBoxColumn.HeaderText = "주문 수량";
            this.pRODCOUNTDataGridViewTextBoxColumn.Name = "pRODCOUNTDataGridViewTextBoxColumn";
            this.pRODCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODCOUNTDataGridViewTextBoxColumn.Width = 99;
            // 
            // tOTALPRICEDataGridViewTextBoxColumn
            // 
            this.tOTALPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tOTALPRICEDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_PRICE";
            this.tOTALPRICEDataGridViewTextBoxColumn.HeaderText = "결제금액";
            this.tOTALPRICEDataGridViewTextBoxColumn.Name = "tOTALPRICEDataGridViewTextBoxColumn";
            this.tOTALPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALPRICEDataGridViewTextBoxColumn.Width = 94;
            // 
            // sELLERIDDataGridViewTextBoxColumn
            // 
            this.sELLERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sELLERIDDataGridViewTextBoxColumn.DataPropertyName = "SELLER_ID";
            this.sELLERIDDataGridViewTextBoxColumn.HeaderText = "판매자ID";
            this.sELLERIDDataGridViewTextBoxColumn.Name = "sELLERIDDataGridViewTextBoxColumn";
            this.sELLERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sELLERIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // oRDERDATEDataGridViewTextBoxColumn
            // 
            this.oRDERDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oRDERDATEDataGridViewTextBoxColumn.DataPropertyName = "ORDER_DATE";
            this.oRDERDATEDataGridViewTextBoxColumn.HeaderText = "주문일자";
            this.oRDERDATEDataGridViewTextBoxColumn.Name = "oRDERDATEDataGridViewTextBoxColumn";
            this.oRDERDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERDATEDataGridViewTextBoxColumn.Width = 94;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "USER_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USER_NAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "이름";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            this.uSERNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERNAMEDataGridViewTextBoxColumn.Width = 64;
            // 
            // oRDERCOUNTDataGridViewTextBoxColumn
            // 
            this.oRDERCOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oRDERCOUNTDataGridViewTextBoxColumn.DataPropertyName = "ORDERCOUNT";
            this.oRDERCOUNTDataGridViewTextBoxColumn.HeaderText = "주문 수";
            this.oRDERCOUNTDataGridViewTextBoxColumn.Name = "oRDERCOUNTDataGridViewTextBoxColumn";
            this.oRDERCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERCOUNTDataGridViewTextBoxColumn.Width = 84;
            // 
            // rEFUNDCOUNTDataGridViewTextBoxColumn
            // 
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.DataPropertyName = "REFUND_COUNT";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.HeaderText = "환불 수";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.Name = "rEFUNDCOUNTDataGridViewTextBoxColumn";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.Width = 84;
            // 
            // pAYMONEYDataGridViewTextBoxColumn
            // 
            this.pAYMONEYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pAYMONEYDataGridViewTextBoxColumn.DataPropertyName = "PAYMONEY";
            this.pAYMONEYDataGridViewTextBoxColumn.HeaderText = "총 지불 금액";
            this.pAYMONEYDataGridViewTextBoxColumn.Name = "pAYMONEYDataGridViewTextBoxColumn";
            this.pAYMONEYDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAYMONEYDataGridViewTextBoxColumn.Width = 119;
            // 
            // uSERGRADEDataGridViewTextBoxColumn
            // 
            this.uSERGRADEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uSERGRADEDataGridViewTextBoxColumn.DataPropertyName = "USER_GRADE";
            this.uSERGRADEDataGridViewTextBoxColumn.HeaderText = "등급";
            this.uSERGRADEDataGridViewTextBoxColumn.Name = "uSERGRADEDataGridViewTextBoxColumn";
            this.uSERGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERGRADEDataGridViewTextBoxColumn.Width = 64;
            // 
            // 고객관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(974, 512);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Name = "고객관리";
            this.Text = "고객관리";
            this.Load += new System.EventHandler(this.고객관리_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDPRODBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private DataSet1TableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.BindingSource oRDERDPRODBindingSource;
        private DataSet1TableAdapters.ORDERD_PRODTableAdapter oRDERD_PRODTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDEROKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sELLERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMONEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERGRADEDataGridViewTextBoxColumn;
    }
}