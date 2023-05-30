
namespace Attendance
{
    partial class Form1
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
            this.DTP_DT = new System.Windows.Forms.DateTimePicker();
            this.BTN_Select = new System.Windows.Forms.Button();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.access = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP_DT
            // 
            this.DTP_DT.Location = new System.Drawing.Point(30, 15);
            this.DTP_DT.Name = "DTP_DT";
            this.DTP_DT.Size = new System.Drawing.Size(171, 21);
            this.DTP_DT.TabIndex = 0;
            this.DTP_DT.Value = new System.DateTime(2023, 5, 17, 17, 42, 0, 0);
            // 
            // BTN_Select
            // 
            this.BTN_Select.Location = new System.Drawing.Point(448, 13);
            this.BTN_Select.Name = "BTN_Select";
            this.BTN_Select.Size = new System.Drawing.Size(75, 23);
            this.BTN_Select.TabIndex = 1;
            this.BTN_Select.Text = "검색";
            this.BTN_Select.UseVisualStyleBackColor = true;
            this.BTN_Select.Click += new System.EventHandler(this.BTN_Select_Click);
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(326, 13);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(100, 21);
            this.TB_NAME.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DT,
            this.NAME,
            this.Part,
            this.access});
            this.dataGridView1.Location = new System.Drawing.Point(30, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(493, 341);
            this.dataGridView1.TabIndex = 3;
            // 
            // DT
            // 
            this.DT.HeaderText = "날짜";
            this.DT.Name = "DT";
            this.DT.Width = 150;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "이름";
            this.NAME.Name = "NAME";
            // 
            // Part
            // 
            this.Part.HeaderText = "부서";
            this.Part.Name = "Part";
            // 
            // access
            // 
            this.access.HeaderText = "출입 단말기";
            this.access.Name = "access";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "이름 : ";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(448, 42);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(75, 23);
            this.BTN_Clear.TabIndex = 6;
            this.BTN_Clear.Text = "초기화";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.BTN_Select);
            this.Controls.Add(this.DTP_DT);
            this.Name = "Form1";
            this.Text = "근태이력";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_DT;
        private System.Windows.Forms.Button BTN_Select;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part;
        private System.Windows.Forms.DataGridViewTextBoxColumn access;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Clear;
    }
}

