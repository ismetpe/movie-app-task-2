using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Models
{
    public class PurchasedTicket
    {
        public int Id { get; set; }

        public float Price { get; set; }

        public int ScreeningId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

       
    }
}
