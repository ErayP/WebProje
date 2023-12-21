﻿using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class Ticket
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public virtual Flight Flight { get; set; }
        public int FlightId { get; set; }
        public virtual User TicketHolder { get; set; }
        [Required]
        public bool TicketType { get; set; }
        public float TicketPrice { get; set; }
    }
}