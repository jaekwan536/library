namespace library
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
            this.btnTest = new System.Windows.Forms.Button();
            this.txtView = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btnTestList = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(642, 394);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(117, 31);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "테스트";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(407, 22);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtView.Size = new System.Drawing.Size(579, 346);
            this.txtView.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(52, 63);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(260, 28);
            this.txt1.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(49, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 18);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "입력1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(49, 101);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(54, 18);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "입력2";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(52, 135);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(260, 28);
            this.txt2.TabIndex = 4;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(49, 177);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(54, 18);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "입력3";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(52, 211);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(260, 28);
            this.txt3.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(49, 254);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(54, 18);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "입력4";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(52, 288);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(260, 28);
            this.txt4.TabIndex = 8;
            // 
            // btnTestList
            // 
            this.btnTestList.Location = new System.Drawing.Point(899, 568);
            this.btnTestList.Name = "btnTestList";
            this.btnTestList.Size = new System.Drawing.Size(147, 80);
            this.btnTestList.TabIndex = 10;
            this.btnTestList.Text = "리스트 테스트";
            this.btnTestList.UseVisualStyleBackColor = true;
            this.btnTestList.Click += new System.EventHandler(this.btnTestList_Click);
            // 
            // lv1
            // 
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(52, 451);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(817, 292);
            this.lv1.TabIndex = 11;
            this.lv1.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(118, 337);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(117, 31);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "삽입";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 779);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.btnTestList);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btnTestList;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.Button btnInsert;
    }
}

