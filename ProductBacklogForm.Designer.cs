namespace AgilePlannerDevCode
{
    partial class ProductBacklogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridUserStories = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            AcceptanceCriteria = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            lblCriteriaAcceptance = new Label();
            txtDescription = new TextBox();
            txtAcceptanceCriteria = new TextBox();
            btnAddStory = new Button();
            btnClearFields = new Button();
            btnClear = new Button();
            btnBackToSetup = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridUserStories).BeginInit();
            SuspendLayout();
            // 
            // dataGridUserStories
            // 
            dataGridUserStories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridUserStories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridUserStories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUserStories.Columns.AddRange(new DataGridViewColumn[] { Title, Description, AcceptanceCriteria });
            dataGridUserStories.Location = new Point(10, 50);
            dataGridUserStories.Name = "dataGridUserStories";
            dataGridUserStories.RowHeadersVisible = false;
            dataGridUserStories.RowHeadersWidth = 62;
            dataGridUserStories.Size = new Size(760, 300);
            dataGridUserStories.TabIndex = 0;
            // 
            // Title
            // 
            Title.DataPropertyName = "(ninguno)";
            Title.HeaderText = "Title";
            Title.MinimumWidth = 8;
            Title.Name = "Title";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            // 
            // AcceptanceCriteria
            // 
            AcceptanceCriteria.HeaderText = "Acceptance Criteria";
            AcceptanceCriteria.MinimumWidth = 8;
            AcceptanceCriteria.Name = "AcceptanceCriteria";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.Location = new Point(10, 384);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(60, 28);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(231, 381);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescription.Location = new Point(10, 443);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(126, 28);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // lblCriteriaAcceptance
            // 
            lblCriteriaAcceptance.AutoSize = true;
            lblCriteriaAcceptance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCriteriaAcceptance.Location = new Point(10, 502);
            lblCriteriaAcceptance.Name = "lblCriteriaAcceptance";
            lblCriteriaAcceptance.Size = new Size(202, 28);
            lblCriteriaAcceptance.TabIndex = 4;
            lblCriteriaAcceptance.Text = "Acceptance Criteria:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(231, 440);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 5;
            // 
            // txtAcceptanceCriteria
            // 
            txtAcceptanceCriteria.Location = new Point(231, 499);
            txtAcceptanceCriteria.Name = "txtAcceptanceCriteria";
            txtAcceptanceCriteria.Size = new Size(150, 31);
            txtAcceptanceCriteria.TabIndex = 6;
            // 
            // btnAddStory
            // 
            btnAddStory.BackColor = Color.FromArgb(0, 122, 204);
            btnAddStory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddStory.ForeColor = Color.White;
            btnAddStory.Location = new Point(446, 437);
            btnAddStory.Name = "btnAddStory";
            btnAddStory.Size = new Size(150, 40);
            btnAddStory.TabIndex = 7;
            btnAddStory.Text = "Add";
            btnAddStory.UseVisualStyleBackColor = false;
            btnAddStory.Click += btnAddStory_Click;
            // 
            // btnClearFields
            // 
            btnClearFields.BackColor = Color.FromArgb(0, 122, 204);
            btnClearFields.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClearFields.ForeColor = Color.White;
            btnClearFields.Location = new Point(446, 483);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(150, 40);
            btnClearFields.TabIndex = 8;
            btnClearFields.Text = "Clear Fields";
            btnClearFields.UseVisualStyleBackColor = false;
            btnClearFields.Click += btnClearFields_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 122, 204);
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(609, 437);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 40);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear Table";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackToSetup
            // 
            btnBackToSetup.BackColor = Color.FromArgb(0, 122, 204);
            btnBackToSetup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBackToSetup.ForeColor = Color.White;
            btnBackToSetup.Location = new Point(609, 483);
            btnBackToSetup.Name = "btnBackToSetup";
            btnBackToSetup.Size = new Size(150, 40);
            btnBackToSetup.TabIndex = 10;
            btnBackToSetup.Text = "Back";
            btnBackToSetup.UseVisualStyleBackColor = false;
            btnBackToSetup.Click += btnBackToSetup_Click;
            // 
            // ProductBacklogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(778, 544);
            Controls.Add(btnBackToSetup);
            Controls.Add(btnClear);
            Controls.Add(btnClearFields);
            Controls.Add(btnAddStory);
            Controls.Add(txtAcceptanceCriteria);
            Controls.Add(txtDescription);
            Controls.Add(lblCriteriaAcceptance);
            Controls.Add(lblDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(dataGridUserStories);
            Name = "ProductBacklogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Backlog - Agile Planner";
            Load += ProductBacklogForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUserStories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridUserStories;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn AcceptanceCriteria;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblDescription;
        private Label lblCriteriaAcceptance;
        private TextBox txtDescription;
        private TextBox txtAcceptanceCriteria;
        private Button btnAddStory;
        private Button btnClearFields;
        private Button btnClear;
        private Button btnBackToSetup;
    }
}