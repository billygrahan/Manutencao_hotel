using TheHotelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheHotelApp.ViewModels
{
    public class RoomsAdminIndexViewModel
    {
        public List<Room> Rooms { get; set; }
        public List<RoomType> RoomTypes { get; set; }

        // Filter properties
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public bool? Available { get; set; }
        public string RoomTypeID { get; set; }
    }
}
