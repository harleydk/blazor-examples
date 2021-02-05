// European Union Public License version 1.2
// Copyright © 2020 Rick Beerendonk

using System.ComponentModel.DataAnnotations;

namespace Forms_Basics
{
  public class DemoModel
  {
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string Name { get; set; }
  }
}