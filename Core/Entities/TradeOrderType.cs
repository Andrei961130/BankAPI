﻿
using Infrastructure.Base;

namespace Core.Entities
{
    public class TradeOrderType : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TradeOrder> TradeOrders { get; set; }
    }
}
