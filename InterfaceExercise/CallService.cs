using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class CallService : IActivity
    {
        private Video _video;
        public CallService(Video video)
        {
            _video = video;
        }

        public void Execute()
        {
            Console.WriteLine("Call company that video: {0} is ready to encode", _video.Name);
        }
    }
}
