﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Entity
{
    public class Group:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<GroupUser> Users { get; set; }
    }
}
