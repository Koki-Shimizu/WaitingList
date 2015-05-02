using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WaitingList.Models
{
    public class Site
    {
        public int Id { get; set; }

        [DisplayName("サイト名")]
        public string Name { get; set; }

        [DisplayName("説明")]
        public string Description { get; set; }

        [DisplayName("作成日")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("未完了件数")]
        public int UncompletedCount { get; set; }

        [DisplayName("完了日時")]
        public Nullable<DateTime> CompletedDate { get; set; }
    }
}