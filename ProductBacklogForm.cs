using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgilePlannerDevCode
{
    public partial class ProductBacklogForm : Form
    {
        public ProductBacklogForm()
        {
            InitializeComponent();
        }

        private void ProductBacklogForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtAcceptanceCriteria.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridUserStories.Rows.Add(txtTitle.Text, txtDescription.Text, txtAcceptanceCriteria.Text);
            txtTitle.Clear();
            txtDescription.Clear();
            txtAcceptanceCriteria.Clear();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtAcceptanceCriteria.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridUserStories.Rows.Clear();
        }

        private void btnBackToSetup_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectSetupForm setupForm = new ProjectSetupForm();
            setupForm.ShowDialog();
            this.Close();
        }
    }
}
