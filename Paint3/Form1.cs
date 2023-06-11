namespace Paint3
{
    public partial class Form1 : Form
    {
        private int circleCount = 0;
        private int maxCircleCount = 0;
        private int circleSize = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = 0;
            int y = 0;

            for (int i = 0; i < circleCount; i++)
            {
                Rectangle circleRect = new Rectangle(x, y, circleSize, circleSize);
                g.DrawEllipse(Pens.Green, circleRect);

                x += circleSize;
                y += circleSize;
            }

            base.OnPaint(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCircleCount.Text, out int count) && count > 0)
            {
                circleCount = 0;
                maxCircleCount = count;
                Invalidate();
            }
            else
            {
                MessageBox.Show("¬вед≥ть додатне ц≥ле число.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCircleCount.Text, out int count) && count > 0)
            {
                circleCount = count;
                Invalidate();
            }
            else
            {
                MessageBox.Show("¬вед≥ть додатне ц≥ле число.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}