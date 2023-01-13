using System.ComponentModel.DataAnnotations;

namespace GameLibrary.DAL.Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateFounded { get; set; }
        public virtual List<Game> Game { get; set; }
        public virtual List<CompanyWorker> CompanyWorker { get; set; }
    }
}
