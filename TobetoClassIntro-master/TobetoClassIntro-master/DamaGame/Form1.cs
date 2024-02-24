namespace DamaGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button[,] btns = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i <= btns.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= btns.GetUpperBound(1); j++)
                {
                    btns[i, j] = new Button();
                    btns[i, j].Width = 50;
                    btns[i, j].Height = 50;
                    btns[i, j].Left = left;
                    btns[i, j].Top = top;
                    left += 50;
                    this.Controls.Add(btns[i, j]);
                    if ((i + j) % 2 == 0)
                    {
                        btns[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        btns[i, j].BackColor = Color.White;

                    }
                }
                top += 50;
                left = 0;

            }
        }
        
    }
}