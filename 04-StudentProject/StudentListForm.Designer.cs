namespace _04_StudentProject
{
    partial class StudentListForm
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
            listBoxStudents = new ListBox();
            SuspendLayout();
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(50, 38);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(666, 344);
            listBoxStudents.TabIndex = 0;

            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxStudents);
            Name = "StudentListForm";
            Text = "StudentListForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxStudents;
    }
}