namespace AgilePlannerDevCode
{
    partial class ProjectSetupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            txtProjectName = new TextBox();
            btnSubmit = new Button();
            btnGoToBacklog = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(51, 51, 51);
            labelTitle.Location = new Point(175, 50);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(261, 38);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Enter Projec Name";
            // 
            // txtProjectName
            // 
            txtProjectName.Font = new Font("Segoe UI", 12F);
            txtProjectName.ForeColor = Color.Black;
            txtProjectName.Location = new Point(155, 120);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(300, 39);
            txtProjectName.TabIndex = 1;
            txtProjectName.TextChanged += txtProjectName_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 122, 204);
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(230, 180);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 40);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Create Project";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += buttonSubmit_Click;
            // 
            // btnGoToBacklog
            // 
            btnGoToBacklog.BackColor = Color.FromArgb(0, 122, 204);
            btnGoToBacklog.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGoToBacklog.ForeColor = Color.White;
            btnGoToBacklog.Location = new Point(230, 238);
            btnGoToBacklog.Name = "btnGoToBacklog";
            btnGoToBacklog.Size = new Size(150, 40);
            btnGoToBacklog.TabIndex = 3;
            btnGoToBacklog.Text = "Next";
            btnGoToBacklog.UseVisualStyleBackColor = false;
            btnGoToBacklog.Click += btnGoToBacklog_Click;
            // 
            // ProjectSetupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(578, 344);
            Controls.Add(btnGoToBacklog);
            Controls.Add(btnSubmit);
            Controls.Add(txtProjectName);
            Controls.Add(labelTitle);
            Name = "ProjectSetupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agile Planner - Project Setup";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox txtProjectName;
        private Button btnSubmit;
        private Button btnGoToBacklog;
    }
}
