using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mission08_Team0208.Models;

public partial class TaskInfo
{
    [Key]
    public int TaskId { get; set; }

    [Required(ErrorMessage = "You must enter a task name.")]
    public string TaskName { get; set; }

    public string? DueDate { get; set; }

    [ForeignKey("QuadrantId")]
    [Required(ErrorMessage = "You must select a quadrant.")]
    public int? QuadrantId { get; set; }
    public Quadrant? Quadrant { get; set; }

    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    public bool? Completed { get; set; }
}
