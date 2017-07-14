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
    public partial class Add_Data 
        : Form
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
        private static int button_click_num = 0;
        private static int nB = 0, nS = 0, nO = 0;
        private static int tmp_O = 0, tmp_O2 = 0;

        private static string[] result1 = { "ボール", "見逃し", "空振り", "ファール", "凡打", 
            "犠牲", "安打・出塁", "未投球" };
        private static string[] direction = { "投", "捕", "一", "二", "三", "遊", "左", "中", "右" };
        private static string[] result2_bonda = { "ゴロ", "フライ", "ライナー", "ファールフライ", "ゴロW", "ゴロT"};
        private static string[] result2_syuturui = { "ヒット", "2ベース", "3ベース", "HR", "エラー",
            "死球", "Fc", "ELSE"};
        private static string[] result2_mitokyu = { "牽制死" };

        private static string[] Straight = { "ストレート", "2シーム" };
        private static string[] Left_ = { "シュート" };
        private static string[] LeftDown = { "シンカー" };
        private static string[] Down = { "チェンジアップ", "フォーク", "縦スライダー", "パーム", "ナックル" };
        private static string[] RightDown = { "カーブ" };
        private static string[] Right_ = { "スライダー", "カットボール" };
        private static string[] Direction_fig = { "↑", "←", "△", "↓", "▲", "→" };
        private static int Direction_fig_id = 0;
        private static bool Lefty = false;

        public Add_Data()
        {
            InitializeComponent();

            if(Write_Score.speed_checked)
            {
                textBox_speed.Enabled = false;
            }
            radioButton_straight.Checked = true;
            view_comboBox_pitch(pitch_direction.straight);
            nB = Write_Score.countB;
            nS = Write_Score.countS;
            nO = Write_Score.countO;

            label_ball.Text = nB.ToString();
            label_strike.Text = nS.ToString();
            label_out.Text = nO.ToString();

            if (Write_Score.attackA)
            {
               if( SetStartingMember.teamB_pitcher[0].view_Donated_Pitch() == "L")
                {
                    Lefty = true;
                    radioButton_leftdown.Text = Direction_fig[4];
                    radioButton_rightdown.Text = Direction_fig[2];
                }
            }
            else
            {
                if (SetStartingMember.teamA_pitcher[0].view_Donated_Pitch() == "L")
                {
                    Lefty = true;
                    radioButton_leftdown.Text = Direction_fig[4];
                    radioButton_rightdown.Text = Direction_fig[2];
                }
            }
            numericUpDown_outnum.Maximum = 3;
            numericUpDown_outnum.Minimum = 0;
            Write_Score.countup = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_click_CH(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button_click_CH(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button_click_CH(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button_click_CH(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button_click_CH(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button_click_CH(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button_click_CH(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button_click_CH(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button_click_CH(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_click_CH(10);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button_click_CH(11);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            button_click_CH(12);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            button_click_CH(13);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            button_click_CH(14);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            button_click_CH(15);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            button_click_CH(16);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            button_click_CH(17);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            button_click_CH(18);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            button_click_CH(19);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            button_click_CH(20);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            button_click_CH(21);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            button_click_CH(22);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            button_click_CH(23);
        }
        private void button24_Click(object sender, EventArgs e)
        {
            button_click_CH(24);
        }
        private void button25_Click(object sender, EventArgs e)
        {
            button_click_CH(25);
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
            if(button_click_num == 0)
            {
                label_cource_height_C.Text = num.ToString();
                button_click_num += 1;
            }
            else
            {
                label_cource_height_P.Text = num.ToString();
                comboBox_result1.Items.Clear();
                for (int i = 0; i < result1.Count(); i++)
                {
                    comboBox_result1.Items.Add(result1[i]);
                }

                button_click_num = 0;
            }
            
        }

        private void radioButton_straight_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_straight.Checked)
            {
                view_comboBox_pitch(pitch_direction.straight);
                Direction_fig_id = 0;
            }
        }
        private void radioButton_left_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_left.Checked)
            {
                view_comboBox_pitch(pitch_direction.left);
                Direction_fig_id = 1;
                if (Lefty)
                {
                    view_comboBox_pitch(pitch_direction.right);
                    Direction_fig_id = 5;
                }
            }
        }
        private void radioButton_leftdown_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_leftdown.Checked)
            {
                view_comboBox_pitch(pitch_direction.leftdown);
                Direction_fig_id = 2;
                if(Lefty)
                {
                    view_comboBox_pitch(pitch_direction.rightdown);
                    Direction_fig_id = 4;
                }
            }
        }
        private void radioButton_down_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_down.Checked)
            {
                view_comboBox_pitch(pitch_direction.down);
                Direction_fig_id = 3;
            }
        }
        private void radioButton_rightdown_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_rightdown.Checked)
            {
                view_comboBox_pitch(pitch_direction.rightdown);
                Direction_fig_id = 4;
                if (Lefty)
                {
                    view_comboBox_pitch(pitch_direction.leftdown);
                    Direction_fig_id = 2;
                }
            }
        }
        private void radioButton_right_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_right.Checked)
            {
                view_comboBox_pitch(pitch_direction.right);
                Direction_fig_id = 5;
                if (Lefty)
                {
                    view_comboBox_pitch(pitch_direction.left);
                    Direction_fig_id = 1;
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Write_Score.countB = nB;
            Write_Score.countS = nS;
            Write_Score.countO = nO;
            Write_Score.pitch_all++;
            Write_Score.pitch_batter++;
            if(comboBox_result1.Text == "未投球")
            {
                Write_Score.pitch_all--;
                Write_Score.pitch_batter--;
            }

            Write_Score.pitch_data[0] = Direction_fig[Direction_fig_id] + Write_Score.pitch_batter.ToString();
            Write_Score.pitch_data[1] = Write_Score.pitch_all.ToString();
            Write_Score.pitch_data[2] = comboBox_pitch.Text;
            if(textBox_speed.Enabled)
            {
                Write_Score.pitch_data[3] = textBox_speed.Text;
            }
            else
            {
                Write_Score.pitch_data[3] = "-";
            }
            Write_Score.pitch_data[4] = comboBox_result1.Text;
            Write_Score.pitch_data[5] = nB.ToString() + "|" + nS.ToString() + "|" + nO.ToString();
            Write_Score.pitch_data[6] = label_cource_height_P.Text;

            Write_Score.cource_height = int.Parse(label_cource_height_P.Text);

            if(Write_Score.countup)
            {
                Write_Score.RESULT = comboBox_direction.Text + comboBox_result2.Text;
            }
        }

        private void numericUpDown_outnum_ValueChanged(object sender, EventArgs e)
        {
            nO = tmp_O2;
            int a = int.Parse(numericUpDown_outnum.Value.ToString());
            nO += a;
            view_BSO();
        }

        private void comboBox_result2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nO = tmp_O;
            if(comboBox_result2.Text == "ゴロW")
            {
                nO++;
            }
            else if(comboBox_result2.Text == "ゴロT")
            {
                nO += 2;
            }
            tmp_O2 = nO;
            view_BSO();
            limited_other_out(nO);
        }

        private void comboBox_result1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nB = Write_Score.countB;
            nS = Write_Score.countS;
            nO = Write_Score.countO;
            comboBox_direction.Enabled = true;
            comboBox_result2.Enabled = true;
            numericUpDown_outnum.Enabled = false;
            Write_Score.countup = false;

            if (comboBox_result1.Text == "ボール")
            {
                comboBox_direction.Enabled = false;
                if (nB != 3)
                {
                    nB++;
                    comboBox_result2.Enabled = false;
                }
                else
                {
                    comboBox_result2.Text = "四球";
                    comboBox_result2.Items.Add("四球");
                    nB++;
                }
            }
            else if (comboBox_result1.Text == "見逃し" || comboBox_result1.Text == "空振り")
            {
                comboBox_direction.Enabled = false;
                if (nS != 2)
                {
                    nS++;
                    comboBox_result2.Enabled = false;
                }
                else
                {
                    comboBox_result2.Text = "三振";
                    comboBox_result2.Items.Add("三振");
                    nS++;
                    nO++;
                    numericUpDown_outnum.Enabled = true;
                }
            }
            else if (comboBox_result1.Text == "ファール")
            {
                if(nS !=2)
                {
                    nS++;
                }
                comboBox_direction.Enabled = false;
                comboBox_result2.Enabled = false;
            }
            else if (comboBox_result1.Text == "凡打")
            {
                nO++;
                comboBox_direction.Items.Clear();
                comboBox_result2.Items.Clear();
                for (int i = 0; i < direction.Count(); i++)
                {
                    comboBox_direction.Items.Add(direction[i]);
                }
                for(int i = 0; i < result2_bonda.Count() - Write_Score.countO; i++)
                {
                    comboBox_result2.Items.Add(result2_bonda[i]);
                }
                numericUpDown_outnum.Enabled = true;
                Write_Score.countup = true;
            }
            else if (comboBox_result1.Text == "犠牲")
            {
                nO++;
                comboBox_direction.Items.Clear();
                comboBox_result2.Items.Clear();
                for (int i = 0; i < direction.Count(); i++)
                {
                    comboBox_direction.Items.Add(direction[i]);
                }
                comboBox_result2.Items.Add("バント");
                comboBox_result2.Items.Add("フライ");

                numericUpDown_outnum.Enabled = true;
                Write_Score.countup = true;
            }
            else if (comboBox_result1.Text == "安打・出塁")
            {
                comboBox_direction.Items.Clear();
                comboBox_result2.Items.Clear();
                for (int i = 0; i < direction.Count(); i++)
                {
                    comboBox_direction.Items.Add(direction[i]);
                }
                for (int i = 0; i < result2_syuturui.Count(); i++)
                {
                    comboBox_result2.Items.Add(result2_syuturui[i]);
                }

                numericUpDown_outnum.Enabled = true;
                Write_Score.countup = true;
            }
            else
            {
                comboBox_direction.Items.Clear();
                comboBox_result2.Items.Clear();
                for (int i = 0; i < result2_mitokyu.Count(); i++)
                {
                    comboBox_result2.Items.Add(result2_mitokyu[i]);
                }
            }
            tmp_O = nO;
            tmp_O2 = nO;
            view_BSO();
            limited_other_out(nO);
        }

        private void view_BSO()
        {
            label_ball.Text = nB.ToString();
            label_strike.Text = nS.ToString();
            label_out.Text = nO.ToString();
        }

        private void limited_other_out(int O)
        {
            numericUpDown_outnum.Maximum = 3 - O;
            numericUpDown_outnum.Minimum = 0;
        }
    }
}
