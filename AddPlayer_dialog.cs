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
    public partial class AddPlayer_dialog : Form
    {
        public static string bucknumber = "", pitch = "", bat = "";
        private static bool tmpa = false, tmpb = false, tmpc = false;
        public AddPlayer_dialog()
        {
            InitializeComponent();

            comboBox_pitch.Items.Add("R");
            comboBox_pitch.Items.Add("L");
            comboBox_pitch.Items.Add("AMBI");
            comboBox_bat.Items.Add("R");
            comboBox_bat.Items.Add("L");
            comboBox_bat.Items.Add("AMBI");

            button_yes.Enabled = false;
        }

        private void textBox_bucknumber_TextChanged(object sender, EventArgs e)
        {
            int d;
            if (textBox_bucknumber.Text == "")
            {
                //エラー表示
                errorProvider1.SetError(textBox_bucknumber, "Input number");
                button_yes.Enabled = false;
                
            }
            else if (!int.TryParse(textBox_bucknumber.Text, out d))
            {
                //エラー表示
                errorProvider1.SetError(textBox_bucknumber, "Not number");
                button_yes.Enabled = false;
                
            }
            else
            {
                //エラー取り消し
                errorProvider1.SetError(textBox_bucknumber, null);
                tmpa = true;
                if(tmpa&&tmpb&&tmpc)
                {
                    button_yes.Enabled = true;
                }
            }
                        
        }

        private void comboBox_pitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_pitch.SelectedItem == null)
            {
                //エラー表示
                errorProvider1.SetError(comboBox_pitch, "Choose Pitch");
                button_yes.Enabled = false;

            }
            else
            {
                //エラー取り消し
                errorProvider1.SetError(comboBox_pitch, null);
                tmpb = true;
                if (tmpa && tmpb && tmpc)
                {
                    button_yes.Enabled = true;
                }
            }
        }

        private void comboBox_bat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_bat.SelectedItem == null)
            {
                //エラー表示
                errorProvider1.SetError(comboBox_bat, "Choose Pitch");
                button_yes.Enabled = false;

            }
            else
            {
                //エラー取り消し
                errorProvider1.SetError(comboBox_bat, null);
                tmpc = true;
                if (tmpa && tmpb && tmpc)
                {
                    button_yes.Enabled = true;
                }
            }
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            bucknumber = textBox_bucknumber.Text;
            pitch = comboBox_pitch.SelectedItem.ToString();
            bat = comboBox_bat.SelectedItem.ToString();
        }
        
    }
}
