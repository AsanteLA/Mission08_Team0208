﻿using System;
using System.Collections.Generic;

namespace Mission08_Team0208.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public string Task1 { get; set; } = null!;

    public string? DueDate { get; set; }

    public string Quadrant { get; set; } = null!;

    public string? Catergory { get; set; }

    public int? Completed { get; set; }
}
