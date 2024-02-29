using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0208.Models;

public partial class Task
{
    public int TaskId { get; set; }
    [Required]
    public string TaskName { get; set; } = null!;

    public string? DueDate { get; set; }
    [Required]
    public string Quadrant { get; set; } = null!;

    public string? Catergory { get; set; }

    public int? Completed { get; set; }
}