using System.ComponentModel.DataAnnotations;

namespace GameLibrary.DAL.Domain.Entities
{
    public class CompanyWorker
    {
        public int CompanyWorkerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public int WorkExpirence { get; set; }
        public Company Company { get; set; }

    }
}
