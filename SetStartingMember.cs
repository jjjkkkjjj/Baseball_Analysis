﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball_Analysis
{
    public partial class SetStartingMember : UserControl
    {
        private static List<int> selectedpositionA = new List<int>(), selectedpositionB = new List<int>();
        public static List<Player> teamA_mem = new List<Player>(), teamB_mem = new List<Player>();
        public static List<Player> teamA_pitcher = new List<Player>(), teamB_pitcher = new List<Player>();
        public static bool DH_teamA = true, DH_teamB = true;

        public SetStartingMember()
        {
            InitializeComponent();

            label_teamA.Text = TeamSelect.first_teamname;
            label_teamB.Text = TeamSelect.second_teamname;

            comboBox_position_teamA.Items.Add("P");
            comboBox_position_teamB.Items.Add("P");
            comboBox_position_teamA.Items.Add("D");
            comboBox_position_teamB.Items.Add("D");
    
            for (int i = 1; i < 9; i++)
            {
                comboBox_position_teamA.Items.Add((i + 1).ToString());
                comboBox_position_teamB.Items.Add((i + 1).ToString());
            }
        }

        private void buck_teamselect_Click(object sender, EventArgs e)
        {
            (Parent as MainForm).Next(typeof(TeamSelect));
        }

        private void button_add_teamA_Click(object sender, EventArgs e)
        {
            if(textBox_teamA.Text != "" && comboBox_position_teamA.Text != "")
            {
                if(readplayer(textBox_teamA.Text, true, comboBox_position_teamA.Text))
                {
                    if (comboBox_position_teamA.Text != "P")
                    {
                        listBox_batter_teamA.Items.Add(comboBox_position_teamA.Text + ":" + textBox_teamA.Text);
                        if(comboBox_position_teamA.Text != "D")
                        {
                            selectedpositionA.Add(int.Parse(comboBox_position_teamA.Text));
                            if (!DH_teamA && comboBox_position_teamA.Text == "1")
                            {
                                listBox_pitcher_teamA.Items.Add("P:" + textBox_teamA.Text);
                                selectedpositionA.Add(1);
                            }
                        }
                        else
                        {
                            selectedpositionA.Add(0);
                        }
                    }
                    else
                    {
                        listBox_pitcher_teamA.Items.Add(comboBox_position_teamA.Text + ":" + textBox_teamA.Text);
                        selectedpositionA.Add(1);
                    }
                }
            }
            positionview(true);
        }

        private void button_add_teamB_Click(object sender, EventArgs e)
        {
            if (textBox_teamB.Text != "" && comboBox_position_teamB.Text != "")
            {
                if (readplayer(textBox_teamB.Text, false, comboBox_position_teamB.Text))
                {
                    if (comboBox_position_teamB.Text != "P")
                    {
                        listBox_batter_teamB.Items.Add(comboBox_position_teamB.Text + ":" + textBox_teamB.Text);
                        if (comboBox_position_teamB.Text != "D")
                        {
                            selectedpositionB.Add(int.Parse(comboBox_position_teamB.Text));
                            if (!DH_teamB && comboBox_position_teamB.Text == "1")
                            {
                                listBox_pitcher_teamB.Items.Add("P:" + textBox_teamB.Text);
                                selectedpositionB.Add(1);
                            }
                        }
                        else
                        {
                            selectedpositionB.Add(0);
                        }
                    }
                    else
                    {
                        listBox_pitcher_teamB.Items.Add(comboBox_position_teamB.Text + ":" + textBox_teamB.Text);
                        selectedpositionB.Add(1);
                    }
                }
            }
            positionview(false);
        }

        static bool readplayer(string name, bool AorB, string position)//true:A,false:B
        {
            string filepathA = TeamSelect.FILEPATH_TEAMA + "PLAYER";
            string filepathB = TeamSelect.FILEPATH_TEAMB + "PLAYER";
            if (AorB)
            {
                if (!System.IO.Directory.Exists(filepathA))
                {
                    System.IO.Directory.CreateDirectory(filepathA);
                }
                try
                {
                    filepathA += "\\" + name + ".csv";
                    // csvファイルを開く
                    using (var sr = new System.IO.StreamReader(@filepathA, System.Text.Encoding.GetEncoding("shift_jis")))
                    {
                        string tmp_name, tmp_bucknumber, tmp_PD, tmp_BD;
                        var line = sr.ReadLine();
                        var values = line.Split(',');
                        tmp_name = values[1];

                        line = sr.ReadLine();
                        values = line.Split(',');
                        tmp_bucknumber = values[1];

                        line = sr.ReadLine();
                        values = line.Split(',');
                        tmp_PD = values[1];

                        line = sr.ReadLine();
                        values = line.Split(',');
                        tmp_BD = values[1];

                        int tmp_bn = int.Parse(tmp_bucknumber);
                        Player TMP = new Player(position, tmp_name, tmp_bn, tmp_PD, tmp_BD, filepathA);
                        if(position != "P")
                        {
                            teamA_mem.Add(TMP);
                        }
                        else
                        {
                            teamA_pitcher.Add(TMP);
                        }

                        return true;
                    }
                }
                catch (System.Exception er)
                {
                    //ここで作成するかどうか
                    DialogResult result = MessageBox.Show("Do you add player?",
                     "Question",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        //「はい」が選択された時
                        AddPlayer_dialog addplayer = new AddPlayer_dialog();
                        if (addplayer.ShowDialog() == DialogResult.Yes)
                        {
                            try
                            {
                                using (var sr = new System.IO.StreamWriter(@filepathA, false, System.Text.Encoding.GetEncoding("shift_jis")))
                                {
                                    string tmp_name, tmp_bucknumber, tmp_PD, tmp_BD;
                                    tmp_name = name;
                                    tmp_bucknumber = AddPlayer_dialog.bucknumber;
                                    tmp_PD = AddPlayer_dialog.pitch;
                                    tmp_BD = AddPlayer_dialog.bat;
                                    int tmp_bn = int.Parse(tmp_bucknumber);

                                    sr.Write("Name," + name + ",\n");
                                    sr.Write("#," + tmp_bucknumber + ",\n");
                                    sr.Write("P," + tmp_PD + ",\n");
                                    sr.Write("B," + tmp_BD + ",\n");

                                    Player TMP = new Player(position, tmp_name, tmp_bn, tmp_PD, tmp_BD, filepathA);
                                    if (position != "P")
                                    {
                                        teamA_mem.Add(TMP);
                                    }
                                    else
                                    {
                                        teamA_pitcher.Add(TMP);
                                    }
                                }
                                return true;
                            }
                            catch (System.Exception err)
                            {

                            }
                        }
                    }
                    return false;
                }
            }
            else
            {
                if (!System.IO.Directory.Exists(filepathA))
                {
                    System.IO.Directory.CreateDirectory(filepathA);
                }
                try
                {
                    filepathB += "\\" + name + ".csv";
                    // csvファイルを開く
                    using (var sr = new System.IO.StreamReader(@filepathB, System.Text.Encoding.GetEncoding("shift_jis")))
                    {
                        string tmp_name, tmp_bucknumber, tmp_PD, tmp_BD;
                        var line = sr.ReadLine();
                        var values = line.Split(',');
                        tmp_name = values[1];

                        line = sr.ReadLine();
                        values = line.Split(',');
                        tmp_bucknumber = values[1];

                        line = sr.ReadLine();
                        values = line.Split(',');
                        tmp_PD = values[1];

                        line = sr.ReadLine();
                        values = line.Split(',');
                        tmp_BD = values[1];

                        int tmp_bn = int.Parse(tmp_bucknumber);
                        Player TMP = new Player(position, tmp_name, tmp_bn, tmp_PD, tmp_BD, filepathB);
                        if (position != "P")
                        {
                            teamB_mem.Add(TMP);
                        }
                        else
                        {
                            teamB_pitcher.Add(TMP);
                        }
                        return true;
                    }
                }
                catch (System.Exception er)
                {
                    //ここで作成するかどうか
                    DialogResult result = MessageBox.Show("Do you add player?",
                     "Question",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        //「はい」が選択された時
                        AddPlayer_dialog addplayer = new AddPlayer_dialog();
                        if (addplayer.ShowDialog() == DialogResult.Yes)
                        {
                            try
                            {
                                using (var sr = new System.IO.StreamWriter(@filepathB, false, System.Text.Encoding.GetEncoding("shift_jis")))
                                {
                                    string tmp_name, tmp_bucknumber, tmp_PD, tmp_BD;
                                    tmp_name = name;
                                    tmp_bucknumber = AddPlayer_dialog.bucknumber;
                                    tmp_PD = AddPlayer_dialog.pitch;
                                    tmp_BD = AddPlayer_dialog.bat;
                                    int tmp_bn = int.Parse(tmp_bucknumber);

                                    sr.Write("Name," + name + ",\n");
                                    sr.Write("#," + tmp_bucknumber + ",\n");
                                    sr.Write("P," + tmp_PD + ",\n");
                                    sr.Write("B," + tmp_BD + ",\n");

                                    Player TMP = new Player(position, tmp_name, tmp_bn, tmp_PD, tmp_BD, filepathB);
                                    if (position != "P")
                                    {
                                        teamB_mem.Add(TMP);
                                    }
                                    else
                                    {
                                        teamB_pitcher.Add(TMP);
                                    }
                                }
                                return true;
                            }
                            catch(System.Exception err)
                            {

                            }
                        }
                    }
                    return false;
                }
            }
            
        }

        private void button_delete_teamA_Click(object sender, EventArgs e)
        {
            if(listBox_batter_teamA.SelectedItem != null)
            {
                string tmp = listBox_batter_teamA.SelectedItem.ToString();
                tmp = tmp.Remove(1);
                if (tmp != "D")
                {
                    selectedpositionA.Remove(int.Parse(tmp));
                }
                else
                {
                    selectedpositionA.Remove(0);
                }

                int sel = listBox_batter_teamA.SelectedIndex;
                listBox_batter_teamA.Items.RemoveAt(sel);
                teamA_mem.RemoveAt(sel);
            }
            else if(listBox_pitcher_teamA.SelectedItem != null)
            {
                int sel = listBox_pitcher_teamA.SelectedIndex;
                listBox_pitcher_teamA.Items.RemoveAt(sel);

                selectedpositionA.Remove(1);
                teamA_pitcher.RemoveAt(0);
            }
            positionview(true);
        }

        private void checkBox_unlockDH_teamA_CheckedChanged(object sender, EventArgs e)
        {
            listBox_batter_teamA.Items.Clear();
            listBox_pitcher_teamA.Items.Clear();
            selectedpositionA.Clear();
            teamA_mem.Clear();
            teamA_pitcher.Clear();
            if(checkBox_unlockDH_teamA.Checked)
            {
                DH_teamA = false;
            }
            else
            {
                DH_teamA = true;
            }
            positionview(true);
        }

        private void checkBox_unlockDH_teamB_CheckedChanged(object sender, EventArgs e)
        {
            listBox_batter_teamB.Items.Clear();
            listBox_pitcher_teamB.Items.Clear();
            selectedpositionB.Clear();
            teamB_mem.Clear();
            teamB_pitcher.Clear();
            if (checkBox_unlockDH_teamB.Checked)
            {
                DH_teamB = false;
            }
            else
            {
                DH_teamB = true;
            }
            positionview(false);
        }

        private void button_delete_teamB_Click(object sender, EventArgs e)
        {
            if (listBox_batter_teamB.SelectedItem != null)
            {
                string tmp = listBox_batter_teamB.SelectedItem.ToString();
                tmp = tmp.Remove(1);
                if (tmp != "D")
                {
                    selectedpositionB.Remove(int.Parse(tmp));
                }
                else
                {
                    selectedpositionB.Remove(0);
                }

                int sel = listBox_batter_teamB.SelectedIndex;
                listBox_batter_teamB.Items.RemoveAt(sel);

                teamB_mem.RemoveAt(sel);
            }
            else if (listBox_pitcher_teamB.SelectedItem != null)
            {
                int sel = listBox_pitcher_teamB.SelectedIndex;
                listBox_pitcher_teamB.Items.RemoveAt(sel);

                selectedpositionB.Remove(1);

                teamB_pitcher.RemoveAt(0);
            }
            positionview(false);
        }

        private void next_write_score_Click(object sender, EventArgs e)
        {
            if(listBox_batter_teamA.Items.Count == 9 && listBox_batter_teamB.Items.Count == 9)
            {
                (Parent as MainForm).Next(typeof(Write_Score));
            }
        }

        private void positionview(bool AorB)
        {
            if (AorB)
            {
                comboBox_position_teamA.Items.Clear();
                comboBox_position_teamA.Text = "";
                if(DH_teamA)
                {
                    if (!selectedpositionA.Contains(0))
                    {
                        comboBox_position_teamA.Items.Add("D");
                    }
                    if (!selectedpositionA.Contains(1))
                    {
                        comboBox_position_teamA.Items.Add("P");
                    }
                }
                else
                {
                    if (!selectedpositionA.Contains(1))
                    {
                        comboBox_position_teamA.Items.Add("1");
                    }
                }
                for (int i = 2; i <= 9; i++)
                {
                    if (!selectedpositionA.Contains(i))
                    {
                        comboBox_position_teamA.Items.Add(i.ToString());
                    }
                }

            }
            else
            {
                comboBox_position_teamB.Items.Clear();
                comboBox_position_teamB.Text = "";
                if (DH_teamB)
                {
                    if (!selectedpositionB.Contains(0))
                    {
                        comboBox_position_teamB.Items.Add("D");
                    }
                    if (!selectedpositionB.Contains(1))
                    {
                        comboBox_position_teamB.Items.Add("P");
                    }
                }
                else
                {
                    if (!selectedpositionB.Contains(1))
                    {
                        comboBox_position_teamB.Items.Add("1");
                    }
                }
                for (int i = 2; i <= 9; i++)
                {
                    if (!selectedpositionB.Contains(i))
                    {
                        comboBox_position_teamB.Items.Add(i.ToString());
                    }
                }

            }
        }
    }
}
