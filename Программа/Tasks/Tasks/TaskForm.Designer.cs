
namespace Tasks
{
    partial class TaskForm
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
            this.add_edit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_edit_btn
            // 
            this.add_edit_btn.Location = new System.Drawing.Point(702, 405);
            this.add_edit_btn.Name = "add_edit_btn";
            this.add_edit_btn.Size = new System.Drawing.Size(75, 23);
            this.add_edit_btn.TabIndex = 0;
            this.add_edit_btn.Text = "button1";
            this.add_edit_btn.UseVisualStyleBackColor = true;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_edit_btn);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_edit_btn;
    }
}