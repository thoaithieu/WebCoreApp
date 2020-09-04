﻿using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    public class Logging : DomainEntity<int>
    {
        public DateTime ActionDate { get; set; }

        public string Message { get; set; }

        public string ActionType { get; set; }

        public Logging(DateTime actionDate, string message, string actionType)
        {
            ActionDate = actionDate;
            Message = message;
            ActionType = actionType;
        }
    }
}
