using System;
using System.Collections.Generic;
using System.Text;

namespace standardProject.Data.Entities
{
  public class Product
  {
    public int Id { get;set;}
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal OriginalPrice { get; set; }
    public string Detail { get; set; }
    public int Stock { get; set; }
    public int ViewCount { get;set;}
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get;set;}
    public string SEODescription { get; set; }
    public string SEOTitle { get; set; }
    public string SEOAlias { get;set;}

  }
}
