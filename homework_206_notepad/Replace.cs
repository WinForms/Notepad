using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_206_notepad
{
    public partial class Replace : Form
    {
        public Replace()
        {
            InitializeComponent();
        }
        Form1 mainForm;
        int _posdown = 0;
        string _whatReplace;
        string _whithReplace;



        public Replace(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }
        public TextBox TextBoxwhat { get => textBoxwhat; }
        public TextBox TextBoxwith { get => textBoxwith; }

        public CheckBox WithRegistry { get => checkBoxRegistry; }

        private void textBoxwhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxwith_TextChanged(object sender, EventArgs e)
        {

        }

        public int Posdown { get => _posdown; set => _posdown = value; }
        private void BtnFind_Click_Click(object sender, EventArgs e)
        {
            if (checkBoxRegistry.Checked)
            {
                    try
                    {
                        Posdown = mainForm.AllText.Text.IndexOf(TextBoxwhat.Text, Posdown);
                        if (Posdown == -1)
                            return;
                        mainForm.AllText.SelectionStart = Posdown;
                        mainForm.AllText.SelectionLength = TextBoxwhat.Text.Length;
                        Posdown++;
                        mainForm.Activate();
                    }
                    catch { Posdown = 0; };
                
            }
            else
            {
                    try
                    {
                        Posdown = mainForm.AllText.Text.IndexOf(TextBoxwhat.Text, Posdown, StringComparison.OrdinalIgnoreCase);
                        if (Posdown == -1)
                            return;
                        mainForm.AllText.SelectionStart = Posdown;
                        mainForm.AllText.SelectionLength = TextBoxwhat.Text.Length;
                        Posdown++;
                        mainForm.Activate();
                    }
                    catch { Posdown = 0; };
            }

        }

        private void Replace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            if (checkBoxRegistry.Checked)
            {
                _whithReplace = TextBoxwith.Text;
                _whatReplace = TextBoxwhat.Text;
                if (mainForm.AllText.Text != mainForm.AllText.Text.Replace(_whatReplace, _whithReplace))
                { mainForm.UndoBuf = mainForm.AllText.Text; }
                mainForm.AllText.Text = mainForm.AllText.Text.Replace(_whatReplace, _whithReplace);
            }
            else
            {
                _whithReplace = TextBoxwith.Text;
                _whatReplace = TextBoxwhat.Text;
                if (mainForm.AllText.Text != Regex.Replace(mainForm.AllText.Text, _whatReplace, _whithReplace, RegexOptions.IgnoreCase))
                { mainForm.UndoBuf = mainForm.AllText.Text; }
                mainForm.AllText.Text = Regex.Replace(mainForm.AllText.Text, _whatReplace, _whithReplace, RegexOptions.IgnoreCase);
            }
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (checkBoxRegistry.Checked)
            {
                try
                {
                    Posdown = mainForm.AllText.Text.IndexOf(TextBoxwhat.Text, Posdown);
                    if (Posdown == -1)
                        return;
                    mainForm.UndoBuf = mainForm.AllText.Text;
                    mainForm.AllText.Text = mainForm.AllText.Text.Remove(Posdown, TextBoxwhat.Text.Length);
                    mainForm.AllText.Text = mainForm.AllText.Text.Insert(Posdown, TextBoxwith.Text);
                    mainForm.AllText.SelectionStart = Posdown + TextBoxwith.Text.Length;
                    Posdown++;
                    mainForm.Activate();
                }
                catch { Posdown = 0; };

            }
            else
            {
                try
                {
                    Posdown = mainForm.AllText.Text.IndexOf(TextBoxwhat.Text, Posdown, StringComparison.OrdinalIgnoreCase);
                    if (Posdown == -1)
                        return;
                    mainForm.UndoBuf = mainForm.AllText.Text;
                    mainForm.AllText.Text = mainForm.AllText.Text.Remove(Posdown, TextBoxwhat.Text.Length);
                    mainForm.AllText.Text = mainForm.AllText.Text.Insert(Posdown, TextBoxwith.Text);
                    mainForm.AllText.SelectionStart = Posdown + TextBoxwith.Text.Length;
                    Posdown++;
                    mainForm.Activate();
                }
                catch { Posdown = 0; };
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


