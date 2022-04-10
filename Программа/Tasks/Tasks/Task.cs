using System;
using System.Collections.Generic;

namespace Tasks
{
    class Task : Subtask
    {
        public DateTime dateTime { private set; get; }
        public string note { private set; get; }
        public List<Subtask> subtasks { private set; get; }

        public Task(string name, int finance, DateTime dateTime,
            string note = null, List<Subtask> subtasks = null, int id = 0)
            : base(name, finance, id)
        {
            this.dateTime = dateTime;
            this.note = note;
            this.subtasks = subtasks;
        }

        public int GetFinances()
        {
            int result = Finance;
            foreach (var subtask in subtasks)
            {
                result += subtask.Finance;
            }
            return result;
        }
    }
}