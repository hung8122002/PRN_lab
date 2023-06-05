﻿using System;
using System.Collections.Generic;

namespace Data_Layer.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int MemberId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? RequireDare { get; set; }

    public DateTime? ShippingDate { get; set; }

    public decimal? Freight { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
