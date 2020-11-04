using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_206_notepad
{
    public partial class Find : Form
    {

        Form1 mainForm;
        int _posdown = 0;
        int _posup = 0;
        bool _saved;
        string _whatfind;

        public Find()
        {
            InitializeComponent();
        }
        public Find(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            _posup = mainForm.AllText.SelectionStart;
        }
        public TextBox FindText { get => textBox1;}

        public CheckBox WithRegistry { get => checkBoxRegistry; }

        public int Posdown { get => _posdown; set => _posdown = value; }

        private void BtnFind_Click_1(object sender, EventArgs e)
        {
            if (checkBoxRegistry.Checked)
            {
                if (down.Checked)
                {
                    try
                    {
                        Posdown = mainForm.AllText.Text.IndexOf(textBox1.Text, Posdown);
                        if (Posdown == -1)
                            return;
                        mainForm.AllText.SelectionStart = Posdown;
                        mainForm.AllText.SelectionLength = textBox1.Text.Length;
                        Posdown++;
                        mainForm.Activate();
                    }
                    catch { Posdown = 0; };
                }
                else if (uP.Checked)
                {
                    try
                    {
                        Posdown = mainForm.AllText.Text.LastIndexOf(textBox1.Text, Posdown);
                        if (Posdown == -1)
                            return;
                        mainForm.AllText.SelectionStart = Posdown;
                        mainForm.AllText.SelectionLength = textBox1.Text.Length;
                        Posdown--;
                        mainForm.Activate();
                    }
                    catch
                    {
                        Posdown = mainForm.AllText.Text.LastIndexOf(textBox1.Text) + textBox1.Text.Length;
                    };
                }
            }
            else
            {
                if (down.Checked)
                {
                    try
                    {
                        Posdown = mainForm.AllText.Text.IndexOf(textBox1.Text, Posdown, StringComparison.OrdinalIgnoreCase);
                        if (Posdown == -1)
                            return;
                        mainForm.AllText.SelectionStart = Posdown;
                        mainForm.AllText.SelectionLength = textBox1.Text.Length;
                        Posdown++;
                        mainForm.Activate();
                    }
                    catch { Posdown = 0; };
                }
                else if (uP.Checked)
                {
                    try
                    {
                        Posdown = mainForm.AllText.Text.LastIndexOf(textBox1.Text, Posdown, StringComparison.OrdinalIgnoreCase);
                        if (Posdown == -1)
                            return;
                        mainForm.AllText.SelectionStart = Posdown;
                        mainForm.AllText.SelectionLength = textBox1.Text.Length;
                        Posdown--;
                        mainForm.Activate();
                    }
                    catch
                    {
                        Posdown = mainForm.AllText.Text.LastIndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) + textBox1.Text.Length;
                    };
                }
            }
        }

        private void Find_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
