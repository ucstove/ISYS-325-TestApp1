namespace TestApp1
{
    public partial class MainForm : Form
    {
        private const string HELLO_MSG = "Hello, World!";
        private const string VROOM_MSG = "Vroom, Vroom!";
        public MainForm()
        {
            InitializeComponent();
        }

        private void pushmeButton_Click(object sender, EventArgs e)
        {
            helloworldLabel.ForeColor = Color.Red;
            helloworldLabel.BackColor = Color.Blue;

            int test = int.Parse(testTextBox.Text);
            helloworldLabel.Text = test.ToString();

            carPicture.Visible = !carPicture.Visible;
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

        private void carPicture_Click(object sender, EventArgs e)
        {
            helloworldLabel.Text = VROOM_MSG;
        }
    }
}
