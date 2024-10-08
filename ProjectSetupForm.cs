namespace AgilePlannerDevCode;

public partial class ProjectSetupForm : Form
{
    public ProjectSetupForm()
    {
        InitializeComponent();
        btnGoToBacklog.Enabled = false;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void buttonSubmit_Click(object sender, EventArgs e)
    {
        string projectName = txtProjectName.Text;

        if (string.IsNullOrEmpty(projectName))
        {
            MessageBox.Show("Please enter a project name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            MessageBox.Show($"Project '{projectName}' created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnGoToBacklog_Click(object sender, EventArgs e)
    {
        this.Hide();
        ProductBacklogForm backlogForm = new ProductBacklogForm();
        backlogForm.ShowDialog();
        this.Close();
    }

    private void txtProjectName_TextChanged(object sender, EventArgs e)
    {
        btnGoToBacklog.Enabled = !string.IsNullOrWhiteSpace(txtProjectName.Text);
    }
}
