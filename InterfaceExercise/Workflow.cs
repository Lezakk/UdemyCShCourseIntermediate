using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Workflow : IWorkflow
    {
        private readonly IList<IActivity> activities;

        public Workflow()
        {
            activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return activities;
        }
    }
}
