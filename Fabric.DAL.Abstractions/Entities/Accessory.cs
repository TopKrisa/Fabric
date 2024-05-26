namespace Fabric.DAL.Abstractions.Model;

public class Accessory : BaseEntity
{
    public string Name { get; set; }
    
    public string Type { get; set; }
    
    public string Width { get; set; }
    
    public string Heigt { get; set; }
    
    public string ImagePath { get; set; }
    
    public string Cost { get; set; }
}