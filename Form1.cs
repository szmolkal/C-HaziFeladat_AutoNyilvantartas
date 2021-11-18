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
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 100;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this.tbxRendszam, "Kötőjel nélkül! Add meg a rendszámot (XYZ123) - pontosan 6 karakter!");
            toolTip.SetToolTip(this.btnKuldes, "Adatok tárolása.");
            toolTip.SetToolTip(this.btnVisszatoltes, "Adatok visszatöltése.");

            cbxGyartmany.Items.Add("Mercedes");
            cbxGyartmany.Items.Add("Volks Wagen");
            cbxGyartmany.Items.Add("Audi");
            cbxGyartmany.Items.Add("Peugeot");
            cbxGyartmany.Items.Add("Renault");
            cbxGyartmany.Text = "Válassz!";
        }

        private void tbxRendszam_TextChanged(object sender, EventArgs e)
        {
        }
        private void cbxSzin_Enter(object sender, EventArgs e)
        {
            //Ha a mező üres vagy még nem volt kiválasztva semmi, akkor lenyitjuk a listát.
            if (String.IsNullOrEmpty(cbxSzin.Text) || cbxSzin.Text == "Válassz!")
            {
                cbxSzin.DroppedDown = true;
            }
            else
            {
                //Ha már volt kiválasztott elem (a Text tulajdonság nem üres és nem "Válassz!", akkor nem nyitjuk le a listát, de a felhasználó a mezőbe kattintással is le tudja azt nyitni.
            }
        }

        private void cbxSzin_Click(object sender, EventArgs e)
        {
            if (cbxSzin.DroppedDown)
            {
                Debug.Print("cbxszin_Click() + DroppedDown");
                cbxSzin.DroppedDown = false;
            }
            else
            {
                Debug.Print("cbxszin_Click() + not DroppedDown");
                cbxSzin.DroppedDown = true;
                //cbxSzin.Focus();
            }
        }

        private void cbxSzin_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxSzin.Text))
            {
                cbxSzin.Text = "Válassz!";
                return;
            }
        }

        private void cbxGyartmany_Enter(object sender, EventArgs e)
        {
            //Ha a mező üres vagy még nem volt kiválasztva semmi, akkor lenyitjuk a listát.
            if (String.IsNullOrEmpty(cbxGyartmany.Text) || cbxGyartmany.Text == "Válassz!")
            {
                cbxGyartmany.DroppedDown = true;
            }
            else
            {
                //Ha már volt kiválasztott elem (a Text tulajdonság nem üres és nem "Válassz!", akkor nem nyitjuk le a listát, de a felhasználó a mezőbe kattintással is le tudja azt nyitni.
            }
        }

        private void cbxGyartmany_Leave(object sender, EventArgs e)
        {
            cbxGyartmany.DroppedDown = false;
            if (String.IsNullOrEmpty(cbxGyartmany.Text))
            {
                cbxGyartmany.Text = "Válassz!";
                return;
            }
        }

        private void cbxGyartmany_Click(object sender, EventArgs e)
        {
            if (cbxGyartmany.DroppedDown)
            {
                Debug.Print("cbxGyartmany_Click() + DroppedDown");
                cbxGyartmany.DroppedDown = false;
            }
            else
            {
                Debug.Print("cbxGyartmany_Click() + not DroppedDown");
                cbxGyartmany.DroppedDown = true;
                //cbxGyartmany.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKuldes_Click(object sender, EventArgs e)
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
                    textBox.BackColor = Color.Yellow;
                    textBox.Focus();
                    return;
                }
                else if (textBox.Name == "tbxRendszam")
                {
                    if (textBox.TextLength < 6)
                    {
                        MessageBox.Show("A rendszám hossza nem lehet kevesebb, mint hat karakter!\nPróbáld újra!");
                        textBox.Text = "";
                        textBox.Focus();
                        return;
                    }
                    else
                    {
                        auto[textBox.TabIndex - 1] = textBox.Text.ToUpper();
                    }
                }
                else
                {
                    auto[textBox.TabIndex - 1] = textBox.Text;
                }
                textBox.Text = "";

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
                comboBox.Text = "Válassz!";
            }

            foreach (DateTimePicker datetimePicker in this.Controls.OfType<DateTimePicker>())
            {
                auto[datetimePicker.TabIndex - 1] = datetimePicker.Text;
                datetimePicker.Value = DateTime.Today;
            }

            //--Ez miért nem működik?
            /*foreach (Control control in this.Controls.OfType<CheckBox>())
            {
                if (control.Checked) //Miért nincs a controlnak Checked tulajdonsága?
                {
                    auto[control.TabIndex - 1] = "true";
                }
            }*/

            auto[checkBox1.TabIndex - 1] = checkBox1.Checked.ToString();

            try
            {
                using (StreamWriter kiir = new StreamWriter("Autok.txt", true, Encoding.Default))
                {
                    kiir.WriteLine(String.Join(";", auto, 0, auto.Length));
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                throw;
            }
        }

        private void btnVisszatoltes_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("Autok.txt"))
                {
                    string sor;
                    string[] adatok;
                    int n = 0;

                    while (!streamReader.EndOfStream)
                    {
                        sor = streamReader.ReadLine();
                        adatok = sor.Split(';');

                        for (int m = 0; m < adatok.Length; m++)
                        {
                            dataGridView1[m, n].Value = adatok[m];
                            //Az első sor betöltése az űrlap vezérlőibe:
                            if (n == 0)
                            {
                                foreach (Control control in this.Controls)
                                {
                                    switch (true)
                                    {
                                        case true when control is TextBox:
                                            control.Text = adatok[control.TabIndex - 1];
                                            break;
                                        case true when control is ComboBox:
                                            control.Text = adatok[control.TabIndex - 1];
                                            break;
                                        case true when control is DateTimePicker:
                                            dtpUzembehelyezes.Value = DateTime.Parse(adatok[control.TabIndex - 1]);
                                            break;
                                        case true when control is CheckBox:
                                            if (adatok[control.TabIndex - 1]=="True")
                                            {
                                                checkBox1.Checked = true;
                                            }
                                            else
                                            {
                                                checkBox1.Checked = false;
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                            n++;
                        }
                    }
                    foreach (Control control in this.Controls)
                    {
                        switch (true)
                        {
                            case true when control is TextBox:
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Debug.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return;
                throw;
            }
        }
    }
}