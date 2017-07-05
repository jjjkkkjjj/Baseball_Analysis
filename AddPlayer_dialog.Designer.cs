namespace Baseball_Analysis
{
    partial class AddPlayer_dialog
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
            this.button_yes = new System.Windows.Forms.Button();
            this.button_no = new System.Windows.Forms.Button();
            this.label_bucknumber = new System.Windows.Forms.Label();
            this.comboBox_pitch = new System.Windows.Forms.ComboBox();
            this.textBox_bucknumber = new System.Windows.Forms.TextBox();
            this.comboBox_bat = new System.Windows.Forms.ComboBox();
            this.label_pitch = new System.Windows.Forms.Label();
            this.label_bat = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_yes
            // 
            this.button_yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button_yes.Location = new System.Drawing.Point(41, 204);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(75, 23);
            this.button_yes.TabIndex = 0;
            this.button_yes.Text = "Yes";
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // button_no
            // 
            this.button_no.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_no.Location = new System.Drawing.Point(164, 204);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(75, 23);
            this.button_no.TabIndex = 1;
            this.button_no.Text = "No";
            this.button_no.UseVisualStyleBackColor = true;
            // 
            // label_bucknumber
            // 
            this.label_bucknumber.AutoSize = true;
            this.label_bucknumber.Location = new System.Drawing.Point(39, 50);
            this.label_bucknumber.Name = "label_bucknumber";
            this.label_bucknumber.Size = new System.Drawing.Size(72, 12);
            this.label_bucknumber.TabIndex = 2;
            this.label_bucknumber.Text = "Buck number";
            // 
            // comboBox_pitch
            // 
            this.comboBox_pitch.FormattingEnabled = true;
            this.comboBox_pitch.Location = new System.Drawing.Point(117, 83);
            this.comboBox_pitch.Name = "comboBox_pitch";
            this.comboBox_pitch.Size = new System.Drawing.Size(62, 20);
            this.comboBox_pitch.TabIndex = 3;
            this.comboBox_pitch.SelectedIndexChanged += new System.EventHandler(this.comboBox_pitch_SelectedIndexChanged);
            // 
            // textBox_bucknumber
            // 
            this.textBox_bucknumber.Location = new System.Drawing.Point(117, 47);
            this.textBox_bucknumber.Name = "textBox_bucknumber";
            this.textBox_bucknumber.Size = new System.Drawing.Size(69, 19);
            this.textBox_bucknumber.TabIndex = 4;
            this.textBox_bucknumber.TextChanged += new System.EventHandler(this.textBox_bucknumber_TextChanged);
            // 
            // comboBox_bat
            // 
            this.comboBox_bat.FormattingEnabled = true;
            this.comboBox_bat.Location = new System.Drawing.Point(117, 121);
            this.comboBox_bat.Name = "comboBox_bat";
            this.comboBox_bat.Size = new System.Drawing.Size(62, 20);
            this.comboBox_bat.TabIndex = 5;
            this.comboBox_bat.SelectedIndexChanged += new System.EventHandler(this.comboBox_bat_SelectedIndexChanged);
            // 
            // label_pitch
            // 
            this.label_pitch.AutoSize = true;
            this.label_pitch.Location = new System.Drawing.Point(39, 86);
            this.label_pitch.Name = "label_pitch";
            this.label_pitch.Size = new System.Drawing.Size(31, 12);
            this.label_pitch.TabIndex = 6;
            this.label_pitch.Text = "Pitch";
            // 
            // label_bat
            // 
            this.label_bat.AutoSize = true;
            this.label_bat.Location = new System.Drawing.Point(39, 124);
            this.label_bat.Name = "label_bat";
            this.label_bat.Size = new System.Drawing.Size(23, 12);
            this.label_bat.TabIndex = 7;
            this.label_bat.Text = "Bat";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddPlayer_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_bat);
            this.Controls.Add(this.label_pitch);
            this.Controls.Add(this.comboBox_bat);
            this.Controls.Add(this.textBox_bucknumber);
            this.Controls.Add(this.comboBox_pitch);
            this.Controls.Add(this.label_bucknumber);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_yes);
            this.Name = "AddPlayer_dialog";
            this.Text = "Add Player?";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.Label label_bucknumber;
        private System.Windows.Forms.TextBox textBox_bucknumber;
        private System.Windows.Forms.ComboBox comboBox_pitch;
        private System.Windows.Forms.Label label_bat;
        private System.Windows.Forms.Label label_pitch;
        private System.Windows.Forms.ComboBox comboBox_bat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}