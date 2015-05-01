using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WaitingList.Models
{
    public class SiteInitializer : DropCreateDatabaseAlways<SiteContext>
    {
        protected override void Seed(SiteContext context)
        {
            var sites = new List<Site>
            {
                new Site
                {
                     Name = "○○病院",
                     Description = "○○病院皮膚科受付用サイト",
                     CreatedDate = DateTime.Parse("2015-05-02"),
                     UncompletedCount = 5,
                     CompletedDate = null   
                },
                new Site
                {
                     Name = "△△病院",
                     Description = "△△病院耳鼻科受付用サイト",
                     CreatedDate = DateTime.Parse("2015-05-01"),
                     UncompletedCount = 2,
                     CompletedDate = null   
                },
                new Site
                {
                     Name = "あいうえお歯科",
                     Description = "受付用サイト",
                     CreatedDate = DateTime.Parse("2015-04-30"),
                     UncompletedCount = 0,
                     CompletedDate = DateTime.Parse("2015-05-01")
                }
            };

         sites.ForEach(_ => context.Sites.Add(_));
            context.SaveChanges();
        }
    }
}