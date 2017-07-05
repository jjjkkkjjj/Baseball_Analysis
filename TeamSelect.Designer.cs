namespace Baseball_Analysis
{
    partial class TeamSelect
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_teamA = new System.Windows.Forms.TextBox();
            this.textBox_teamB = new System.Windows.Forms.TextBox();
            this.VS = new System.Windows.Forms.Label();
            this.label_teamA = new System.Windows.Forms.Label();
            this.label_teamB = new System.Windows.Forms.Label();
            this.next_stamem = new System.Windows.Forms.Button();
            this.Enter_FirstTeam = new System.Windows.Forms.Button();
            this.Enter_SecondTeam = new System.Windows.Forms.Button();
            this.score_teamA = new System.Windows.Forms.Label();
            this.score_teamB = new System.Windows.Forms.Label();
            this.label_first = new System.Windows.Forms.Label();
            this.label_second = new System.Windows.Forms.Label();
            this.open_teamA = new System.Windows.Forms.Button();
            this.open_teamB = new System.Windows.Forms.Button();
            this.openFileDialog_teamA = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_teamB = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_teamA
            // 
            this.textBox_teamA.Location = new System.Drawing.Point(103, 41);
            this.textBox_teamA.Name = "textBox_teamA";
            this.textBox_teamA.Size = new System.Drawing.Size(100, 19);
            this.textBox_teamA.TabIndex = 0;
            // 
            // textBox_teamB
            // 
            this.textBox_teamB.Location = new System.Drawing.Point(369, 41);
            this.textBox_teamB.Name = "textBox_teamB";
            this.textBox_teamB.Size = new System.Drawing.Size(100, 19);
            this.textBox_teamB.TabIndex = 1;
            // 
            // VS
            // 
            this.VS.AutoSize = true;
            this.VS.Location = new System.Drawing.Point(267, 48);
            this.VS.Name = "VS";
            this.VS.Size = new System.Drawing.Size(20, 12);
            this.VS.TabIndex = 2;
            this.VS.Text = "VS";
            // 
            // label_teamA
            // 
            this.label_teamA.AutoSize = true;
            this.label_teamA.Location = new System.Drawing.Point(103, 104);
            this.label_teamA.Name = "label_teamA";
            this.label_teamA.Size = new System.Drawing.Size(41, 12);
            this.label_teamA.TabIndex = 3;
            this.label_teamA.Text = "TeamA";
            // 
            // label_teamB
            // 
            this.label_teamB.AutoSize = true;
            this.label_teamB.Location = new System.Drawing.Point(369, 104);
            this.label_teamB.Name = "label_teamB";
            this.label_teamB.Size = new System.Drawing.Size(41, 12);
            this.label_teamB.TabIndex = 4;
            this.label_teamB.Text = "TeamB";
            // 
            // next_stamem
            // 
            this.next_stamem.Location = new System.Drawing.Point(487, 316);
            this.next_stamem.Name = "next_stamem";
            this.next_stamem.Size = new System.Drawing.Size(75, 23);
            this.next_stamem.TabIndex = 5;
            this.next_stamem.Text = "next";
            this.next_stamem.UseVisualStyleBackColor = true;
            this.next_stamem.Click += new System.EventHandler(this.next_write_score_Click);
            // 
            // Enter_FirstTeam
            // 
            this.Enter_FirstTeam.Location = new System.Drawing.Point(105, 67);
            this.Enter_FirstTeam.Name = "Enter_FirstTeam";
            this.Enter_FirstTeam.Size = new System.Drawing.Size(75, 23);
            this.Enter_FirstTeam.TabIndex = 6;
            this.Enter_FirstTeam.Text = "Enter";
            this.Enter_FirstTeam.UseVisualStyleBackColor = true;
            this.Enter_FirstTeam.Click += new System.EventHandler(this.Enter_FirstTeam_Click);
            // 
            // Enter_SecondTeam
            // 
            this.Enter_SecondTeam.Location = new System.Drawing.Point(369, 67);
            this.Enter_SecondTeam.Name = "Enter_SecondTeam";
            this.Enter_SecondTeam.Size = new System.Drawing.Size(75, 23);
            this.Enter_SecondTeam.TabIndex = 7;
            this.Enter_SecondTeam.Text = "Enter";
            this.Enter_SecondTeam.UseVisualStyleBackColor = true;
            this.Enter_SecondTeam.Click += new System.EventHandler(this.Enter_SecondTeam_Click);
            // 
            // score_teamA
            // 
            this.score_teamA.AutoSize = true;
            this.score_teamA.Location = new System.Drawing.Point(105, 134);
            this.score_teamA.Name = "score_teamA";
            this.score_teamA.Size = new System.Drawing.Size(36, 12);
            this.score_teamA.TabIndex = 8;
            this.score_teamA.Text = "DATA";
            // 
            // score_teamB
            // 
            this.score_teamB.AutoSize = true;
            this.score_teamB.Location = new System.Drawing.Point(371, 134);
            this.score_teamB.Name = "score_teamB";
            this.score_teamB.Size = new System.Drawing.Size(36, 12);
            this.score_teamB.TabIndex = 9;
            this.score_teamB.Text = "DATA";
            // 
            // label_first
            // 
            this.label_first.AutoSize = true;
            this.label_first.Location = new System.Drawing.Point(103, 23);
            this.label_first.Name = "label_first";
            this.label_first.Size = new System.Drawing.Size(51, 12);
            this.label_first.TabIndex = 10;
            this.label_first.Text = "First Bat";
            // 
            // label_second
            // 
            this.label_second.AutoSize = true;
            this.label_second.Location = new System.Drawing.Point(367, 23);
            this.label_second.Name = "label_second";
            this.label_second.Size = new System.Drawing.Size(64, 12);
            this.label_second.TabIndex = 11;
            this.label_second.Text = "Second Bat";
            // 
            // open_teamA
            // 
            this.open_teamA.Location = new System.Drawing.Point(209, 39);
            this.open_teamA.Name = "open_teamA";
            this.open_teamA.Size = new System.Drawing.Size(29, 23);
            this.open_teamA.TabIndex = 12;
            this.open_teamA.Text = "...";
            this.open_teamA.UseVisualStyleBackColor = true;
            this.open_teamA.Click += new System.EventHandler(this.open_teamA_Click);
            // 
            // open_teamB
            // 
            this.open_teamB.Location = new System.Drawing.Point(475, 41);
            this.open_teamB.Name = "open_teamB";
            this.open_teamB.Size = new System.Drawing.Size(29, 23);
            this.open_teamB.TabIndex = 13;
            this.open_teamB.Text = "...";
            this.open_teamB.UseVisualStyleBackColor = true;
            this.open_teamB.Click += new System.EventHandler(this.open_teamB_Click);
            // 
            // openFileDialog_teamA
            // 
            this.openFileDialog_teamA.FileName = "openFileDialog_teamA";
            // 
            // openFileDialog_teamB
            // 
            this.openFileDialog_teamB.FileName = "openFileDialog_teamB";
            // 
            // TeamSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.open_teamB);
            this.Controls.Add(this.open_teamA);
            this.Controls.Add(this.label_second);
            this.Controls.Add(this.label_first);
            this.Controls.Add(this.score_teamB);
            this.Controls.Add(this.score_teamA);
            this.Controls.Add(this.Enter_SecondTeam);
            this.Controls.Add(this.Enter_FirstTeam);
            this.Controls.Add(this.next_stamem);
            this.Controls.Add(this.label_teamB);
            this.Controls.Add(this.label_teamA);
            this.Controls.Add(this.VS);
            this.Controls.Add(this.textBox_teamB);
            this.Controls.Add(this.textBox_teamA);
            this.Name = "TeamSelect";
            this.Size = new System.Drawing.Size(584, 361);
            this.Load += new System.EventHandler(this.TeamSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_teamA;
        private System.Windows.Forms.TextBox textBox_teamB;
        private System.Windows.Forms.Label VS;
        private System.Windows.Forms.Label label_teamA;
        private System.Windows.Forms.Label label_teamB;
        private System.Windows.Forms.Button next_stamem;
        private System.Windows.Forms.Button Enter_FirstTeam;
        private System.Windows.Forms.Button Enter_SecondTeam;
        private System.Windows.Forms.Label score_teamA;
        private System.Windows.Forms.Label score_teamB;
        private System.Windows.Forms.Label label_first;
        private System.Windows.Forms.Label label_second;
        private System.Windows.Forms.Button open_teamA;
        private System.Windows.Forms.Button open_teamB;
        private System.Windows.Forms.OpenFileDialog openFileDialog_teamA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_teamB;
    }
}
