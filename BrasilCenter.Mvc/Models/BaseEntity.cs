using System;
using System.Collections.Generic;
using System.Text;

namespace BrasilCenter.Business.Models
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
