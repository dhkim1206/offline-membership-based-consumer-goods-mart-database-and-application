
namespace DBP_FINAL_5532437
{
    partial class 사용자_공지사항
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nOTICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DBP_FINAL_5532437.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_notice_content = new System.Windows.Forms.TextBox();
            this.textBox_notice_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nOTICETableAdapter = new DBP_FINAL_5532437.DataSet1TableAdapters.NOTICETableAdapter();
            this.nOTICEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTICETITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTICECONTENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("함초롬바탕 확장", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOTICEIDDataGridViewTextBoxColumn,
            this.nOTICETITLEDataGridViewTextBoxColumn,
            this.nOTICECONTENTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nOTICEBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(23, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(389, 141);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nOTICEBindingSource
            // 
            this.nOTICEBindingSource.DataMember = "NOTICE";
            this.nOTICEBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "제목";
            // 
            // textBox_notice_content
            // 
            this.textBox_notice_content.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_notice_content.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_notice_content.Location = new System.Drawing.Point(28, 266);
            this.textBox_notice_content.Multiline = true;
            this.textBox_notice_content.Name = "textBox_notice_content";
            this.textBox_notice_content.ReadOnly = true;
            this.textBox_notice_content.Size = new System.Drawing.Size(746, 169);
            this.textBox_notice_content.TabIndex = 96;
            // 
            // textBox_notice_title
            // 
            this.textBox_notice_title.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_notice_title.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_notice_title.Location = new System.Drawing.Point(72, 233);
            this.textBox_notice_title.Multiline = true;
            this.textBox_notice_title.Name = "textBox_notice_title";
            this.textBox_notice_title.ReadOnly = true;
            this.textBox_notice_title.Size = new System.Drawing.Size(702, 21);
            this.textBox_notice_title.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 99;
            this.label1.Text = "공지사항 리스트";
            // 
            // nOTICETableAdapter
            // 
            this.nOTICETableAdapter.ClearBeforeFill = true;
            // 
            // nOTICEIDDataGridViewTextBoxColumn
            // 
            this.nOTICEIDDataGridViewTextBoxColumn.DataPropertyName = "NOTICE_ID";
            this.nOTICEIDDataGridViewTextBoxColumn.HeaderText = "공지사항 번호";
            this.nOTICEIDDataGridViewTextBoxColumn.Name = "nOTICEIDDataGridViewTextBoxColumn";
            this.nOTICEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTICEIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // nOTICETITLEDataGridViewTextBoxColumn
            // 
            this.nOTICETITLEDataGridViewTextBoxColumn.DataPropertyName = "NOTICE_TITLE";
            this.nOTICETITLEDataGridViewTextBoxColumn.HeaderText = "제목";
            this.nOTICETITLEDataGridViewTextBoxColumn.Name = "nOTICETITLEDataGridViewTextBoxColumn";
            this.nOTICETITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOTICECONTENTDataGridViewTextBoxColumn
            // 
            this.nOTICECONTENTDataGridViewTextBoxColumn.DataPropertyName = "NOTICE_CONTENT";
            this.nOTICECONTENTDataGridViewTextBoxColumn.HeaderText = "내용";
            this.nOTICECONTENTDataGridViewTextBoxColumn.Name = "nOTICECONTENTDataGridViewTextBoxColumn";
            this.nOTICECONTENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 사용자_공지사항
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_notice_content);
            this.Controls.Add(this.textBox_notice_title);
            this.Name = "사용자_공지사항";
            this.Text = "사용자_공지사항";
            this.Load += new System.EventHandler(this.사용자_공지사항_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_notice_content;
        private System.Windows.Forms.TextBox textBox_notice_title;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nOTICEBindingSource;
        private DataSet1TableAdapters.NOTICETableAdapter nOTICETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTICEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTICETITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTICECONTENTDataGridViewTextBoxColumn;
    }
}