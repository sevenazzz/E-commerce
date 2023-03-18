namespace E_commerce.Entities
{
    public class Clients
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set;}
        public string Address { get; set;}
        public string Email { get; set;}
        public List<Orders> Orders { get; set; }
    }
}
