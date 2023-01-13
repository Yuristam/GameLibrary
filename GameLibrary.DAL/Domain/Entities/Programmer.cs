namespace GameLibrary.DAL.Domain.Entities
{
    internal class Programmer : CompanyWorker
    {
        public string JobPosition { get; set; }
        public List<ProgrammingLanguage> ProgrammingLanguage { get; set; }
    }
}
