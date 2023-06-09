﻿
using Infrastructure.Base;

namespace Core.Entities
{
    public class Withdrawal : BaseEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string ToAddress { get; set; }
        public bool WasApprovedByUser2FA { get; set; }
        public int OperationId { get; set; }

        public virtual Operation Operation { get; set; }
    }
}
