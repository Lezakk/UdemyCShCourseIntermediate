using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email to owner about video started procesing.");
        }
    }
}
