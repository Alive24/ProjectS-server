using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_S_Server.Models
{
    public class Appointment
    {
        public long Id { get; set; }

        [Required]
        public string AppointerName { get; set; }

        [DefaultValue(false)]
        public bool IsComplete { get; set; }
    }
}