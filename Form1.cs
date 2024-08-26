using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Terminal_helper
{
    public partial class Terminal : Form
    {

        static public int[][] chars;
        static public string[] words;

        public Terminal()
        {
            InitializeComponent();
            output.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalcBut_Click(object sender, EventArgs e)
        {
            input.Visible = false;
            output.Visible = true;
            scan();
            process();
            print();
        }

        private void ScanBut_Click(object sender, EventArgs e)
        {
            input.Visible = true;
            output.Visible = false;
        }

        public void print()
        {
            DataTable dt = new DataTable();
            
            string[] temp = new string[words.Length];
            dt.Columns.Add("WORDS");
            dt.Columns.Add("¹");
            for (int i = 0; i < words.Length; i++)
            {
                dt.Columns.Add(Convert.ToString(i + 1));
            }
            for (int i = 0; i < words.Length; i++)
            {
                dt.Rows.Add(dt.NewRow());
            }



            DataRow dr;
            for (int i = 0; i < words.Length; i++)
            {
                dt.Rows[i][0] = words[i];
                dt.Rows[i][1] = Convert.ToString(i+1);
                for (int j = 0; j < words.Length; j++)
                {
                    if (i == j)
                    {
                        dt.Rows[i][j+2] = "X";  
                    }
                    else
                    {
                        dt.Rows[i][j+2] = Convert.ToString(chars[i][j]);
                    }
                }
            }
            output.DataSource = dt;
            for (int i = 0; i < words.Length; i++)
            {
                output.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(153, 50, 204);
            }
        }

        public void scan()
        {
            string[] lines = input.Text.ToString().Split(new string[] { "\r", "\n", ",", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\"", ":", " " }, StringSplitOptions.RemoveEmptyEntries);
            List<string> wordList = new List<string>();

            foreach (string line in lines)
            {
                wordList.Add(line);
            }

            words = wordList.ToArray();
            chars = new int[words.Length][];
            for (int i = 0; i < words.Length; i++)
            {
                chars[i] = new int[words.Length];
            }
        }

        public void process()
        {
            int length = words[0].Length;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    int temp = 0;

                    string a = words[i], b = words[j];

                    for (int k = 0; k < length; ++k)
                    {
                        if (a[k] == b[k])
                        {
                            temp++;
                        }
                    }

                    chars[i][j] = temp;
                    chars[j][i] = temp;
                }
            }
        }
    }
}
