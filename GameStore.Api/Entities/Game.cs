namespace GameStore.Api.Entities;

public class Game
{
     public int Id { get; set; }   
     public required string Name { get; set; } 
     public required string Genre { get; set; }
     public decimal Price { get; set; }
     public DateTime ReleaseDate { get; set; }
     public required String ImageUri { get; set; }
}
