using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AutokNyilvantartasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool nemUres = true;
        private void button1_Click(object sender, EventArgs e)
        {
            //List<string> autok = new List<string>();
            string[] auto = new string[6];

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.Text == "")
                {
                    //textBox.BackColor = Color.Yellow;
                    nemUres = false;
                    MessageBox.Show("Minden mező kitöltése kötelező!");
                    textBox.Focus();
                    return;
                }
                else
                {
                    auto[textBox.TabIndex - 1] = textBox.Text;
                }
            }

            foreach (ComboBox comboBox in this.Controls.OfType<ComboBox>())
            {
                if (comboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Egy elem választása kötelező!");
                    comboBox.Focus();
                    return;
                }
                else
                {
                    auto[comboBox.TabIndex - 1] = comboBox.Text;
                }
            }

            foreach (Control datetimePicker in this.Controls.OfType<DateTimePicker>())
            {
                auto[datetimePicker.TabIndex - 1] = datetimePicker.Text;
            }

            StreamWriter kiir = new StreamWriter("Autok.txt", true, Encoding.Default);
            foreach (var item in auto)
            {
                //Debug.Print(item);
                kiir.WriteLine(item);
            }
                kiir.Close();
        }


        private void tbxRendszam_MouseMove(object sender, MouseEventArgs e)
        {

        }

    }
}
