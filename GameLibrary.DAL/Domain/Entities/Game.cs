namespace GameLibrary.DAL.Domain.Entities
{
    public class Game
    {
       /* public Game() 
        {
            GameAdded = DateTime.Now;
        }*/
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public string GameDescription { get; set; }
        public List<Genre> Genre { get; set; }
        public virtual Company Company { get; set; }
        public DateTime GameCreated { get; set; }
        //public DateTime GameModified { get; set; }
        //public DateTime GameAdded { get; set; }
    }
}
