prompts = new List<string>
     {
         "What special thing happened today?"
         "what did i learn today?"
         "What progress did i make today?"
         "How did i see the hand of the lord in my life today?"
         "What was my profit tiday?"
     }
     public GetRandomPrompt()
     {
         Random random = new Random();
         string prompt = prompts[random.Next(prompts.Count)];
     }
