using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tasks
{
    public partial class MainForm : Form
    {
        DateTime selectedDate;
        List<Task> tasks;
        public MainForm()
        {
            InitializeComponent();
            selectedDate = DateTime.Now;
        }
        void UpdateCalendar()
        {

        }
        void LoadTasks(DateTime date)
        {

        }
        void ShowCompleted(bool isShow = true)
        {

        }
        double GetFinances(DateTime date)
        {
            return 0;
        }
        void AddTask(DateTime date)
        {

        }
        void OpenTask(int id)
        {

        }
        void CompleteTask(int id)
        {

        }
    }
}
