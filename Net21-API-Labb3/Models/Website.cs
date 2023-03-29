namespace Net21_API_Labb3.Models
{
    public class Website
    {
        public string WebsiteAddress { get; set; }

        //Realtionship
        public int UserId { get; set; }
        public User User { get; set; }

        public int InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}


