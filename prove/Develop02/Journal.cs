public class Journal
{
       public Entry()
        { 
            Console.writeLine("Today's journal " + DateTime.Now);
            Console.WriteLine("prompt: " + prompt)
            Console.Write("input: ");
            string reply = Console.ReadLine();
            Entry entry = new Entry(prompt, reply, DateTime.Now);
            Input.Add(entry);
            
            Console.Writeline("Input saved!");
        }
        Public display()
        {
            foreach(inputs in Input)
            {
                Console.WriteLine($"prompt{inputs.prompt}")
                Console.WriteLine($"{inputs.Date.ToString("yyyy-MM-dd")}")
                
            }
        }
        public saveJournal()
        {
            Console.WriteLine("Type in the filename")
            fileNane = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                foreach(inputs in Input)
                {
                    Console.WriteLine($"prompt{inputs.prompt}")
                    Console.WriteLine($"prompt{inputs.reply}")
                    Console.WriteLine($"{inputs.Date.ToString("yyyy-MM-dd")}")
                    
                }
            }

        }
        public void loadJournal()
        {
            Console.Write("Enter a file name: ");
            string fileNane = Console.ReadLine();
            input.clear();
            using (StreamReader reader = new StreamReader(fileNane))
            {

                string line;
                Entry input = null;
                while ((line =reader.ReadLine())) != null
                {
                    if (Line.startWith("Date; "))
                    (
                        input = new Input();
                        input.Date = DateTime.Parse(line.Substring(6));
                    )
                    else if (line.SrartWith("prompt: "))
                    {
                        input.prompt = line.Substring(8);
                    }
                    else if (line.SrartWith("reply: "))
                    {
                        input.reply = line.Substring(9);
                        Input.Add(input);

                    }
        }
            }
