using System;
using System.Windows.Forms;

namespace Tasks
{
    public partial class TaskForm : Form
    {
        Task task;
        public TaskForm()
        {
            InitializeComponent();
            add_edit_btn.Click += add_Click;
        }
        public TaskForm(int id)
        {
            InitializeComponent();
            InitializeTask(id);
            SetTask();
            add_edit_btn.Click += edit_Click;
        }
        void InitializeTask(int id)
        {

        }
        void SetTask()
        {

        }
        private void add_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void edit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
