using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaitingList.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UncompletedCount { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}