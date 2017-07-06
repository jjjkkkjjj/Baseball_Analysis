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

        }

        private void view_comboBox_pitch(pitch_direction PD)
        {
            switch (PD)
            {
                case pitch_direction.straight:
                    for(int i = 0; i < Straight.Count(); i++)
                    {
                        comboBox_pitch.Text = Straight[i];
                    }
                    break;
                case pitch_direction.left:
                    for (int i = 0; i < Left_.Count(); i++)
                    {
                        comboBox_pitch.Text = Left_[i];
                    }
                    break;
                case pitch_direction.leftdown:
                    for (int i = 0; i < LeftDown.Count(); i++)
                    {
                        comboBox_pitch.Text = LeftDown[i];
                    }
                    break;
                case pitch_direction.down:
                    for (int i = 0; i < Down.Count(); i++)
                    {
                        comboBox_pitch.Text = Down[i];
                    }
                    break;
                case pitch_direction.rightdown:
                    for (int i = 0; i < RightDown.Count(); i++)
                    {
                        comboBox_pitch.Text = RightDown[i];
                    }
                    break;
                case pitch_direction.right:
                    for (int i = 0; i < Right_.Count(); i++)
                    {
                        comboBox_pitch.Text = Right_[i];
                    }
                    break;
            }
        }
        private void button_click_CH(int num)
        {
            label_cource_height.Text = num.ToString();
            comboBox_result1.Items.Clear();
            comboBox_result1.Items.Add("B");
            comboBox_result1.Items.Add("S");
            comboBox_result1.Items.Add("F");
        }
    }
}
