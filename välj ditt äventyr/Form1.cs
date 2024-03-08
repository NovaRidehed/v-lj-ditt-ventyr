namespace välj_ditt_äventyr
{
    public partial class Form1 : Form
    {


        string scenAText = "Texten för scen a blah blah.";
        string scenBText = "Texten för scen b blah blah.";
        string scenCText = "Texten för scen c blah blah.\r\n\r\nSlut!";
        string scenDText = "Texten för scen d blah blah.";
        string scenEText = "Texten för scen e blah blah.\r\n\r\nSlut!";
        string scenFText = "Texten för scen f blah blah.\r\n\r\nSlut!";
        string scenGText = "Texten för scen g blah blah.\r\n\r\nSlut!";

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = scenAText;
        }

        private void buttonja_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == scenAText)
            {
                textBox1.Text = scenBText;
            }
            else if(textBox1.Text == scenBText)
            {
                textBox1.Text = scenDText;
            }
            else if (textBox1.Text == scenDText)
            {
                textBox1.Text = scenFText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = scenAText;
        }

        private void buttonnej_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == scenAText)
            {
                textBox1.Text = scenCText;
            }
            else if (textBox1.Text == scenBText)
            {
                textBox1.Text = scenEText;
            }
            else if (textBox1.Text == scenDText)
            {
                textBox1.Text = scenGText;
            }
        }
    }
}