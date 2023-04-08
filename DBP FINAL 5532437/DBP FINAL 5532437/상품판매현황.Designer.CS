
namespace DBP_FINAL_5532437
{
    partial class 상품판매현황
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
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
            this.oRDERDPRODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DBP_FINAL_5532437.DataSet1();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.oRDERD_PRODTableAdapter = new DBP_FINAL_5532437.DataSet1TableAdapters.ORDERD_PRODTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDPRODBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("함초롬바탕 확장", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "E-Mart NewYork",
            "이마트 강남점",
            "이마트 대구점",
            "이마트 부산점",
            "이마트 평양점"});
            this.comboBox3.Location = new System.Drawing.Point(357, 53);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(120, 27);
            this.comboBox3.TabIndex = 166;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("함초롬바탕 확장", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView5.Location = new System.Drawing.Point(316, 52);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(959, 478);
            this.dataGridView5.TabIndex = 165;
            this.dataGridView5.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridView5_CellStateChanged);
            // 
            // sTORNAMEDataGridViewTextBoxColumn
            // 
            this.sTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "STOR_NAME";
            this.sTORNAMEDataGridViewTextBoxColumn.HeaderText = "매장";
            this.sTORNAMEDataGridViewTextBoxColumn.Name = "sTORNAMEDataGridViewTextBoxColumn";
            this.sTORNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTORNAMEDataGridViewTextBoxColumn.Width = 120;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "구매자ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            this.uSERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERIDDataGridViewTextBoxColumn.Width = 92;
            // 
            // oRDERIDDataGridViewTextBoxColumn
            // 
            this.oRDERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oRDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn.HeaderText = "주문번호";
            this.oRDERIDDataGridViewTextBoxColumn.Name = "oRDERIDDataGridViewTextBoxColumn";
            this.oRDERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // pRODIDDataGridViewTextBoxColumn
            // 
            this.pRODIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODIDDataGridViewTextBoxColumn.DataPropertyName = "PROD_ID";
            this.pRODIDDataGridViewTextBoxColumn.HeaderText = "상품번호";
            this.pRODIDDataGridViewTextBoxColumn.Name = "pRODIDDataGridViewTextBoxColumn";
            this.pRODIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // pRODNAMEDataGridViewTextBoxColumn
            // 
            this.pRODNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROD_NAME";
            this.pRODNAMEDataGridViewTextBoxColumn.HeaderText = "상품이름";
            this.pRODNAMEDataGridViewTextBoxColumn.Name = "pRODNAMEDataGridViewTextBoxColumn";
            this.pRODNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODNAMEDataGridViewTextBoxColumn.Width = 90;
            // 
            // pRODPRICEDataGridViewTextBoxColumn
            // 
            this.pRODPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODPRICEDataGridViewTextBoxColumn.DataPropertyName = "PROD_PRICE";
            this.pRODPRICEDataGridViewTextBoxColumn.HeaderText = "상품가격";
            this.pRODPRICEDataGridViewTextBoxColumn.Name = "pRODPRICEDataGridViewTextBoxColumn";
            this.pRODPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODPRICEDataGridViewTextBoxColumn.Width = 90;
            // 
            // oRDEROKDataGridViewTextBoxColumn
            // 
            this.oRDEROKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oRDEROKDataGridViewTextBoxColumn.DataPropertyName = "ORDER_OK";
            this.oRDEROKDataGridViewTextBoxColumn.HeaderText = "주문상태";
            this.oRDEROKDataGridViewTextBoxColumn.Name = "oRDEROKDataGridViewTextBoxColumn";
            this.oRDEROKDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDEROKDataGridViewTextBoxColumn.Width = 90;
            // 
            // pRODCOUNTDataGridViewTextBoxColumn
            // 
            this.pRODCOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODCOUNTDataGridViewTextBoxColumn.DataPropertyName = "PROD_COUNT";
            this.pRODCOUNTDataGridViewTextBoxColumn.HeaderText = "주문 수량";
            this.pRODCOUNTDataGridViewTextBoxColumn.Name = "pRODCOUNTDataGridViewTextBoxColumn";
            this.pRODCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODCOUNTDataGridViewTextBoxColumn.Width = 95;
            // 
            // tOTALPRICEDataGridViewTextBoxColumn
            // 
            this.tOTALPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tOTALPRICEDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_PRICE";
            this.tOTALPRICEDataGridViewTextBoxColumn.HeaderText = "결제금액";
            this.tOTALPRICEDataGridViewTextBoxColumn.Name = "tOTALPRICEDataGridViewTextBoxColumn";
            this.tOTALPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALPRICEDataGridViewTextBoxColumn.Width = 90;
            // 
            // sELLERIDDataGridViewTextBoxColumn
            // 
            this.sELLERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sELLERIDDataGridViewTextBoxColumn.DataPropertyName = "SELLER_ID";
            this.sELLERIDDataGridViewTextBoxColumn.HeaderText = "판매자ID";
            this.sELLERIDDataGridViewTextBoxColumn.Name = "sELLERIDDataGridViewTextBoxColumn";
            this.sELLERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sELLERIDDataGridViewTextBoxColumn.Width = 92;
            // 
            // oRDERDATEDataGridViewTextBoxColumn
            // 
            this.oRDERDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oRDERDATEDataGridViewTextBoxColumn.DataPropertyName = "ORDER_DATE";
            this.oRDERDATEDataGridViewTextBoxColumn.HeaderText = "주문일자";
            this.oRDERDATEDataGridViewTextBoxColumn.Name = "oRDERDATEDataGridViewTextBoxColumn";
            this.oRDERDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERDATEDataGridViewTextBoxColumn.Width = 90;
            // 
            // oRDERDPRODBindingSource
            // 
            this.oRDERDPRODBindingSource.DataMember = "ORDERD_PROD";
            this.oRDERDPRODBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("함초롬바탕 확장", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(328, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 24);
            this.label12.TabIndex = 164;
            this.label12.Text = "상품 판매액 현황";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 394);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 24);
            this.textBox1.TabIndex = 163;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.Font = new System.Drawing.Font("함초롬바탕 확장", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(31, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 24);
            this.label6.TabIndex = 162;
            this.label6.Text = "E-Mart NewYork";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("함초롬바탕 확장", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(75, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 161;
            this.label5.Text = "기간";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthCalendar1.Location = new System.Drawing.Point(53, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 160;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("함초롬바탕 확장", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(192, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 159;
            this.label4.Text = "가게 매출";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Linen;
            this.textBox2.Location = new System.Drawing.Point(31, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 204);
            this.textBox2.TabIndex = 167;
            // 
            // oRDERD_PRODTableAdapter
            // 
            this.oRDERD_PRODTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Linen;
            this.textBox3.Location = new System.Drawing.Point(29, 335);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 111);
            this.textBox3.TabIndex = 168;
            // 
            // 상품판매현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1307, 562);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Name = "상품판매현황";
            this.Text = "상품판매현황";
            this.Load += new System.EventHandler(this.상품판매현황_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDPRODBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource oRDERDPRODBindingSource;
        private DataSet1TableAdapters.ORDERD_PRODTableAdapter oRDERD_PRODTableAdapter;
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
        private System.Windows.Forms.TextBox textBox3;
    }
}