using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HomeCinema.Entities;

namespace HomeCinema.Data.Configurations
{
    public class EntityBaseConfiguration<T> : EntityBaseConfiguration<T> where T : class, IEntityBase
    {
        public EntityBaseConfiguration()
        {
            HasKey(e => e.ID);
        }
    }
}
