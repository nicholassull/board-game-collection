namespace BoardGameCollection.Models
{
  public class BoardGame
  {
    public int BoardGameId { get; set;}
    public string Name { get; set;}
    public int MaxPlayers { get; set;}
    public int Cooperative { get; set;}
  }
}