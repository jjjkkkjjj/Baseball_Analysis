namespace Baseball_Analysis
{
    partial class SetStartingMember
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
            this.next_write_score = new System.Windows.Forms.Button();
            this.label_teamA = new System.Windows.Forms.Label();
            this.label_teamB = new System.Windows.Forms.Label();
            this.textBox_teamA = new System.Windows.Forms.TextBox();
            this.textBox_teamB = new System.Windows.Forms.TextBox();
            this.comboBox_position_teamA = new System.Windows.Forms.ComboBox();
            this.comboBox_position_teamB = new System.Windows.Forms.ComboBox();
            this.listBox_batter_teamA = new System.Windows.Forms.ListBox();
            this.listBox_batter_teamB = new System.Windows.Forms.ListBox();
            this.listBox_pitcher_teamA = new System.Windows.Forms.ListBox();
            this.listBox_pitcher_teamB = new System.Windows.Forms.ListBox();
            this.button_add_teamA = new System.Windows.Forms.Button();
            this.button_delete_teamA = new System.Windows.Forms.Button();
            this.button_add_teamB = new System.Windows.Forms.Button();
            this.button_delete_teamB = new System.Windows.Forms.Button();
            this.buck_teamselect = new System.Windows.Forms.Button();
            this.checkBox_unlockDH_teamA = new System.Windows.Forms.CheckBox();
            this.checkBox_unlockDH_teamB = new System.Windows.Forms.CheckBox();
            this.button_read_from_fileA = new System.Windows.Forms.Button();
            this.button_read_from_fileB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // next_write_score
            // 
            this.next_write_score.Location = new System.Drawing.Point(487, 316);
            this.next_write_score.Name = "next_write_score";
            this.next_write_score.Size = new System.Drawing.Size(75, 23);
            this.next_write_score.TabIndex = 6;
            this.next_write_score.Text = "next";
            this.next_write_score.UseVisualStyleBackColor = true;
            this.next_write_score.Click += new System.EventHandler(this.next_write_score_Click);
            // 
            // label_teamA
            // 
            this.label_teamA.AutoSize = true;
            this.label_teamA.Location = new System.Drawing.Point(72, 78);
            this.label_teamA.Name = "label_teamA";
            this.label_teamA.Size = new System.Drawing.Size(38, 12);
            this.label_teamA.TabIndex = 7;
            this.label_teamA.Text = "teamA";
            // 
            // label_teamB
            // 
            this.label_teamB.AutoSize = true;
            this.label_teamB.Location = new System.Drawing.Point(338, 78);
            this.label_teamB.Name = "label_teamB";
            this.label_teamB.Size = new System.Drawing.Size(38, 12);
            this.label_teamB.TabIndex = 8;
            this.label_teamB.Text = "teamB";
            // 
            // textBox_teamA
            // 
            this.textBox_teamA.Location = new System.Drawing.Point(74, 105);
            this.textBox_teamA.Name = "textBox_teamA";
            this.textBox_teamA.Size = new System.Drawing.Size(120, 19);
            this.textBox_teamA.TabIndex = 9;
            // 
            // textBox_teamB
            // 
            this.textBox_teamB.Location = new System.Drawing.Point(340, 105);
            this.textBox_teamB.Name = "textBox_teamB";
            this.textBox_teamB.Size = new System.Drawing.Size(120, 19);
            this.textBox_teamB.TabIndex = 10;
            // 
            // comboBox_position_teamA
            // 
            this.comboBox_position_teamA.FormattingEnabled = true;
            this.comboBox_position_teamA.Location = new System.Drawing.Point(200, 104);
            this.comboBox_position_teamA.Name = "comboBox_position_teamA";
            this.comboBox_position_teamA.Size = new System.Drawing.Size(35, 20);
            this.comboBox_position_teamA.TabIndex = 11;
            // 
            // comboBox_position_teamB
            // 
            this.comboBox_position_teamB.FormattingEnabled = true;
            this.comboBox_position_teamB.Location = new System.Drawing.Point(466, 105);
            this.comboBox_position_teamB.Name = "comboBox_position_teamB";
            this.comboBox_position_teamB.Size = new System.Drawing.Size(35, 20);
            this.comboBox_position_teamB.TabIndex = 12;
            // 
            // listBox_batter_teamA
            // 
            this.listBox_batter_teamA.FormattingEnabled = true;
            this.listBox_batter_teamA.ItemHeight = 12;
            this.listBox_batter_teamA.Location = new System.Drawing.Point(74, 196);
            this.listBox_batter_teamA.Name = "listBox_batter_teamA";
            this.listBox_batter_teamA.Size = new System.Drawing.Size(120, 88);
            this.listBox_batter_teamA.TabIndex = 13;
            // 
            // listBox_batter_teamB
            // 
            this.listBox_batter_teamB.FormattingEnabled = true;
            this.listBox_batter_teamB.ItemHeight = 12;
            this.listBox_batter_teamB.Location = new System.Drawing.Point(340, 196);
            this.listBox_batter_teamB.Name = "listBox_batter_teamB";
            this.listBox_batter_teamB.Size = new System.Drawing.Size(120, 88);
            this.listBox_batter_teamB.TabIndex = 14;
            // 
            // listBox_pitcher_teamA
            // 
            this.listBox_pitcher_teamA.FormattingEnabled = true;
            this.listBox_pitcher_teamA.ItemHeight = 12;
            this.listBox_pitcher_teamA.Location = new System.Drawing.Point(74, 295);
            this.listBox_pitcher_teamA.Name = "listBox_pitcher_teamA";
            this.listBox_pitcher_teamA.Size = new System.Drawing.Size(120, 16);
            this.listBox_pitcher_teamA.TabIndex = 15;
            // 
            // listBox_pitcher_teamB
            // 
            this.listBox_pitcher_teamB.FormattingEnabled = true;
            this.listBox_pitcher_teamB.ItemHeight = 12;
            this.listBox_pitcher_teamB.Location = new System.Drawing.Point(340, 295);
            this.listBox_pitcher_teamB.Name = "listBox_pitcher_teamB";
            this.listBox_pitcher_teamB.Size = new System.Drawing.Size(120, 16);
            this.listBox_pitcher_teamB.TabIndex = 16;
            // 
            // button_add_teamA
            // 
            this.button_add_teamA.Location = new System.Drawing.Point(74, 146);
            this.button_add_teamA.Name = "button_add_teamA";
            this.button_add_teamA.Size = new System.Drawing.Size(45, 23);
            this.button_add_teamA.TabIndex = 17;
            this.button_add_teamA.Text = "Add";
            this.button_add_teamA.UseVisualStyleBackColor = true;
            this.button_add_teamA.Click += new System.EventHandler(this.button_add_teamA_Click);
            // 
            // button_delete_teamA
            // 
            this.button_delete_teamA.Location = new System.Drawing.Point(149, 146);
            this.button_delete_teamA.Name = "button_delete_teamA";
            this.button_delete_teamA.Size = new System.Drawing.Size(45, 23);
            this.button_delete_teamA.TabIndex = 18;
            this.button_delete_teamA.Text = "Del";
            this.button_delete_teamA.UseVisualStyleBackColor = true;
            this.button_delete_teamA.Click += new System.EventHandler(this.button_delete_teamA_Click);
            // 
            // button_add_teamB
            // 
            this.button_add_teamB.Location = new System.Drawing.Point(340, 146);
            this.button_add_teamB.Name = "button_add_teamB";
            this.button_add_teamB.Size = new System.Drawing.Size(45, 23);
            this.button_add_teamB.TabIndex = 19;
            this.button_add_teamB.Text = "Add";
            this.button_add_teamB.UseVisualStyleBackColor = true;
            this.button_add_teamB.Click += new System.EventHandler(this.button_add_teamB_Click);
            // 
            // button_delete_teamB
            // 
            this.button_delete_teamB.Location = new System.Drawing.Point(415, 146);
            this.button_delete_teamB.Name = "button_delete_teamB";
            this.button_delete_teamB.Size = new System.Drawing.Size(45, 23);
            this.button_delete_teamB.TabIndex = 20;
            this.button_delete_teamB.Text = "Del";
            this.button_delete_teamB.UseVisualStyleBackColor = true;
            this.button_delete_teamB.Click += new System.EventHandler(this.button_delete_teamB_Click);
            // 
            // buck_teamselect
            // 
            this.buck_teamselect.Location = new System.Drawing.Point(406, 316);
            this.buck_teamselect.Name = "buck_teamselect";
            this.buck_teamselect.Size = new System.Drawing.Size(75, 23);
            this.buck_teamselect.TabIndex = 21;
            this.buck_teamselect.Text = "buck";
            this.buck_teamselect.UseVisualStyleBackColor = true;
            this.buck_teamselect.Click += new System.EventHandler(this.buck_teamselect_Click);
            // 
            // checkBox_unlockDH_teamA
            // 
            this.checkBox_unlockDH_teamA.AutoSize = true;
            this.checkBox_unlockDH_teamA.Location = new System.Drawing.Point(74, 45);
            this.checkBox_unlockDH_teamA.Name = "checkBox_unlockDH_teamA";
            this.checkBox_unlockDH_teamA.Size = new System.Drawing.Size(79, 16);
            this.checkBox_unlockDH_teamA.TabIndex = 22;
            this.checkBox_unlockDH_teamA.Text = "Unlock DH";
            this.checkBox_unlockDH_teamA.UseVisualStyleBackColor = true;
            this.checkBox_unlockDH_teamA.CheckedChanged += new System.EventHandler(this.checkBox_unlockDH_teamA_CheckedChanged);
            // 
            // checkBox_unlockDH_teamB
            // 
            this.checkBox_unlockDH_teamB.AutoSize = true;
            this.checkBox_unlockDH_teamB.Location = new System.Drawing.Point(340, 45);
            this.checkBox_unlockDH_teamB.Name = "checkBox_unlockDH_teamB";
            this.checkBox_unlockDH_teamB.Size = new System.Drawing.Size(79, 16);
            this.checkBox_unlockDH_teamB.TabIndex = 23;
            this.checkBox_unlockDH_teamB.Text = "Unlock DH";
            this.checkBox_unlockDH_teamB.UseVisualStyleBackColor = true;
            this.checkBox_unlockDH_teamB.CheckedChanged += new System.EventHandler(this.checkBox_unlockDH_teamB_CheckedChanged);
            // 
            // button_read_from_fileA
            // 
            this.button_read_from_fileA.Location = new System.Drawing.Point(200, 196);
            this.button_read_from_fileA.Name = "button_read_from_fileA";
            this.button_read_from_fileA.Size = new System.Drawing.Size(75, 23);
            this.button_read_from_fileA.TabIndex = 24;
            this.button_read_from_fileA.Text = "read";
            this.button_read_from_fileA.UseVisualStyleBackColor = true;
            this.button_read_from_fileA.Click += new System.EventHandler(this.button_read_from_fileA_Click);
            // 
            // button_read_from_fileB
            // 
            this.button_read_from_fileB.Location = new System.Drawing.Point(466, 196);
            this.button_read_from_fileB.Name = "button_read_from_fileB";
            this.button_read_from_fileB.Size = new System.Drawing.Size(75, 23);
            this.button_read_from_fileB.TabIndex = 25;
            this.button_read_from_fileB.Text = "read";
            this.button_read_from_fileB.UseVisualStyleBackColor = true;
            this.button_read_from_fileB.Click += new System.EventHandler(this.button_read_from_fileB_Click);
            // 
            // SetStartingMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_read_from_fileB);
            this.Controls.Add(this.button_read_from_fileA);
            this.Controls.Add(this.checkBox_unlockDH_teamB);
            this.Controls.Add(this.checkBox_unlockDH_teamA);
            this.Controls.Add(this.buck_teamselect);
            this.Controls.Add(this.button_delete_teamB);
            this.Controls.Add(this.button_add_teamB);
            this.Controls.Add(this.button_delete_teamA);
            this.Controls.Add(this.button_add_teamA);
            this.Controls.Add(this.listBox_pitcher_teamB);
            this.Controls.Add(this.listBox_pitcher_teamA);
            this.Controls.Add(this.listBox_batter_teamB);
            this.Controls.Add(this.listBox_batter_teamA);
            this.Controls.Add(this.comboBox_position_teamB);
            this.Controls.Add(this.comboBox_position_teamA);
            this.Controls.Add(this.textBox_teamB);
            this.Controls.Add(this.textBox_teamA);
            this.Controls.Add(this.label_teamB);
            this.Controls.Add(this.label_teamA);
            this.Controls.Add(this.next_write_score);
            this.Name = "SetStartingMember";
            this.Size = new System.Drawing.Size(584, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next_write_score;
        private System.Windows.Forms.Label label_teamA;
        private System.Windows.Forms.Label label_teamB;
        private System.Windows.Forms.TextBox textBox_teamA;
        private System.Windows.Forms.TextBox textBox_teamB;
        private System.Windows.Forms.ComboBox comboBox_position_teamA;
        private System.Windows.Forms.ComboBox comboBox_position_teamB;
        private System.Windows.Forms.ListBox listBox_batter_teamA;
        private System.Windows.Forms.ListBox listBox_batter_teamB;
        private System.Windows.Forms.ListBox listBox_pitcher_teamA;
        private System.Windows.Forms.ListBox listBox_pitcher_teamB;
        private System.Windows.Forms.Button button_add_teamA;
        private System.Windows.Forms.Button button_delete_teamA;
        private System.Windows.Forms.Button button_add_teamB;
        private System.Windows.Forms.Button button_delete_teamB;
        private System.Windows.Forms.Button buck_teamselect;
        private System.Windows.Forms.CheckBox checkBox_unlockDH_teamA;
        private System.Windows.Forms.CheckBox checkBox_unlockDH_teamB;
        private System.Windows.Forms.Button button_read_from_fileA;
        private System.Windows.Forms.Button button_read_from_fileB;
    }
}
