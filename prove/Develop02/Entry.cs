        public class Entry
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
