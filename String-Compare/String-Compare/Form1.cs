using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Compare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ScoreLabel.Text = "Score: " + CompareString(StringOneTextBox.Text, StringTwoTextBox.Text).ToString();
                StringOneTextBox.Clear();
                StringTwoTextBox.Clear();
            }
            catch
            {

            }
        }

        private int CompareString(string one, string two)
        {
            #region initialize all variables
            List<string> listOne = new List<string>();
            List<string> listTwo = new List<string>();
            int score = 0;
            #endregion

            // add string to list one
            using (StringReader reader = new StringReader(one))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listOne.Add(line);
                }
            }

            // add string to list two
            using (StringReader reader = new StringReader(two))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listTwo.Add(line);
                }
            }

            // compare stringss
            for (int i = 0; i < listOne.Count; i++)
            {
                if (listOne[i] == listTwo[i])
                {
                    score++;
                }
            }

            return score;
        }
    }
}
