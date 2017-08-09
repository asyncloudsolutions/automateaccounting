using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataProviders
{
    public abstract class ProviderHelper
    {
        public void UpsertEntity<Tentity>(int? identityValue, ref Tentity entityObject, AsyncAutomateAccountingEntities dbContext) where Tentity : class
        {
            if (identityValue.HasValue) { dbContext.Entry(entityObject).State = System.Data.Entity.EntityState.Modified; }
            else { dbContext.Set<Tentity>().Add(entityObject); }
            dbContext.SaveChanges();
        }

        public void AssignStatusData(dynamic responseObject, bool status, string statusMessage)
        {
            responseObject.Status = status;
            responseObject.StatusMessage = statusMessage;
        }
    }
}
