using System.ComponentModel.DataAnnotations;

namespace Net21_API_Labb3.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        
        //Relationship
        public List<Interest> Interests { get; set; }
        public List<Website> Websites { get; set; } 


    }
}
