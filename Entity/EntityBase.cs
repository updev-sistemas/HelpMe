using System;

namespace Entity
{
    public abstract class EntityBase
    {
        public virtual long? Id { get; set; }
        public virtual DateTime? CreatedAt { get; set; }
        public virtual DateTime? UpdatedAt { get; set; }
        public virtual DateTime? DeletedAt { get; set; }
    }
}
