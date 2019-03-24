using System.Collections.Generic;

namespace Design_a_workflow_engine
{

    public class Workflow
    {
        private readonly List<IActivity> _activities = new List<IActivity>();

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public List<IActivity> GetActivities
        {
            get
            {
                return _activities;
            }
        }

    }
}
