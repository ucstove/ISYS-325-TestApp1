namespace TestApp1
{
    public partial class MainForm : Form
    {
        private const string HELLO_MSG = "Hello, World!";
        public MainForm()
        {
            InitializeComponent();
        }

        private void pushmeButton_Click(object sender, EventArgs e)
        {
            helloworldLabel.ForeColor = Color.Red;
            helloworldLabel.BackColor = Color.Blue;
            helloworldLabel.Text = HELLO_MSG;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            helloworldLabel.Text = "";
        }

        private void helloworldLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
