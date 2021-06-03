using standardProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace standardProject.Data.Entities
{
  public class Category
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int SortOrder { get; set; }
    public bool IsShowOnHome { get; set; }
    public int? ParentId { get; set; }
    public CategoryStatus Status { get; set; }
    public int SEODescription { get; set; }
    public int SEOTitle { get; set; }

  }
}
