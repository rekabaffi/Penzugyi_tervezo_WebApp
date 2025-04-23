namespace Penzugyi_tervezo_WebApp.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; } // you may exclude this for security
        public DateTime created_at { get; set; }
    }
}