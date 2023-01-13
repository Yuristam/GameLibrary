namespace GameLibrary.DAL.Domain.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set;}
        public List<Game> Game { get; set;}
    }
}
