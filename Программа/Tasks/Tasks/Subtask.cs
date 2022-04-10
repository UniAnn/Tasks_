namespace Tasks
{
    class Subtask
    {
        public int Id { private set; get; }
        public string Name { set; get; }
        public int Finance { set; get; }

        public Subtask(string name, int finance, int id = 0)
        {
            Id = id;
            Name = name;
            Finance = finance;
        }
    }
}