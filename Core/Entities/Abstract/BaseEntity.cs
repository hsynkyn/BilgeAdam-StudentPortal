using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace Core.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public DateTime _createdDate = DateTime.Now;
        private Status status = Status.Active;

        public Guid Id { get; set; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }

        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Status Status { get => status; set => status = value; }
    }
}
