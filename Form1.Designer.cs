namespace AgilePlannerDevCode
{
    partial class formMain
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
            textBoxProjectName = new TextBox();
            buttonSubmit = new Button();
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
            // textBoxProjectName
            // 
            textBoxProjectName.Font = new Font("Segoe UI", 12F);
            textBoxProjectName.ForeColor = Color.Black;
            textBoxProjectName.Location = new Point(150, 120);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.Size = new Size(300, 39);
            textBoxProjectName.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.FromArgb(0, 122, 204);
            buttonSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSubmit.ForeColor = Color.White;
            buttonSubmit.Location = new Point(225, 180);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(150, 40);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Create Project";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(578, 344);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxProjectName);
            Controls.Add(labelTitle);
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agile Planner - Project Setup";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxProjectName;
        private Button buttonSubmit;
    }
}
