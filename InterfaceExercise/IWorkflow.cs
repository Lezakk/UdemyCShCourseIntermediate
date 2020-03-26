using System.Collections.Generic;

namespace InterfaceExercise
{
    interface IWorkflow
    {
        IEnumerable<IActivity> GetActivities();
        void AddActivity(IActivity activity);
    }
}