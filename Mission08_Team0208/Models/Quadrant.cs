using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0208.Models;

public partial class Quadrant
{
    [Key]
    public int QuadrantId { get; set; }

    public string QuadrantName { get; set; } = null!;
}
