using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int OutpostId { get; set; }

    public string ClientFullName { get; set; } = null!;

    public int RecieveCode { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<OrderContent> OrderContents { get; } = new List<OrderContent>();

    public virtual Outpost Outpost { get; set; } = null!;

    public virtual OrderStatus Status { get; set; } = null!;
}
