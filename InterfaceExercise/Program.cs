using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video { Name = "Test", Owner = "Donald" };
            Workflow workflow = new Workflow();
            workflow.AddActivity(new UploadToCloudStorage(video));
            workflow.AddActivity(new CallService(video));
            workflow.AddActivity(new SendEmail());
            workflow.AddActivity(new Database());

            WorklfowEngine worklfowEngine = new WorklfowEngine();

            worklfowEngine.Run(workflow);
        }
    }
}
