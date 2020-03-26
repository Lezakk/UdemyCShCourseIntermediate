using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Database : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing video status to Processing in database");
        }
    }
}
