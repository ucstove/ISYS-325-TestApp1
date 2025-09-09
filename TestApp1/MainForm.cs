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

            try
            {
                int test = int.Parse(testTextBox.Text);
                helloworldLabel.Text = $"You are {test} years old!";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.");
            }
            finally
            {
                carPicture.Visible = !carPicture.Visible;
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
