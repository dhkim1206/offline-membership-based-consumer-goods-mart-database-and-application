
namespace DBP_FINAL_5532437
{
    partial class 상품관리
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
            this.dataSet1 = new DBP_FINAL_5532437.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_review_search = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODKINDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new DBP_FINAL_5532437.DataSet1TableAdapters.PRODUCTSTableAdapter();
            this.oRDERDPRODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERD_PRODTableAdapter = new DBP_FINAL_5532437.DataSet1TableAdapters.ORDERD_PRODTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDPRODBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("함초롬바탕 확장", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(837, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 136;
            this.button2.Text = "저장";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("함초롬바탕 확장", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(783, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 135;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_review_search
            // 
            this.button_review_search.Font = new System.Drawing.Font("함초롬바탕 확장", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_review_search.Location = new System.Drawing.Point(726, 28);
            this.button_review_search.Name = "button_review_search";
            this.button_review_search.Size = new System.Drawing.Size(51, 23);
            this.button_review_search.TabIndex = 134;
            this.button_review_search.Text = "입력";
            this.button_review_search.UseVisualStyleBackColor = true;
            this.button_review_search.Click += new System.EventHandler(this.button_review_search_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "E-Mart NewYork",
            "이마트 강남점",
            "이마트 대구점",
            "이마트 부산점",
            "이마트 평양점"});
            this.comboBox2.Location = new System.Drawing.Point(68, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 20);
            this.comboBox2.TabIndex = 133;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("함초롬바탕 확장", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(37, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 131;
            this.label2.Text = "재고현황 통계";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTORNAMEDataGridViewTextBoxColumn,
            this.pRODKINDDataGridViewTextBoxColumn,
            this.pRODIDDataGridViewTextBoxColumn,
            this.pRODNAMEDataGridViewTextBoxColumn,
            this.pRODPRICEDataGridViewTextBoxColumn,
            this.pRODCOUNTDataGridViewTextBoxColumn,
            this.oRDERCOUNTDataGridViewTextBoxColumn,
            this.rEFUNDCOUNTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTSBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(27, 63);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("함초롬바탕 확장", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(886, 191);
            this.dataGridView1.TabIndex = 132;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sTORNAMEDataGridViewTextBoxColumn
            // 
            this.sTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "STOR_NAME";
            this.sTORNAMEDataGridViewTextBoxColumn.HeaderText = "판매 매장";
            this.sTORNAMEDataGridViewTextBoxColumn.Name = "sTORNAMEDataGridViewTextBoxColumn";
            this.sTORNAMEDataGridViewTextBoxColumn.Width = 120;
            // 
            // pRODKINDDataGridViewTextBoxColumn
            // 
            this.pRODKINDDataGridViewTextBoxColumn.DataPropertyName = "PROD_KIND";
            this.pRODKINDDataGridViewTextBoxColumn.HeaderText = "분류";
            this.pRODKINDDataGridViewTextBoxColumn.Name = "pRODKINDDataGridViewTextBoxColumn";
            // 
            // pRODIDDataGridViewTextBoxColumn
            // 
            this.pRODIDDataGridViewTextBoxColumn.DataPropertyName = "PROD_ID";
            this.pRODIDDataGridViewTextBoxColumn.HeaderText = "상품 번호";
            this.pRODIDDataGridViewTextBoxColumn.Name = "pRODIDDataGridViewTextBoxColumn";
            // 
            // pRODNAMEDataGridViewTextBoxColumn
            // 
            this.pRODNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROD_NAME";
            this.pRODNAMEDataGridViewTextBoxColumn.HeaderText = "상품 이름";
            this.pRODNAMEDataGridViewTextBoxColumn.Name = "pRODNAMEDataGridViewTextBoxColumn";
            // 
            // pRODPRICEDataGridViewTextBoxColumn
            // 
            this.pRODPRICEDataGridViewTextBoxColumn.DataPropertyName = "PROD_PRICE";
            this.pRODPRICEDataGridViewTextBoxColumn.HeaderText = "상품 가격";
            this.pRODPRICEDataGridViewTextBoxColumn.Name = "pRODPRICEDataGridViewTextBoxColumn";
            // 
            // pRODCOUNTDataGridViewTextBoxColumn
            // 
            this.pRODCOUNTDataGridViewTextBoxColumn.DataPropertyName = "PROD_COUNT";
            this.pRODCOUNTDataGridViewTextBoxColumn.HeaderText = "판매가능 재고";
            this.pRODCOUNTDataGridViewTextBoxColumn.Name = "pRODCOUNTDataGridViewTextBoxColumn";
            this.pRODCOUNTDataGridViewTextBoxColumn.Width = 110;
            // 
            // oRDERCOUNTDataGridViewTextBoxColumn
            // 
            this.oRDERCOUNTDataGridViewTextBoxColumn.DataPropertyName = "ORDER_COUNT";
            this.oRDERCOUNTDataGridViewTextBoxColumn.HeaderText = "주문된 횟수";
            this.oRDERCOUNTDataGridViewTextBoxColumn.Name = "oRDERCOUNTDataGridViewTextBoxColumn";
            // 
            // rEFUNDCOUNTDataGridViewTextBoxColumn
            // 
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.DataPropertyName = "REFUND_COUNT";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.HeaderText = "환불된 횟수";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.Name = "rEFUNDCOUNTDataGridViewTextBoxColumn";
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.dataSet1;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
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
            // 상품관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(953, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_review_search);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "상품관리";
            this.Text = "상품관리";
            this.Load += new System.EventHandler(this.상품관리_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDPRODBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_review_search;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private DataSet1TableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.BindingSource oRDERDPRODBindingSource;
        private DataSet1TableAdapters.ORDERD_PRODTableAdapter oRDERD_PRODTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODKINDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDCOUNTDataGridViewTextBoxColumn;
    }
}