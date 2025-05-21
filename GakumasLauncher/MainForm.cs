namespace GakumasLauncher
{
    public partial class MainForm : Form
    {
        private GakumasArgs? _currentArgs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _currentArgs = ArgumentExtractor.Extract();
                UpdateArgmentControls(_currentArgs);
            }
            catch (Exception ex)
            {
                _currentArgs = null;
                ClearArgmentControls();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateArgmentControls(GakumasArgs args)
        {
            textBox_date.Text = args.DateTime.ToString("yyyy-MM-dd HH:mm:ss");
            textBox_viewer_id.Text = args.ViewerId;
            textBox_open_id.Text = args.OpenId;
            textBox_pf_access_token.Text = args.PfAccessToken;
            textBox_exe_path.Text = args.ExePath.Replace(@"\\", @"\");
        }

        private void ClearArgmentControls()
        {
            textBox_date.Text = string.Empty;
            textBox_viewer_id.Text = string.Empty;
            textBox_open_id.Text = string.Empty;
            textBox_pf_access_token.Text = string.Empty;
            textBox_exe_path.Text = string.Empty;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                _currentArgs = ArgumentExtractor.Extract();
                UpdateArgmentControls(_currentArgs);
                MessageBox.Show("Arguments updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _currentArgs = null;
                ClearArgmentControls();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {
            if (_currentArgs is null)
            {
                MessageBox.Show("No arguments available to launch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _currentArgs.StartProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_args_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
                textBox.PasswordChar = '\0';
        }

        private void textBox_args_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
                textBox.PasswordChar = '*';
        }
    }
}
