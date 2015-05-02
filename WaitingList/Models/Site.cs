using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaitingList.Models
{
    public class Site
    {
        public int Id { get; set; }

        [DisplayName("サイト名")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "名前は50文字以内で記載してください。")]
        public string Name { get; set; }

        [DisplayName("説明")]
        [StringLength(255, ErrorMessage = "説明文は255文字以内で記載してください。")]
        public string Description { get; set; }

        [DisplayName("作成日")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [DisplayName("未完了件数")]
        public int UncompletedCount { get; set; }

        [DisplayName("完了日時")]
        [DisplayFormat(NullDisplayText = "進行中")]
        public DateTime? CompletedDate { get; set; }
    }
}