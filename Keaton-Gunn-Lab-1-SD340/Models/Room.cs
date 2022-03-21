using System.ComponentModel.DataAnnotations;

namespace Keaton_Gunn_Lab_1_SD340.Models
{
    public class Room
    {
        [Key]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
        [Display(Name = "Capacity")]
        public int Capacity { get; set; }

    }
    public enum Section
    {
        First,
        Second,
        Third
    }
}
