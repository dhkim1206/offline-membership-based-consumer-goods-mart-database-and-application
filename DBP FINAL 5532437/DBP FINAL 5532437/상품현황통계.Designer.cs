
namespace DBP_FINAL_5532437
{
    partial class 상품현황통계
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.STOR_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_KIND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFUND_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODKINDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DBP_FINAL_5532437.DataSet1();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nEWPRODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODREFUNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERDPRODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERD_PRODTableAdapter = new DBP_FINAL_5532437.DataSet1TableAdapters.ORDERD_PRODTableAdapter();
            this.pRODUCTSTableAdapter = new DBP_FINAL_5532437.DataSet1TableAdapters.PRODUCTSTableAdapter();
            this.pROD_REFUNDTableAdapter = new DBP_FINAL_5532437.DataSet1TableAdapters.PROD_REFUNDTableAdapter();
            this.newprodTableAdapter1 = new DBP_FINAL_5532437.DataSet1TableAdapters.NEWPRODTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWPRODBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODREFUNDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDPRODBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("함초롬바탕 확장", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(789, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 23);
            this.button5.TabIndex = 132;
            this.button5.Text = "필터";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(681, 299);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(102, 21);
            this.textBox6.TabIndex = 131;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(631, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 14);
            this.label11.TabIndex = 130;
            this.label11.Text = "상품ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("함초롬바탕 확장", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STOR_NAME,
            this.PROD_KIND,
            this.PROD_ID,
            this.PROD_NAME,
            this.PROD_PRICE,
            this.PROD_COUNT,
            this.ORDER_COUNT,
            this.REFUND_COUNT,
            this.pRODIDDataGridViewTextBoxColumn,
            this.sTORNAMEDataGridViewTextBoxColumn,
            this.pRODNAMEDataGridViewTextBoxColumn,
            this.pRODKINDDataGridViewTextBoxColumn,
            this.pRODPRICEDataGridViewTextBoxColumn,
            this.pRODCOUNTDataGridViewTextBoxColumn,
            this.oRDERCOUNTDataGridViewTextBoxColumn,
            this.rEFUNDCOUNTDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.pRODUCTSBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView4.Location = new System.Drawing.Point(22, 336);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView4.Size = new System.Drawing.Size(849, 178);
            this.dataGridView4.TabIndex = 134;
            // 
            // STOR_NAME
            // 
            this.STOR_NAME.DataPropertyName = "STOR_NAME";
            this.STOR_NAME.HeaderText = "매장";
            this.STOR_NAME.Name = "STOR_NAME";
            this.STOR_NAME.ReadOnly = true;
            // 
            // PROD_KIND
            // 
            this.PROD_KIND.DataPropertyName = "PROD_KIND";
            this.PROD_KIND.HeaderText = "분류";
            this.PROD_KIND.Name = "PROD_KIND";
            this.PROD_KIND.ReadOnly = true;
            // 
            // PROD_ID
            // 
            this.PROD_ID.DataPropertyName = "PROD_ID";
            this.PROD_ID.HeaderText = "상품ID";
            this.PROD_ID.Name = "PROD_ID";
            this.PROD_ID.ReadOnly = true;
            // 
            // PROD_NAME
            // 
            this.PROD_NAME.DataPropertyName = "PROD_NAME";
            this.PROD_NAME.HeaderText = "상품이름";
            this.PROD_NAME.Name = "PROD_NAME";
            this.PROD_NAME.ReadOnly = true;
            // 
            // PROD_PRICE
            // 
            this.PROD_PRICE.DataPropertyName = "PROD_PRICE";
            this.PROD_PRICE.HeaderText = "상품가격";
            this.PROD_PRICE.Name = "PROD_PRICE";
            this.PROD_PRICE.ReadOnly = true;
            // 
            // PROD_COUNT
            // 
            this.PROD_COUNT.DataPropertyName = "PROD_COUNT";
            this.PROD_COUNT.HeaderText = "재고 현황";
            this.PROD_COUNT.Name = "PROD_COUNT";
            this.PROD_COUNT.ReadOnly = true;
            // 
            // ORDER_COUNT
            // 
            this.ORDER_COUNT.DataPropertyName = "ORDER_COUNT";
            this.ORDER_COUNT.HeaderText = "주문 수";
            this.ORDER_COUNT.Name = "ORDER_COUNT";
            this.ORDER_COUNT.ReadOnly = true;
            // 
            // REFUND_COUNT
            // 
            this.REFUND_COUNT.DataPropertyName = "REFUND_COUNT";
            this.REFUND_COUNT.HeaderText = "환불 수";
            this.REFUND_COUNT.Name = "REFUND_COUNT";
            this.REFUND_COUNT.ReadOnly = true;
            // 
            // pRODIDDataGridViewTextBoxColumn
            // 
            this.pRODIDDataGridViewTextBoxColumn.DataPropertyName = "PROD_ID";
            this.pRODIDDataGridViewTextBoxColumn.HeaderText = "PROD_ID";
            this.pRODIDDataGridViewTextBoxColumn.Name = "pRODIDDataGridViewTextBoxColumn";
            this.pRODIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTORNAMEDataGridViewTextBoxColumn
            // 
            this.sTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "STOR_NAME";
            this.sTORNAMEDataGridViewTextBoxColumn.HeaderText = "STOR_NAME";
            this.sTORNAMEDataGridViewTextBoxColumn.Name = "sTORNAMEDataGridViewTextBoxColumn";
            this.sTORNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODNAMEDataGridViewTextBoxColumn
            // 
            this.pRODNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROD_NAME";
            this.pRODNAMEDataGridViewTextBoxColumn.HeaderText = "PROD_NAME";
            this.pRODNAMEDataGridViewTextBoxColumn.Name = "pRODNAMEDataGridViewTextBoxColumn";
            this.pRODNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODKINDDataGridViewTextBoxColumn
            // 
            this.pRODKINDDataGridViewTextBoxColumn.DataPropertyName = "PROD_KIND";
            this.pRODKINDDataGridViewTextBoxColumn.HeaderText = "PROD_KIND";
            this.pRODKINDDataGridViewTextBoxColumn.Name = "pRODKINDDataGridViewTextBoxColumn";
            this.pRODKINDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODPRICEDataGridViewTextBoxColumn
            // 
            this.pRODPRICEDataGridViewTextBoxColumn.DataPropertyName = "PROD_PRICE";
            this.pRODPRICEDataGridViewTextBoxColumn.HeaderText = "PROD_PRICE";
            this.pRODPRICEDataGridViewTextBoxColumn.Name = "pRODPRICEDataGridViewTextBoxColumn";
            this.pRODPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODCOUNTDataGridViewTextBoxColumn
            // 
            this.pRODCOUNTDataGridViewTextBoxColumn.DataPropertyName = "PROD_COUNT";
            this.pRODCOUNTDataGridViewTextBoxColumn.HeaderText = "PROD_COUNT";
            this.pRODCOUNTDataGridViewTextBoxColumn.Name = "pRODCOUNTDataGridViewTextBoxColumn";
            this.pRODCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRDERCOUNTDataGridViewTextBoxColumn
            // 
            this.oRDERCOUNTDataGridViewTextBoxColumn.DataPropertyName = "ORDER_COUNT";
            this.oRDERCOUNTDataGridViewTextBoxColumn.HeaderText = "ORDER_COUNT";
            this.oRDERCOUNTDataGridViewTextBoxColumn.Name = "oRDERCOUNTDataGridViewTextBoxColumn";
            this.oRDERCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEFUNDCOUNTDataGridViewTextBoxColumn
            // 
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.DataPropertyName = "REFUND_COUNT";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.HeaderText = "REFUND_COUNT";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.Name = "rEFUNDCOUNTDataGridViewTextBoxColumn";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.SystemColors.HighlightText;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.nEWPRODBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(29, 30);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.Legend = "Legend1";
            series1.Name = "주문 수";
            series1.XValueMember = "PROD_ID";
            series1.YValueMembers = "ORDER_COUNT";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(413, 232);
            this.chart1.TabIndex = 133;
            this.chart1.Text = "chart1";
            this.chart1.UseWaitCursor = true;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // nEWPRODBindingSource
            // 
            this.nEWPRODBindingSource.DataMember = "NEWPROD";
            this.nEWPRODBindingSource.DataSource = this.dataSet1;
            // 
            // pRODREFUNDBindingSource
            // 
            this.pRODREFUNDBindingSource.DataMember = "PROD_REFUND";
            this.pRODREFUNDBindingSource.DataSource = this.dataSet1;
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
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // pROD_REFUNDTableAdapter
            // 
            this.pROD_REFUNDTableAdapter.ClearBeforeFill = true;
            // 
            // newprodTableAdapter1
            // 
            this.newprodTableAdapter1.ClearBeforeFill = true;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.pRODREFUNDBindingSource;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(441, 30);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.SystemColors.ControlDarkDark;
            series2.Legend = "Legend1";
            series2.Name = "환불 수";
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.XValueMember = "PROD_ID";
            series2.YValueMembers = "REFUND_COUNT";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(436, 232);
            this.chart2.TabIndex = 135;
            this.chart2.Text = "chart2";
            // 
            // 상품현황통계
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 548);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Name = "상품현황통계";
            this.Text = "상품현황통계";
            this.Load += new System.EventHandler(this.상품현황통계_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWPRODBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODREFUNDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDPRODBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nEWPRODBindingSource;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource oRDERDPRODBindingSource;
        private DataSet1TableAdapters.ORDERD_PRODTableAdapter oRDERD_PRODTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private DataSet1TableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.BindingSource pRODREFUNDBindingSource;
        private DataSet1TableAdapters.PROD_REFUNDTableAdapter pROD_REFUNDTableAdapter;
        private DataSet1TableAdapters.NEWPRODTableAdapter newprodTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOR_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_KIND;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFUND_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODKINDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}