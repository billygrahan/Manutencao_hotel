using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheHotelApp.Models;

namespace TheHotelApp.Models
{
    public enum NivelConservacao
    {
        Baixo,
        Medio,
        Alto
    }
    public class Room
    {
        public string ID { get; set; }
        [Required]
        public int? Number { get; set; }

        public string RoomTypeID { get; set; }
        public virtual RoomType RoomType { get; set; }
        [Required]
        public decimal? Price { get; set; }

        [Required]
        public bool Available { get; set; }

        [Required]
        public bool StatusLimpeza { get; set; } // True = Limpo, False = Sujo (por exemplo)

        [Required]
        public NivelConservacao Conservacao { get; set; } // Salva como INT no banco (0, 1, 2)
        
        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        public int? MaximumGuests { get; set; }
        public virtual ICollection<RoomFeature> Features { get; set; }
        public virtual ICollection<Image> RoomImages { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

    }
}