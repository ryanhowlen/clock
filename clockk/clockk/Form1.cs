namespace clockk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm");
            labelSec.Text = DateTime.Now.ToString("ss");
            labelDay.Text = DateTime.Now.ToString("dddd");
            labelDate.Text = DateTime.Now.ToString("dd MMMM yyy");
            labelSec.Location = new Point(labelTime.Location.X + labelTime.Width-5, labelSec.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}