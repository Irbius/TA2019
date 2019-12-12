using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MarkovMachine
{    public partial class Form1 : Form
    {
        public struct MRule
        {
            public string A;
            public string B;
            public bool end;

            public static MRule Parse(string s)
            {
                MRule rule = new MRule();
                string[] buf = s.Split('>');
                if (buf.Length == 2)
                {
                    if (buf[1].Length == 0)
                    {
                        rule.end = false;
                        rule.A = buf[0];
                        rule.B = buf[1];
                        return rule;
                    }
                    if (buf[1][0] == '.')
                    {
                        rule.end = true;
                        rule.B = buf[1].Substring(1);
                    }
                    else
                    {
                        rule.B = buf[1];
                    }
                    rule.A = buf[0];
                    return rule;
                }
                else
                {
                    throw new Exception();
                }
            }

            public override string ToString()
            {
                return this.end == true ? $"{A}>.{B}" : $"{A}>{B}";
            }

            public string Process(string s, out bool change)
            {
                int ind = s.IndexOf(A);
                if (s.IndexOf(A) != -1)
                {
                    change = true;
                    return s.Remove(ind, A.Length).Insert(ind, B);
                }
                change = false;
                return s;
            }
        }

        public class MarkovMachine
        {
            public List<MRule> rules = new List<MRule>();
            public string lastOutput;


            public void AddRule(string s)
            {
                rules.Add(MRule.Parse(s));
            }

            public void DeleteRule(int index)
            {
                rules.RemoveAt(index);
            }
            public void DelereALLRule()
            {
                rules.Clear();
            }
            public List<string> Process(string s)
            {
                List<string> res = new List<string>();
                int n = rules.Count;
                res.Add(s);
                int step = 0;
                while (true)
                {
                    s = rules[step % n].Process(s, out bool ch);
                    if (ch)
                    {
                        res.Add($"[{step % n}]{s}");
                        if (rules[step % n].end == true)
                        {
                            return res;
                        }
                    }
                    step++;
                }
            }

            public static MarkovMachine Load(string path)
            {
                StreamReader sr = new StreamReader(path);
                MarkovMachine res = new MarkovMachine();
                while (!sr.EndOfStream)
                {
                    res.AddRule(sr.ReadLine());
                }
                sr.Close();
                return res;
            }

            public static void Save(string path, MarkovMachine mm)
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (MRule r in mm.rules)
                    sw.WriteLine(r.ToString());
                sw.Close();
            }
        }
        public MarkovMachine MM = new MarkovMachine();
        public Form1()
        {
            InitializeComponent();
        }


        private void загрзитьИзToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                MM.DelereALLRule();
                listBox_Rules.Items.Clear();
                MM = MarkovMachine.Load(filename);
                listBox_Rules.DataSource = MM.rules;                 
            }
            
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (textBox_start.Text.Length > 0)
            {
                listBox_Log.Items.Clear();
                listBox_Log.DataSource = MM.Process(textBox_start.Text);
            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_start.Text.Length > 0)
            {
                MM.AddRule(textBox_Add.Text);
                listBox_Rules.Items.Add(textBox_Add.Text);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Rules.SelectedIndex >= 0)
            {
                MM.DeleteRule(listBox_Rules.SelectedIndex);
                listBox_Rules.Items.RemoveAt(listBox_Rules.SelectedIndex);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listBox_Log.Items.Clear();
        }

        private void button_clear_rules_Click(object sender, EventArgs e)
        {
            MM.DelereALLRule();
            listBox_Log.Items.Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            MarkovMachine.Save(filename, MM);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
