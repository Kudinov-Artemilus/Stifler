namespace StiflerA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string text;
        public char[] word;
        public int hp;
        public int hptrue;
        private void StartButton_Click(object sender, EventArgs e)
        {
            text = StartTextBox.Text;
            hp = 0;
            AnserLabel.Text = null;
            StartTextBox.Text = null;
            word = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                AnserLabel.Text += '.';
                word[i] = '.';
            }

        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            bool words = false;
            int j = 0;
            if (AnswerTextBox.Text.Length == 1)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (AnswerTextBox.Text[0] == text[i])
                    {
                        words = true;
                        hptrue++;
                        word[i] = text[i];
                        AnserLabel.Text = null;
                    }
                }
                if (words == true)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        AnserLabel.Text += word[i];

                    }
                    if (hptrue == text.Length)
                    {
                        MessageBox.Show("Ты победил!");
                    }
                }
                else
                {
                    hp++;
                    string? hpbuff = hp.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    if (hp == 10)
                    {
                        MessageBox.Show("Ты проиграл!");
                        AnserLabel.Text = null;
                        AnserLabel.Text = text;


                    }
                }
            }
            else if (AnswerTextBox.Text.Length > 1)
            {
                if (AnswerTextBox.Text == text)
                {
                    AnserLabel.Text = null;
                    for (int i = 0; i < text.Length; i++)
                    {
                        AnserLabel.Text += text[i];
                    }
                    MessageBox.Show("Ты победил");

                }
                else
                {
                    hp = 10;
                    string? hpbuff = hp.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    MessageBox.Show("Ты проиграл");
                    AnserLabel.Text = null;
                    AnserLabel.Text = text;
                }
            }
            AnswerTextBox.Text = null;
        }
    }
}