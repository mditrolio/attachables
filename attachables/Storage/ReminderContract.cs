﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ninlabs.attachables.Models;

namespace ninlabs.attachables.Storage
{
    public class ReminderContract
    {
        public long Id { get; set; }

        public String ConditionAsString { get; set; }

        // NotificationType (since down grading to .NET 4, EF 5 doesn't support enums in this context)
        public int NotificationType { get; set; }

        public String ReminderMessage { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? SnoozeUntil { get; set; }

        public string SourcePath { get; set; }
        public int LineStart { get; set; }

        public DateTime? CompletedOn { get; set; }
    }}
