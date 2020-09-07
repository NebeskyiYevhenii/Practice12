using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseTask
    {
        public double Estmation { get; set; }
        public TaskTypes Task { get; set; }

        public string Title;
        public string Discription { get; set; }
        public string Id { get; set; }

        private readonly DateTime _createdDate;
        public DateTime UpdatedDate { get; set; }

        public abstract void GetInfo();

        public readonly User _creator;
        
        public User _owner;

        public Statuses Status { get; set; }

        public BaseTask(double estmation, TaskTypes task, string title, string discription, User taskCreator, Statuses status = Statuses.BackLog)
        {
            Estmation = estmation;
            Task = task;
            Title = title;
            Discription = discription;
            Id = Guid.NewGuid().ToString();
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            _creator = taskCreator;
            Status = status;
        }





    }
}
