using System;
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
    public partial class Write_Score : UserControl
    {
        public static bool speed_checked = false;
        public static int countS = 0, countB = 0, countO = 0;
        public static int pitch_batter = 0, pitch_all = 0;
        public static int teamA_bat_num = 0, teamB_bat_num = 0;
        public static int cource_height = 1;
        public static string[] pitch_data = { "P(b)", "P(a)", "T", "S", "R", "C", "Ru", "N" };
        public static bool countup = false;
        public static string RESULT = "";
        public static bool R1 = false, R2 = false, R3 = false;
        public static bool attackA = true;

        public Write_Score()
        {
            InitializeComponent();

            Team_First.Text = TeamSelect.first_teamname;
            Team_Second.Text = TeamSelect.second_teamname;
            label_teamA.Text = TeamSelect.first_teamname;
            label_teamB.Text = TeamSelect.second_teamname;

            label_name_teamA.Text = SetStartingMember.teamA_mem[0].name;
            label_name_teamB.Text = SetStartingMember.teamB_pitcher[0].name;
            label_name_teamA_add.Text = SetStartingMember.teamA_mem[0].name;
            label_name_teamB_add.Text = SetStartingMember.teamB_pitcher[0].name;

            listView_mem_teamA.View = View.Details;
            listView_mem_teamB.View = View.Details;

            listView_pitch_log.View = View.Details;

            //カラムの設定
            listView_mem_teamA.Columns.Add("Position");
            listView_mem_teamA.Columns.Add("name");
            listView_mem_teamA.Columns.Add("#");
            listView_mem_teamA.Columns.Add("Pitch");
            listView_mem_teamA.Columns.Add("Bat");
            listView_mem_teamB.Columns.Add("Position");
            listView_mem_teamB.Columns.Add("name");
            listView_mem_teamB.Columns.Add("#");
            listView_mem_teamB.Columns.Add("Pitch");
            listView_mem_teamB.Columns.Add("Bat");

            listView_pitch_log.Columns.Add("Pitch(bater)");
            listView_pitch_log.Columns.Add("Pitch(all)");
            listView_pitch_log.Columns.Add("Type");
            listView_pitch_log.Columns.Add("Speed");
            listView_pitch_log.Columns.Add("Result");
            listView_pitch_log.Columns.Add("BSO");
            listView_pitch_log.Columns.Add("Runner");
            listView_pitch_log.Columns.Add("CHnum");

            for (int i = 0; i < SetStartingMember.teamA_mem.Count; i++)
            {
                string[] tmp = { SetStartingMember.teamA_mem[i].position, SetStartingMember.teamA_mem[i].name, SetStartingMember.teamA_mem[i].bucknumber.ToString(),
                SetStartingMember.teamA_mem[i].view_Donated_Pitch(),SetStartingMember.teamA_mem[i].view_Donated_Bat()};
                listView_mem_teamA.Items.Add(new ListViewItem(tmp));
            }
            string[] tmp_pA = { SetStartingMember.teamA_pitcher[0].position, SetStartingMember.teamA_pitcher[0].name, SetStartingMember.teamA_pitcher[0].bucknumber.ToString(),
                SetStartingMember.teamA_pitcher[0].view_Donated_Pitch(),SetStartingMember.teamA_pitcher[0].view_Donated_Bat()};
            listView_mem_teamA.Items.Add(new ListViewItem(tmp_pA));

            for (int i = 0; i < SetStartingMember.teamB_mem.Count; i++)
            {
                string[] tmp = { SetStartingMember.teamB_mem[i].position, SetStartingMember.teamB_mem[i].name, SetStartingMember.teamB_mem[i].bucknumber.ToString(),
                SetStartingMember.teamB_mem[i].view_Donated_Pitch(),SetStartingMember.teamB_mem[i].view_Donated_Bat()};
                listView_mem_teamB.Items.Add(new ListViewItem(tmp));
            }
            string[] tmp_pB = { SetStartingMember.teamB_pitcher[0].position, SetStartingMember.teamB_pitcher[0].name, SetStartingMember.teamB_pitcher[0].bucknumber.ToString(),
                SetStartingMember.teamB_pitcher[0].view_Donated_Pitch(),SetStartingMember.teamB_pitcher[0].view_Donated_Bat()};
            listView_mem_teamB.Items.Add(new ListViewItem(tmp_pB));

            listView_mem_teamA.FullRowSelect = true;
            listView_mem_teamB.FullRowSelect = true;
            listView_pitch_log.FullRowSelect = true;

            listView_mem_teamA.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_mem_teamB.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            dataGridView_cource_height.ColumnCount = 5;
            dataGridView_cource_height.RowCount = 5;
            dataGridView_cource_height.ReadOnly = true;
            
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    dataGridView_cource_height[i, j].Style.BackColor = Color.LightGreen;
                }
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    dataGridView_cource_height[i, j].Style.BackColor = Color.Yellow;
                }
            }
            dataGridView_cource_height.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void checkBox_speed_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_speed.Checked)
            {
                speed_checked = true;
            }
            else
            {
                speed_checked = false;
            }
        }

        private void button_delete_Pinfo_Click(object sender, EventArgs e)
        {
            int itemnum = listView_pitch_log.Items.Count;
            if (itemnum != 0)
            {
                ListViewItem Tmp = listView_pitch_log.Items[itemnum - 1];
                if (itemnum != 1)
                {
                    ListViewItem tmp = listView_pitch_log.Items[itemnum - 2];
                    string bso = tmp.SubItems[5].Text;
                    countB = int.Parse(bso[0].ToString());
                    countS = int.Parse(bso[1].ToString());
                    countO = int.Parse(bso[2].ToString());
                }
                else
                {
                    countB = 0;
                    countS = 0;
                    countO = 0;
                }
                listView_pitch_log.Items.RemoveAt(itemnum - 1);
                
                view_count();

                int CHnum = int.Parse(Tmp.SubItems[6].Text.ToString());
                string A = dataGridView_cource_height[return_heightnum(CHnum), return_courcenum(CHnum)].Value.ToString();
                if(pitch_batter < 10)
                {
                    A = A.Remove(A.Length - 2);
                }
                else
                {
                    A = A.Remove(A.Length - 3);
                }
                
                dataGridView_cource_height[return_heightnum(CHnum), return_courcenum(CHnum)].Value = A;
                dataGridView_cource_height.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                pitch_all--;
                pitch_batter--;
            }           
            
        }

        private void button_add_Pinfo_Click(object sender, EventArgs e)
        {
            Add_Data add_data = new Add_Data();
            if (add_data.ShowDialog() == DialogResult.Yes)
            {
                view_count();

                listView_pitch_log.Items.Add(new ListViewItem(pitch_data));
                dataGridView_cource_height[return_heightnum(cource_height), return_courcenum(cource_height)].Value += pitch_data[0];
                dataGridView_cource_height.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                if(!countup)
                {
                    label_result.Text = pitch_data[4];
                }
                else
                {
                    label_result.Text = RESULT;
                }
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (listView_pitch_log.Items.Count != 0)
            {
                string[] tmp = { "P(b)", "P(a)", "T", "S", "R", "C", "Ru", "N" };
                for (int i = 0; i < listView_pitch_log.Items.Count; i++)
                {
                    ListViewItem TMP = listView_pitch_log.Items[i];
                    for (int j = 0; j < tmp.Count(); j++)
                    {
                        tmp[j] = TMP.SubItems[j].Text;
                    }

                    string result = "";
                    if (i == listView_pitch_log.Items.Count - 1)
                    {
                        result = RESULT;
                    }
                    if (attackA)
                    { 
                        SetStartingMember.teamA_mem[teamA_bat_num].file_output_detail(
                        TeamSelect.first_teamname, SetStartingMember.teamB_pitcher[0].name, tmp, result);
                    }
                    else
                    {
                        SetStartingMember.teamB_mem[teamB_bat_num].file_output_detail(
                        TeamSelect.second_teamname, SetStartingMember.teamA_pitcher[0].name, tmp, result);
                    }

                }
                if(attackA)
                {
                    List<string> A = new List<string>();
                    for(int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (dataGridView_cource_height[j, i].Value == null)
                            {
                                A.Add("");
                            }
                            else
                            {
                                A.Add(dataGridView_cource_height[j, i].Value.ToString());
                            }                          
                           
                        }
                    }
                    SetStartingMember.teamA_mem[teamA_bat_num].file_output_visualize(
                        TeamSelect.first_teamname, SetStartingMember.teamB_pitcher[0].name, A, RESULT);

                    teamA_bat_num++;
                    if (teamA_bat_num == 9)
                    {
                        teamA_bat_num = 0;
                    }
                }
                else
                {
                    List<string> B = new List<string>();
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (dataGridView_cource_height[j, i].Value == null)
                            {
                                B.Add("");
                            }
                            else
                            {
                                B.Add(dataGridView_cource_height[j, i].Value.ToString());
                            }
                        }
                    }
                    SetStartingMember.teamB_mem[teamB_bat_num].file_output_visualize(
                        TeamSelect.first_teamname, SetStartingMember.teamA_pitcher[0].name, B, RESULT);

                    teamB_bat_num++;
                    if (teamB_bat_num == 9)
                    {
                        teamB_bat_num = 0;
                    }
                }

                countup = false;
                RESULT = "";                
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView_cource_height[i, j].Value = null;
                }
            }
            listView_pitch_log.Items.Clear();

            if(countO == 3)
            {
                countO = 0;
                if(attackA)
                {
                    attackA = false;
                }
                else
                {
                    attackA = true;
                }
            }
            countS = 0;
            countB = 0;
            pitch_batter = 0;

            view_label();
            view_count();
        }

        private void checkBox_runner1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_runner1.Checked)
            {
                R1 = true;
            }
            else
            {
                R1 = false;
            }
        }

        private void checkBox_runner2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_runner2.Checked)
            {
                R2 = true;
            }
            else
            {
                R2 = false;
            }
        }

        private void checkBox_runner3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_runner3.Checked)
            {
                R3 = true;
            }
            else
            {
                R3 = false;
            }
        }

        private int return_courcenum(int i)
        {
            int[,] cor = new int[,] { { 10, 11, 12, 13, 14 }, { 15, 1, 2, 3, 16 }, { 17, 4, 5, 6, 18 }, { 19, 7, 8, 9, 20 }, { 21, 22, 23, 24, 25 } };
            int tmp = 0;
            int row = 0;
            while(tmp<25)
            {
                if(cor[tmp/5,tmp%5] == i)
                {
                    row = tmp / 5;
                    break;
                }
                tmp++;
            }
            return row;
        }
        private int return_heightnum(int i)
        {
            int[,] cor = new int[,] { { 10, 11, 12, 13, 14 }, { 15, 1, 2, 3, 16 }, { 17, 4, 5, 6, 18 }, { 19, 7, 8, 9, 20 }, { 21, 22, 23, 24, 25 } };
            int tmp = 0;
            int column = 0;
            while (tmp < 25)
            {
                if (cor[tmp / 5, tmp % 5] == i)
                {
                    column = tmp % 5;
                    break;
                }
                tmp++;
            }
            return column;
        }

        private void view_count()
        {
            label_ball.Text = countB.ToString();
            label_strike.Text = countS.ToString();
            label_out.Text = countO.ToString();
        }

        private void view_label()
        {
            if(attackA)
            {
                label_BorP_teamA.Text = "Batter";
                label_BorP_teamB.Text = "Pitcher";
                label_BorP_teamA_add.Text = "Batter";
                label_BorP_teamB_add.Text = "Pitcher";
                label_name_teamA.Text = SetStartingMember.teamA_mem[teamA_bat_num].name;
                label_name_teamB.Text = SetStartingMember.teamB_pitcher[0].name;
                label_name_teamA_add.Text = SetStartingMember.teamA_mem[teamA_bat_num].name;
                label_name_teamB_add.Text = SetStartingMember.teamB_pitcher[0].name;
            }
            else
            {
                label_BorP_teamB.Text = "Batter";
                label_BorP_teamA.Text = "Pitcher";
                label_BorP_teamB_add.Text = "Batter";
                label_BorP_teamA_add.Text = "Pitcher";
                label_name_teamB.Text = SetStartingMember.teamB_mem[teamB_bat_num].name;
                label_name_teamA.Text = SetStartingMember.teamA_pitcher[0].name;
                label_name_teamB_add.Text = SetStartingMember.teamB_mem[teamB_bat_num].name;
                label_name_teamA_add.Text = SetStartingMember.teamA_pitcher[0].name;
            }
            label_result.Text = "Result";
        }
    }
}
