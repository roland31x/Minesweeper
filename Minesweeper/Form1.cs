namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Image flag = Image.FromFile(@"../../../Images/flag.png");
        public Image unclicked = Image.FromFile(@"../../../Images/unclicked.jpg");
        public Image[] images = new Image[]
        {
            Image.FromFile(@"../../../Images/0.jpg"),
            Image.FromFile(@"../../../Images/1.jpg"),
            Image.FromFile(@"../../../Images/2.jpg"),
            Image.FromFile(@"../../../Images/3.jpg"),
            Image.FromFile(@"../../../Images/4.jpg"),
            Image.FromFile(@"../../../Images/5.jpg"),
            Image.FromFile(@"../../../Images/6.jpg"),
            Image.FromFile(@"../../../Images/7.jpg"),
            Image.FromFile(@"../../../Images/8.jpg"),
            Image.FromFile(@"../../../Images/mine.jpg"),
            Image.FromFile(@"../../../Images/defusedmine.jpg")
        };
        public Form1()
        {
            InitializeComponent();
            Width = 900;
            Height = 900;
            LoadVisuals();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.Init(this, 16, 40); // 16 - number of lines and columns, 40 - number of mines
            LabelUpdate();
        }
        void LoadVisuals()
        {
            PictureBox1Load();
            Button1Load();
            Label1Load();
            Label2Load();
        }
        void PictureBox1Load()
        {
            pictureBox1.Height = 704;
            pictureBox1.Width = 704;
            pictureBox1.Location = new Point((Height - pictureBox1.Height) / 2, (Width - pictureBox1.Width) / 2);
        }
        void Button1Load()
        {
            button1.Text = "RESET";
            button1.Height = 50;
            button1.Width = 100;
            button1.Location = new Point((Width - button1.Width) / 2, ((pictureBox1.Location.Y) / 2) - button1.Height / 2);
        }
        void Label1Load()
        {
            label1.Text = "000";
            label1.BackColor = Color.Black;
            label1.Height = 80;
            label1.Width = 150;
            label1.AutoSize = false;
            label1.ForeColor = Color.Red;
            label1.Font = new Font("Algerian", 33);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Location = new Point(pictureBox1.Location.X + pictureBox1.Width - label1.Width, ((pictureBox1.Location.Y) / 2) - label1.Height / 2);

        }
        void Label2Load()
        {
            label2.Text = "000";
            label2.BackColor = Color.Black;
            label2.Height = 80;
            label2.Width = 150;
            label2.AutoSize = false;
            label2.ForeColor = Color.Red;
            label2.Font = new Font("Algerian", 33);
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Location = new Point(pictureBox1.Location.X, ((pictureBox1.Location.Y) / 2) - label1.Height / 2);

        }
        public void TimerUpdate()
        {
            label2.Text = (int.Parse(label2.Text) + 1).ToString("000");
        }
        public void LabelUpdate()
        {
            label1.Text = (Engine.mines - Engine.flagsplaced).ToString("000");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Controls.Clear();
            label2.Text = "000";
            Engine.Reset();
            LabelUpdate();
        }
    }
}