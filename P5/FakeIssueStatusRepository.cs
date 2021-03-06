using System.Collections.Generic;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> IssueStatuses;

        public FakeIssueStatusRepository()
        {
            IssueStatuses = new List<IssueStatus>();
            IssueStatuses.Add(new IssueStatus
            {
                Id = 0,
                Value = "Open"
            });
            IssueStatuses.Add(new IssueStatus
            {
                Id = 1,
                Value = "Assigned"
            });
            IssueStatuses.Add(new IssueStatus
            {
                Id = 2,
                Value = "Fixed"
            });
            IssueStatuses.Add(new IssueStatus
            {
                Id = 3,
                Value = "Closed - Won't fix"
            });
            IssueStatuses.Add(new IssueStatus
            {
                Id = 4,
                Value = "Closed - Fixed"
            });
            IssueStatuses.Add(new IssueStatus
            {
                Id = 5,
                Value = "Closed - by design"
            });
        }

        public void Add(int Id, string value)
        {
            // Create a new list status and add it to the list
            var newItem = new IssueStatus();
            newItem.Id = Id;
            newItem.Value = value;

            IssueStatuses.Add(newItem);
        }

        public List<IssueStatus> GetAll()
        {
            return IssueStatuses;
        }

        public int GetIdByStatus(string value)
        {
            if (IssueStatuses.Exists(x => x.Value.Equals(value)))
            {
                return IssueStatuses.Find(x => x.Value.Equals(value)).Id;
            }
            else
            {
                // Should this return something else?
                return -1;
            }
        }

        public string GetValueById(int Id)
        {
            if (IssueStatuses.Exists(x => x.Id.Equals(Id)))
            {
                return IssueStatuses.Find(x => x.Id.Equals(Id)).Value;
            }
            else
            {
                // Should this return something else?
                return "";
            }
        }
    }
}
