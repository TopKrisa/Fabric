using Microsoft.VisualBasic;

namespace Fabric.DAL.Abstractions.Model;

public class Product : BaseEntity
{
    
    public string Name { get; set; }
    
    public string Width { get; set; }
    
    public string Heigt { get; set; }
    
    public string ImagePath { get; set; }
    
    public string Comment { get; set; }
}