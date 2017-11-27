using FollowBudget.model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowBudget.Test.model
{
    [TestFixture]
    public class EFCodeFirst
    {
        [Test]
        public void CreateDataBaseFromContext()
        {
            try
            {
                using (FollowBudgetContext context = new FollowBudgetContext())
                {
                    //Income income = new Income() { Amount = 14500, CreationDate = DateTime.Now };
                    //context.Incomes.Add(income);
                    //context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
