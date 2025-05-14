using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;


namespace TranslateProject
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        private void LoadDictionary()
        {
            string path = "dictionary.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            }
            else
            {
                MessageBox.Show("Wrong with file");
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDictionary();
            CoBx1.Items.Add("English to Arabic");
            CoBx1.Items.Add("Arabic TO English");
            CoBx1.SelectedIndex = 0;
            CoBx1.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = TBWord.Text.Trim().ToLower();
            string dirction = CoBx1.SelectedItem.ToString();


            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please, Enter the word and choose the languge", "Fouce");
                return;
            }

            if (dirction == "English to Arabic")
            {
                if (dictionary.ContainsKey(input))
                {
                    TBTran.Text = dictionary[input];
                }

                else
                {
                    MessageBox.Show("The word is not present in the dictionary\n Try Agina", "Wrong Word", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (dirction == "Arabic TO English")
            {
                bool found = false;
                foreach (KeyValuePair<string, string> item in dictionary)
                {
                    if (item.Value.Trim().ToLower() == input)
                    {
                        TBTran.Text = item.Key;
                        found = true;
                        break;
                    }

                }
                if (!found)
                {
                    MessageBox.Show("The word is not present in the dictionary\n Try Agina", "Wrong Word", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show("Choose Languge\n Try Agina", "Wrong Word", MessageBoxButtons.OK);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBTran_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CoBx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb9_Click(object sender, EventArgs e)
        {

        }

        private void lb8_Click(object sender, EventArgs e)
        {

        }
    }
}
