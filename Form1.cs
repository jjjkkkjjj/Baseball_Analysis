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
    public partial class MainForm : Form
    {
        public static TeamSelect teamselect;
        public static Write_Score writescore;
        public MainForm()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(MainForm_Load);
            /*
            teamselect = new TeamSelect();
            writescore = new Write_Score();

            panel1.Controls.Add(teamselect);
            panel1.Controls.Add(writescore);

            teamselect.Visible = true;
            writescore.Visible = false;*/
        }

        public void Next(Type t)
        {
            if (t == null)
            {
                Close(); return;
            }
            else
            {
                this.Controls.Clear();
                var uc = Activator.CreateInstance(t) as UserControl;
                this.Controls.Add(uc);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Next(typeof(TeamSelect));
        }
    }
    //enum
    //投打
    public enum Donate
    {
        right,
        left,
        ambi,
    }
    //class
    public class Player
    {
        public string position;
        public string name;
        public int bucknumber;
        private Donate pitch, bat;
        public string view_Donated_Pitch()
        {
            if(this.pitch==Donate.right)
            {
                return "R";
            }
            else if(this.pitch == Donate.left)
            {
                return "L";
            }
            else
            {
                return "AMBI";
            }
        }
        public string view_Donated_Bat()
        {
            if (this.bat == Donate.right)
            {
                return "R";
            }
            else if (this.bat == Donate.left)
            {
                return "L";
            }
            else
            {
                return "AMBI";
            }
        }
        private string filepath;

        //コンストラクタ
        public Player(string POSITION, string NAME, int BUCKNUM, string PD, string BD, string FILEPATH)
        {
            this.position = POSITION;
            this.name = NAME;
            this.bucknumber = BUCKNUM;
            this.pitch = stringToDonate(PD);
            this.bat = stringToDonate(BD);
            this.filepath = FILEPATH;
        }

        public void file_output_detail(string opponent_team ,string opponent_name, string[] data, string result)//B=true
        {
            try
            {
                string FilePath = filepath + "\\" + name + "_detail.csv";
                using (var sr = new System.IO.StreamWriter(@FilePath, true, System.Text.Encoding.GetEncoding("shift_jis")))
                {
                    sr.Write(opponent_team + ",");
                    sr.Write(opponent_name + ",");
                    for (int i = 0; i < data.Count(); i++)
                    {
                        sr.Write(data[i] + ",");
                    }
                    if(result != "")
                    {
                        sr.Write(result + ",");
                    }

                    sr.Write("\n");
                }
                
            }
            catch (System.Exception err)
            {

            }
        }

        public void file_output_visualize(string opponent_team, string opponent_name, List<string> data, string result)//B=true
        {
            try
            {
                string FilePath = filepath + "\\" + name + "_visualize.csv";
                using (var sr = new System.IO.StreamWriter(@FilePath, true, System.Text.Encoding.GetEncoding("shift_jis")))
                {
                    sr.Write(opponent_team + "," + opponent_name + "," + result + ",");
                    int tmp = 0;
                    while (tmp < data.Count())
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            sr.Write(data[tmp] + ",");
                            tmp++;
                        }
                        sr.Write("\n");
                    }
                }

            }
            catch (System.Exception err)
            {

            }
        }

        static Donate stringToDonate(string a)
        {
            if (a == "R")
            {
                return Donate.right;
            }
            else if (a == "L")
            {
                return Donate.left;
            }
            else
            {
                return Donate.ambi;
            }
        }

    }


}
