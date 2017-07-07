using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball_Analysis
{
    public partial class Add_Data : Form
    {
        private enum pitch_direction
        {
            straight,
            left,
            leftdown,
            down,
            rightdown,
            right,
        }
        private static string[] result1 = { "ボール", "ストライク", "未投球" };
        private static string[] Straight = { "ストレート" };
        private static string[] Left_ = { "シュート" };
        private static string[] LeftDown = { "シンカー" };
        private static string[] Down = { "チェンジアップ" };
        private static string[] RightDown = { "カーブ" };
        private static string[] Right_ = { "スライダー" };

        public Add_Data()
        {
            InitializeComponent();

            if(Write_Score.speed_checked)
            {
                textBox_speed.ReadOnly = true;
            }
            radioButton_straight.Checked = true;
            view_comboBox_pitch(pitch_direction.straight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_click_CH(1);
        }
        
    

        private void view_comboBox_pitch(pitch_direction PD)
        {
            comboBox_pitch.Items.Clear();
            switch (PD)
            {
                case pitch_direction.straight:
                    for(int i = 0; i < Straight.Count(); i++)
                    {
                        comboBox_pitch.Items.Add(Straight[i]);
                    }
                    break;
                case pitch_direction.left:
                    for (int i = 0; i < Left_.Count(); i++)
                    {
                        comboBox_pitch.Items.Add(Left_[i]);
                    }
                    break;
                case pitch_direction.leftdown:
                    for (int i = 0; i < LeftDown.Count(); i++)
                    {
                        comboBox_pitch.Items.Add(LeftDown[i]);
                    }
                    break;
                case pitch_direction.down:
                    for (int i = 0; i < Down.Count(); i++)
                    {
                        comboBox_pitch.Items.Add(Down[i]);
                    }
                    break;
                case pitch_direction.rightdown:
                    for (int i = 0; i < RightDown.Count(); i++)
                    {
                        comboBox_pitch.Items.Add(RightDown[i]);
                    }
                    break;
                case pitch_direction.right:
                    for (int i = 0; i < Right_.Count(); i++)
                    {
                        comboBox_pitch.Items.Add(Right_[i]);
                    }
                    break;
            }
        }
        private void button_click_CH(int num)
        {
            label_cource_height.Text = num.ToString();
            comboBox_result1.Items.Clear();
            for(int i = 0; i < result1.Count(); i++)
            {
                comboBox_result1.Items.Add(result1[i]);
            }
        }

        private void radioButton_straight_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_straight.Checked)
            {
                view_comboBox_pitch(pitch_direction.straight);
            }
        }
        private void radioButton_left_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_left.Checked)
            {
                view_comboBox_pitch(pitch_direction.left);
            }
        }
        private void radioButton_leftdown_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_leftdown.Checked)
            {
                view_comboBox_pitch(pitch_direction.leftdown);
            }
        }
        private void radioButton_down_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_down.Checked)
            {
                view_comboBox_pitch(pitch_direction.down);
            }
        }
        private void radioButton_rightdown_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_rightdown.Checked)
            {
                view_comboBox_pitch(pitch_direction.rightdown);
            }
        }
        private void radioButton_right_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_right.Checked)
            {
                view_comboBox_pitch(pitch_direction.right);
            }
        }

    }
}
