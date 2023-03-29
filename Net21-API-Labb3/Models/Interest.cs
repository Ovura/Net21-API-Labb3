namespace Net21_API_Labb3.Models
{
    public class Interest
    {
        public int InterestId { get; set; }

        public string Interest_Name { get; set; }

        public string Description { get; set;}

        //Relationship
       public List<Website> Websites { get; set; }
    }
}
