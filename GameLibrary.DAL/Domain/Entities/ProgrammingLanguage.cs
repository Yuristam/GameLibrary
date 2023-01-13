namespace GameLibrary.DAL.Domain.Entities
{
    internal class ProgrammingLanguage
    {
        public int ProgrammingLanguageId { get; set; }
        public string ProgrammingLanguageName { get; set; } 
        public List<Programmer> Programmer { get; set; }
    }
}
