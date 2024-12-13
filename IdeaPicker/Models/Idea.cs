using SQLite;
namespace IdeaPicker.Models;

public class Idea
{
    [PrimaryKey, AutoIncrement]
    public int IdeaID { get; set; }
    
    public string FName { get; set; } 
    
    public string IdeaName { get; set; }
}