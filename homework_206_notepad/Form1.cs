using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_206_notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Font _myfont = new Font(textBox1.Font.Name, textBox1.Font.Size);
            delToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            CutToolStripMenuItem.Enabled = false;
            _saved = false;
            _findform = new Find(this);
            _replaceform = new Replace(this);
            _filename = "Noname";
            _fullfilename = "Noname";
            UndoBuf = string.Empty;
            _scale = 100;
            toolStripLabel4.Text = $"Стр. {textBox1.GetLineFromCharIndex(textBox1.SelectionStart) + 1} Столб {textBox1.SelectionStart - textBox1.GetFirstCharIndexOfCurrentLine() + 1}";
            toolStripLabel3.Text = $"{_scale}%";
            toolStripLabel1.Text = $"{System.Text.Encoding.Default.CodePage}";
        }

        void Save()
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "txt files|*.txt";
            if (File.Exists(_fullfilename))
            {
                sd.Title = _filename;
                using (StreamWriter sw = new StreamWriter(_fullfilename, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(textBox1.Text);
                }
                _saved = true;
            }
            else
            {
                sd.FileName = _filename;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sd.FileName, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(textBox1.Text);
                    }
                    _fullfilename = sd.FileName;
                    _saved = true;
                }
            }
        }

        Font _myfont;
        Find _findform;
        Replace _replaceform;
        bool _saved;
        string _filename;
        string _fullfilename;
        String _UndoBuf;
        bool _Buf = false;
        int _pos = 0;
        int _scale;

        public TextBox AllText { get => textBox1; set => textBox1 = value; }
        public string UndoBuf { get => _UndoBuf; set => _UndoBuf = value; }

        private void wrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = wrapToolStripMenuItem.Checked;
        }
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength == 0 || textBox1.SelectionStart == textBox1.TextLength)
                return;
            if (textBox1.SelectionLength == 0)
            {
                int pos = textBox1.SelectionStart;
                textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, 1);
                textBox1.SelectionStart = pos;
            }
            else
            {
                int pos = textBox1.SelectionStart;
                textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
                textBox1.SelectionStart = pos;
            }

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _findform.Show();
        }

        private void findnextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_findform.FindText.Text == "")
            {
                _findform.Show();
            }
            else
            {
                if (_findform.WithRegistry.Checked)
                {
                    try
                    {
                        _findform.Posdown = AllText.Text.IndexOf(_findform.FindText.Text, _findform.Posdown);
                        if (_findform.Posdown == -1)
                            return;
                        AllText.SelectionStart = _findform.Posdown;
                        AllText.SelectionLength = _findform.FindText.Text.Length;
                        _findform.Posdown++;
                    }
                    catch { _findform.Posdown = 0; };
                }
                else
                {
                    try
                    {
                        _findform.Posdown = AllText.Text.IndexOf(_findform.FindText.Text, _findform.Posdown, StringComparison.OrdinalIgnoreCase);
                        if (_findform.Posdown == -1)
                            return;
                        AllText.SelectionStart = _findform.Posdown;
                        AllText.SelectionLength = _findform.FindText.Text.Length;
                        _findform.Posdown++;
                    }
                    catch { _findform.Posdown = 0; };
                }
                if (_findform.Visible == true)
                {
                    _findform.Visible = false;
                }
            }

        }

        private void findPrevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_findform.FindText.Text == "")
            {
                _findform.Show();
            }
            else
            {
                if (_findform.WithRegistry.Checked)
                {
                    try
                    {
                        _findform.Posdown = AllText.Text.LastIndexOf(_findform.FindText.Text, _findform.Posdown);
                        if (_findform.Posdown == -1)
                            return;
                        AllText.SelectionStart = _findform.Posdown;
                        AllText.SelectionLength = _findform.FindText.Text.Length;
                        _findform.Posdown--;
                    }
                    catch
                    {
                        _findform.Posdown = AllText.Text.LastIndexOf(_findform.FindText.Text) + _findform.FindText.Text.Length;
                    };
                }
                else
                {
                    try
                    {
                        _findform.Posdown = AllText.Text.LastIndexOf(_findform.FindText.Text, _findform.Posdown, StringComparison.OrdinalIgnoreCase);
                        if (_findform.Posdown == -1)
                            return;
                        AllText.SelectionStart = _findform.Posdown;
                        AllText.SelectionLength = _findform.FindText.Text.Length;
                        _findform.Posdown--;
                    }
                    catch
                    {
                        _findform.Posdown = AllText.Text.LastIndexOf(_findform.FindText.Text, StringComparison.OrdinalIgnoreCase) + _findform.FindText.Text.Length;
                    };
                }

            }
            if (_findform.Visible == true)
            {
                _findform.Visible = false;
            }
        }
        private void markallВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _replaceform.Show();
        }
        private void DatetimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, $"{ date.ToShortTimeString()} { date.ToShortDateString()}");
            int pos = textBox1.SelectionLength;
            textBox1.SelectionStart = pos;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _saved = false;
            if (textBox1.SelectionLength != 0)
            {
                delToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                CutToolStripMenuItem.Enabled = true;
            }
            else
            {
                delToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                CutToolStripMenuItem.Enabled = false;
            }
            if (_saved)
            {
                this.Text = $"{_filename} - Notepad";
            }
            else
            {
                this.Text = $"*{_filename} - Notepad";
            }
            toolStripLabel4.Text = $"Стр. {textBox1.GetLineFromCharIndex(textBox1.SelectionStart) + 1} Столб {textBox1.SelectionStart - textBox1.GetFirstCharIndexOfCurrentLine() + 1}";
            toolStripLabel3.Text = $"{_scale}%";
            toolStripLabel1.Text = $"{System.Text.Encoding.Default.CodePage}";
        }

  

        private void scaleminusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Font myfont = new Font(textBox1.Font.Name, textBox1.Font.Size - 5);
                textBox1.Font = myfont;
                _scale -= 5;
            }
            catch { };
        }

        private void slacedafaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = _myfont;
            _scale = 100;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fd = new FontDialog())
            {
                fd.Font = textBox1.Font;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = fd.Font;
                }
            }
        }

        private void statestringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Visible = statestringToolStripMenuItem.Checked;
            statusBar.Visible = statestringToolStripMenuItem.Checked;
        }

        private void statusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (textBox1.SelectionLength != 0)
            {
                delToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                CutToolStripMenuItem.Enabled = true;
            }
            else
            {
                delToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                CutToolStripMenuItem.Enabled = false;
            }
            if (_saved)
            {
                this.Text = $"{_filename} - Notepad";
            }
            else
            {
                this.Text = $"*{_filename} - Notepad";
            }
            toolStripLabel4.Text = $"Стр. {textBox1.GetLineFromCharIndex(textBox1.SelectionStart) + 1} Столб {textBox1.SelectionStart - textBox1.GetFirstCharIndexOfCurrentLine() + 1}";
            toolStripLabel3.Text = $"{_scale}%";
            toolStripLabel1.Text = $"{System.Text.Encoding.Default.CodePage}";
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_saved)
            {
                _filename = "Noname";
                textBox1.Clear();
            }
            else
            {
                var results = MessageBox.Show($"Do you want save file {_filename}?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (results == DialogResult.Yes)
                {
                    Save();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_saved)
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "txt files|*.txt";
                if (od.ShowDialog() == DialogResult.OK)
                {
                    _filename = od.SafeFileName;
                    _fullfilename = od.FileName;
                    using (StreamReader sr = new StreamReader(od.FileName))
                    {
                        textBox1.Text = sr.ReadToEnd();
                    }
                    _saved = true;
                }
            }
            else
            {
                var results = MessageBox.Show($"Do you want save file {_filename}?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (results == DialogResult.Yes)
                {
                    Save();
                    OpenFileDialog od = new OpenFileDialog();
                    od.Filter = "txt files|*.txt";
                    if (od.ShowDialog() == DialogResult.OK)
                    {
                        _filename = od.SafeFileName;
                        _fullfilename = od.FileName;
                        using (StreamReader sr = new StreamReader(od.FileName))
                        {
                            textBox1.Text = sr.ReadToEnd();
                        }
                        _saved = true;
                    }
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void SaveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "txt files|*.txt";
            sd.FileName = _filename;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sd.FileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(textBox1.Text);
                }
                _fullfilename = sd.FileName;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument docToPrint = new PrintDocument();
            PrintDialog pr = new PrintDialog();
            pr.Document = docToPrint;
            if (pr.ShowDialog() == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }
        private void pageparToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PageSetupDialog ps = new PageSetupDialog();
            ps.PageSettings = new PageSettings();
            ps.PrinterSettings = new PrinterSettings();
            if (ps.ShowDialog() == DialogResult.OK)
            {
                var a = ps.PageSettings.Margins;
                textBox1.Margin = new Padding(ps.PageSettings.Margins.Left, ps.PageSettings.Margins.Top, ps.PageSettings.Margins.Right, ps.PageSettings.Margins.Bottom);
            }
        }

        private void proinfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutform = new About();
            aboutform.ShowDialog();
        }

        private void UndotoolStripMenu_Click(object sender, EventArgs e)
        {
            if (UndoBuf != String.Empty)
            {
                textBox1.Text = UndoBuf;
                UndoBuf = String.Empty;
            }
            else
            {
                textBox1.Undo();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!_saved)
                {
                    e.Cancel = true;
                    var results = MessageBox.Show($"Do you want save file {_filename}?", "Notepad", MessageBoxButtons.YesNoCancel);
                    if (results == DialogResult.Yes)
                    {
                        Save();
                        this.Close();
                    }
                    else if (results == DialogResult.No)
                    {
                        _saved = true;
                        this.Close();
                    }
                }
            }
        }

        private void scaleplusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font myfont = new Font(textBox1.Font.Name, textBox1.Font.Size + 5);
            textBox1.Font = myfont;
            _scale += 5;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            toolStripLabel4.Text = $"Стр. {textBox1.GetLineFromCharIndex(textBox1.SelectionStart) + 1} Столб {textBox1.SelectionStart-textBox1.GetFirstCharIndexOfCurrentLine()+1}";
            toolStripLabel3.Text = $"{_scale}%";
            toolStripLabel1.Text = $"{System.Text.Encoding.Default.CodePage}";
        }


    }
}
