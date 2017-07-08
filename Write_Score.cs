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

        public static string[] pitch_data = { "P(b)", "P(a)", "T", "S", "R", "C" };

        public Write_Score()
        {
            InitializeComponent();

            Team_First.Text = TeamSelect.first_teamname;
            Team_Second.Text = TeamSelect.second_teamname;
            label_teamA.Text = TeamSelect.first_teamname;
            label_teamB.Text = TeamSelect.second_teamname;

            label_name_teamA.Text = SetStartingMember.teamA_mem[0].name;
            label_name_teamB.Text = SetStartingMember.teamB_pitcher[0].name;

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

            listView_pitch_log.Columns.Add("Pitch(batter)");
            listView_pitch_log.Columns.Add("Pitch(all)");
            listView_pitch_log.Columns.Add("Type");
            listView_pitch_log.Columns.Add("Speed");
            listView_pitch_log.Columns.Add("Result");
            listView_pitch_log.Columns.Add("BSO");

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
            listView_pitch_log.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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

        private void button_add_Pinfo_Click(object sender, EventArgs e)
        {
            Add_Data add_data = new Add_Data();
            if (add_data.ShowDialog() == DialogResult.Yes)
            {
                label_ball.Text = countB.ToString();
                label_strike.Text = countS.ToString();
                label_out.Text = countO.ToString();

                listView_pitch_log.Items.Add(new ListViewItem(pitch_data));
            }
        }
    }
}
