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
    public partial class TeamSelect : UserControl
    {
        public static string FILEPATH_TEAMA = "aaa";
        public static string FILEPATH_TEAMB = "bbb";
        public static string first_teamname = "";
        public static string second_teamname = "";

        public TeamSelect()
        {
            InitializeComponent();
        }

        private void Enter_FirstTeam_Click(object sender, EventArgs e)
        {
            if (textBox_teamA.Text != "")
            {
                string filepath = textBox_teamA.Text;
                if (!filepath.Contains(".csv"))
                {
                    label_teamA.Text = "This is not csv file.";
                }
                else
                {
                    try
                    {
                        // csvファイルを開く
                        using (var sr = new System.IO.StreamReader(@filepath, System.Text.Encoding.GetEncoding("shift_jis")))
                        {

                            // ファイルから一行読み込む
                            var line = sr.ReadLine();
                            // 読み込んだ一行をカンマ毎に分けて配列に格納する
                            var values = line.Split(',');

                            label_teamA.Text = values[0] + ":" + values[1];
                            first_teamname = values[1];
                            string tmp = "";
                            // ストリームの末尾まで繰り返す
                            while (!sr.EndOfStream)
                            {
                                // ファイルから一行読み込む
                                line = sr.ReadLine();
                                // 読み込んだ一行をカンマ毎に分けて配列に格納する
                                values = line.Split(',');
                                tmp += values[0] + ":" + values[1];
                                tmp += "\n";
                            }
                            score_teamA.Text = tmp;
                            FILEPATH_TEAMA = filepath.Remove(filepath.LastIndexOf("\\")) + "\\";

                        }
                    }
                    catch (System.Exception er)
                    {
                        // ファイルを開くのに失敗したとき 
                        label_teamA.Text = "An error is occurred!";
                    }
                }
            }

        }

        private void Enter_SecondTeam_Click(object sender, EventArgs e)
        {
            if (textBox_teamB.Text != "")
            {
                string filepath = textBox_teamB.Text;
                if (!filepath.Contains(".csv"))
                {
                    label_teamB.Text = "This is not csv file.";
                }
                else
                {
                    try
                    {
                        // csvファイルを開く
                        using (var sr = new System.IO.StreamReader(@filepath, System.Text.Encoding.GetEncoding("shift_jis")))
                        {

                            // ファイルから一行読み込む
                            var line = sr.ReadLine();
                            // 読み込んだ一行をカンマ毎に分けて配列に格納する
                            var values = line.Split(',');

                            label_teamB.Text = values[0] + ":" + values[1];
                            second_teamname = values[1];
                            string tmp = "";
                            // ストリームの末尾まで繰り返す
                            while (!sr.EndOfStream)
                            {
                                // ファイルから一行読み込む
                                line = sr.ReadLine();
                                // 読み込んだ一行をカンマ毎に分けて配列に格納する
                                values = line.Split(',');
                                tmp += values[0] + ":" + values[1];
                                tmp += "\n";
                            }
                            score_teamB.Text = tmp;
                            FILEPATH_TEAMB = filepath.Remove(filepath.LastIndexOf("\\")) + "\\";

                        }
                    }
                    catch (System.Exception er)
                    {
                        // ファイルを開くのに失敗したとき 
                        label_teamB.Text = "An error is occurred!";
                    }
                }
            }
        }

        private void TeamSelect_Load(object sender, EventArgs e)
        {

        }

        private void open_teamA_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog_teamA.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox_teamA.Text = openFileDialog_teamA.FileName;
            }
            
        }

        private void open_teamB_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog_teamB.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox_teamB.Text = openFileDialog_teamB.FileName;
            }
        }

        private void next_write_score_Click(object sender, EventArgs e)
        {
            if (first_teamname != "" && second_teamname != "")
            {
                (Parent as MainForm).Next(typeof(SetStartingMember));
            }
            /*
            MainForm.writescore.Visible = true;
            MainForm.teamselect.Visible = false;
            */
        }
    }
}
