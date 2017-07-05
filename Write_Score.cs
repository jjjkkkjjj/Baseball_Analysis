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

            for (int i = 0; i < SetStartingMember.teamA_mem.Count; i++)
            {
                string[] tmp = { SetStartingMember.teamA_mem[i].position, SetStartingMember.teamA_mem[i].name, SetStartingMember.teamA_mem[i].bucknumber.ToString(),
                SetStartingMember.teamA_mem[i].view_Donated_Pitch(),SetStartingMember.teamA_mem[i].view_Donated_Bat()};
                listView_mem_teamA.Items.Add(new ListViewItem(tmp));
            }
            for (int i = 0; i < SetStartingMember.teamB_mem.Count; i++)
            {
                string[] tmp = { SetStartingMember.teamB_mem[i].position, SetStartingMember.teamB_mem[i].name, SetStartingMember.teamB_mem[i].bucknumber.ToString(),
                SetStartingMember.teamB_mem[i].view_Donated_Pitch(),SetStartingMember.teamB_mem[i].view_Donated_Bat()};
                listView_mem_teamB.Items.Add(new ListViewItem(tmp));
            }

            listView_mem_teamA.FullRowSelect = true;
            listView_mem_teamB.FullRowSelect = true;
        }

        
    }
}
