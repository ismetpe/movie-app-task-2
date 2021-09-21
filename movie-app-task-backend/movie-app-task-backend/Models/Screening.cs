using System.Collections.Generic;

namespace movie_app_task_backend.Models
{
    public class Screening
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string Place { get; set; }

        public int Number_of_seats { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

        public int Number_of_tickets { get; set; }

        public int MediaId { get; set; }

    }
}