using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class UploadToCloudStorage : IActivity
    {
        private Video _video;
        public UploadToCloudStorage(Video video)
        {
            _video = video;
        }
        public void Execute()
        {
            Console.WriteLine("Upload video: {0} to Cloud", _video.Name);
        }
    }
}
