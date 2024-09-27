    using system

    public class Resume();
    {
        public string _name;
        public List<Job> jobs = new list<job>();
    
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }
}