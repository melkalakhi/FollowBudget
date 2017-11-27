using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowBudget.model
{
    public class FollowBudgetDBInitializer<T> : DropCreateDatabaseIfModelChanges<T> where T : DbContext
    {
        protected override void Seed(T context)
        {
            base.Seed(context);
        }
    }
}
