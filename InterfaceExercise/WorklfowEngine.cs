using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class WorklfowEngine
    {    
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }

}
