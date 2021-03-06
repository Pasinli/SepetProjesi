﻿using NTier.Core.Core.ENum.Entity;
using System;
using System.Security.Principal;


namespace NTier.Core.Core.Entity
{
    public class CoreEntity : IEntity<Guid>
    {

      

        public Guid ID { get; set; }
        public Status Status { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIp { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedADUserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedADUserName { get; set; }
    }
}
