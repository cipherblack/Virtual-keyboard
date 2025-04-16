using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            var code = e.KeyValue.ToString();
            if (code == "8")
            {
                label12.BackColor = Color.WhiteSmoke;
            }
            else if (code == "32")
            {
                label40.BackColor = Color.WhiteSmoke;
            }


            else if (code == "65")
            {
                label38.BackColor = Color.WhiteSmoke;
            }
            else if (code == "66")
            {
                label45.BackColor = Color.WhiteSmoke;
            }
            else if (code == "67")
            {
                label47.BackColor = Color.WhiteSmoke;
            }
            else if (code == "68")
            {
                label36.BackColor = Color.WhiteSmoke;
            }
            else if (code == "69")
            {
                label22.BackColor = Color.WhiteSmoke;
            }
            else if (code == "70")
            {
                label37.BackColor = Color.WhiteSmoke;
            }
            else if (code == "71")
            {
                label34.BackColor = Color.WhiteSmoke;
            }
            else if (code == "72")
            {
                label31.BackColor = Color.WhiteSmoke;
            }
            else if (code == "73")
            {
                label19.BackColor = Color.WhiteSmoke;
            }
            else if (code == "74")
            {
                label32.BackColor = Color.WhiteSmoke;
            }
            else if (code == "75")
            {
                label33.BackColor = Color.WhiteSmoke;
            }
            else if (code == "76")
            {
                label30.BackColor = Color.WhiteSmoke;
            }
            else if (code == "77")
            {
                label43.BackColor = Color.WhiteSmoke;
            }
            else if (code == "78")
            {
                label42.BackColor = Color.WhiteSmoke;
            }
            else if (code == "79")
            {
                label16.BackColor = Color.WhiteSmoke;
            }
            else if (code == "80")
            {
                label2.BackColor = Color.WhiteSmoke;
            }
            else if (code == "81")
            {
                label24.BackColor = Color.WhiteSmoke;
            }
            else if (code == "82")
            {
                label23.BackColor = Color.WhiteSmoke;
            }
            else if (code == "83")
            {
                label35.BackColor = Color.WhiteSmoke;
            }
            else if (code == "84")
            {
                label20.BackColor = Color.WhiteSmoke;
            }
            else if (code == "85")
            {
                label18.BackColor = Color.WhiteSmoke;
            }
            else if (code == "86")
            {
                label48.BackColor = Color.WhiteSmoke;
            }
            else if (code == "87")
            {
                label21.BackColor = Color.WhiteSmoke;
            }
            else if (code == "88")
            {
                label46.BackColor = Color.WhiteSmoke;
            }
            else if (code == "89")
            {
                label17.BackColor = Color.WhiteSmoke;
            }
            else if (code == "90")
            {
                label49.BackColor = Color.WhiteSmoke;
            }




        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var code = e.KeyValue.ToString();
            var color = label51.BackColor.ToString();
            /*MessageBox.Show(code);*/
            if (code == "20")
            {
                if (color == "Color [White]")
                {
                    label51.BackColor = Color.Yellow;
                    label38.Text = "A";
                    label45.Text = "B";
                    label47.Text = "C";
                    label36.Text = "D";
                    label22.Text = "E";
                    label37.Text = "F";
                    label34.Text = "G";
                    label31.Text = "H";
                    label19.Text = "I";
                    label32.Text = "J";
                    label33.Text = "K";
                    label30.Text = "L";
                    label43.Text = "M";
                    label42.Text = "N";
                    label16.Text = "O";
                    label2.Text = "P";
                    label24.Text = "Q";
                    label23.Text = "R";
                    label35.Text = "S";
                    label20.Text = "T";
                    label18.Text = "U";
                    label48.Text = "V";
                    label21.Text = "W";
                    label46.Text = "X";
                    label17.Text = "Y";
                    label49.Text = "Z";
                }
                else if (color == "Color [Yellow]")
                {
                    label51.BackColor = Color.White;
                    label38.Text = "a";
                    label45.Text = "b";
                    label47.Text = "c";
                    label36.Text = "d";
                    label22.Text = "e";
                    label37.Text = "f";
                    label34.Text = "g";
                    label31.Text = "h";
                    label19.Text = "i";
                    label32.Text = "j";
                    label33.Text = "k";
                    label30.Text = "l";
                    label43.Text = "m";
                    label42.Text = "n";
                    label16.Text = "o";
                    label2.Text = "p";
                    label24.Text = "q";
                    label23.Text = "r";
                    label35.Text = "s";
                    label20.Text = "t";
                    label18.Text = "u";
                    label48.Text = "v";
                    label21.Text = "w";
                    label46.Text = "x";
                    label17.Text = "y";
                    label49.Text = "z";
                }


            }
            else if (code == "8")
            {
                label12.BackColor = Color.LightSkyBlue;
                string text = label50.Text;
                if (text.Length != 0) {
                    var a = text.Remove(text.Length - 1);
                    label50.Text = a;
                }

            } 
            else if (code == "32")
            {
                label40.BackColor = Color.LightSkyBlue;
                label50.Text += " ";
            }

            else if (code == "65") {
                label38.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "a";

                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "A";
                }
            }
            else if (code == "66") {
                label45.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "b";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "B";
                }
            }
            else if (code == "67")
            {
                label47.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "c";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "C";
                }
            }
            else if (code == "68")
            {
                label36.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "d";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "D";
                }
            }
            else if (code == "69")
            {
                label22.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "e";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "E";
                }
            }
            else if (code == "70")
            {
                label37.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "f";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "F";
                }
            }
            else if (code == "71")
            {
                label34.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "g";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "G";
                }
            }
            else if (code == "72")
            {
                label31.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "h";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "H";
                }
            }
            else if (code == "73")
            {
                label19.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "i";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "I";
                }
            }
            else if (code == "74")
            {
                label32.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "j";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "J";
                }
            }
            else if (code == "75")
            {
                label33.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "k";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "K";
                }
            }
            else if (code == "76")
            {
                label30.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "l";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "L";
                }
            }
            else if (code == "77")
            {
                label43.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "m";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "M";
                }
            }
            else if (code == "78")
            {
                label42.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "n";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "N";
                }
            }
            else if (code == "79")
            {
                label16.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "o";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "O";
                }
            }
            else if (code == "80")
            {
                label2.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "p";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "P";
                }
            }
            else if (code == "81")
            {
                label24.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "q";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "Q";
                }
            }
            else if (code == "82")
            {
                label23.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "r";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "R";
                }
            }
            else if (code == "83")
            {
                label35.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "s";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "S";
                }
            }
            else if (code == "84")
            {
                label20.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "t";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "T";
                }
            }
            else if (code == "85")
            {
                label18.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "u";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "U";
                }
            }
            else if (code == "86")
            {
                label48.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "v";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "V";
                }
            }
            else if (code == "87")
            {
                label21.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "w";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "W";
                }
            }
            else if (code == "88")
            {
                label46.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "x";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "X";
                }
            }
            else if (code == "89")
            {
                label17.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "y";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "Y";
                }
            }
            else if (code == "90")
            {
                label49.BackColor = Color.LightSkyBlue;
                if (color == "Color [White]")
                {
                    label50.Text += "z";
                }
                else if (color == "Color [Yellow]")
                {
                    label50.Text += "Z";
                }
            }
        }
        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {
            
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }




    }
}
