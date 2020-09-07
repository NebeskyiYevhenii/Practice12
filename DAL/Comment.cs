using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Comment
    {
        public string Id { get; set; }
        
        public string CommentText { get; set; }

        private readonly DateTime _createdDate;
        public DateTime UpdatedDate { get; set; }

        public readonly string TaskId;
        public readonly string AuthorId;
        public Comment (string authorId, string commentText, string taskId)
        {
            Id = Guid.NewGuid().ToString();
            AuthorId = authorId;
            CommentText = commentText;
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            TaskId = taskId;
        }



    }
}
