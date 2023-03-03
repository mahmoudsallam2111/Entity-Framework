using System;
using System.Collections.Generic;

namespace EF_lab.Models;

public partial class Sale
{
    public int? ProductId { get; set; }

    public string? SalesmanName { get; set; }

    public int? Quantity { get; set; }
}
