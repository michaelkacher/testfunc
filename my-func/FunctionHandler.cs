﻿using System.Threading.Tasks;

namespace Function
{
    public class FunctionHandler
    {
        public Task<string> Handle(string input)
        {
            // var abc = JsonSerializer.Deserialize<MyModel>(data);
            return Task.FromResult($"Echo: {input}");
        }
    }
}
