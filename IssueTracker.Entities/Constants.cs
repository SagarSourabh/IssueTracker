using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IssueTracker.Entities
{
    public class Constants
    {
        public static class Status
        {
            public enum IssueStatus
            {
                InProgress = 1,
                Closed = 2
            }

            public enum PersonStatus
            {
                Active = 1,
                InActive = 0
            }
        }

        public static class Priority
        {
            public const int Critical = 1;
            public const int High = 2;
            public const int Medium = 3;
            public const int Low = 4;
        }
    }
}