using Microsoft.AspNetCore.Mvc;

namespace DSPACardio.Web.Data.Entities
{
    public class Patient : User
    {
        public int Id { get; set; }

        //public User User { get; set; }
    }
}
