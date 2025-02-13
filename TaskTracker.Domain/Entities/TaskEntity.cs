﻿using System.Collections.Generic;
using TaskTracker.Contracts.DataTypes;
using TaskTracker.Domain.Contracts;
using TaskTracker.Domain.DataTypes;

namespace TaskTracker.Contracts.Entities
{
    public class TaskEntity : BaseEntity
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public TaskStatus Status { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }      
    }
}
