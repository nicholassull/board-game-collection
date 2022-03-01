namespace BoardGameCollection.Models
{
  public class BoardGame
  {
    public int Id { get; set;}
    public string Name { get; set;}
    public int MaxPlayers { get; set;}
    public int Cooperative { get; set;}
  }
}