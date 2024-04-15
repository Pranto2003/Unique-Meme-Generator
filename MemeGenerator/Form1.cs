namespace MemeGenerator
{
    public partial class Form1 : Form
    {
        Meme1 meme1;
        Meme2 meme2;
        Meme3 meme3;
        Meme4 meme4;
        Meme5 meme5;
        Meme6 meme6;
        Meme7 meme7;
        Meme8 meme8;
        Meme9 meme9;
        Meme10 meme10;
        int number;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            number = random.Next(1, 11);

            switch (number)
            {
                case 1:
                    meme1 = new Meme1();
                    meme1.Show();
                    break;
                case 2:
                    meme2 = new Meme2();
                    meme2.Show();
                    break;
                case 3:
                    meme3 = new Meme3();
                    meme3.Show();
                    break;
                case 4:
                    meme4 = new Meme4();
                    meme4.Show();
                    break;
                case 5:
                    meme5 = new Meme5();
                    meme5.Show();
                    break;
                case 6:
                    meme6 = new Meme6();
                    meme6.Show();
                    break;
                case 7:
                    meme7 = new Meme7();
                    meme7.Show();
                    break;
                case 8:
                    meme8 = new Meme8();
                    meme8.Show();
                    break;
                case 9:
                    meme9 = new Meme9();
                    meme9.Show();
                    break;
                case 10:
                    meme10 = new Meme10();
                    meme10.Show();
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
