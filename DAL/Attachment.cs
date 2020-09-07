using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Attachment
    { 
        public string Id;
        private readonly string UserId;

        private readonly User UserCreated;
        public string Name { get; set; }
        public string Link { get; set; }

        private readonly DateTime _createdDate;
        public DateTime UpdatedDate { get; set; }
        
        private readonly string TaskId;
        public readonly BaseTask Task;

        public Attachment(string userId, User userCreated, string name, string link, string taskId, BaseTask task)
        {
            UserId = userId;
            UserCreated = userCreated;
            Name = name;
            Link = link;
            TaskId = taskId;
            Task = task;
            Id = Guid.NewGuid().ToString();
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;

        }
    }
}
