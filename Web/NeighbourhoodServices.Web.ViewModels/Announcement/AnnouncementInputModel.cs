﻿using NeighbourhoodServices.Services.Mapping;

namespace NeighbourhoodServices.Web.ViewModels.Announcement
{
    using NeighbourhoodServices.Data.Models;

    public class AnnouncementInputModel : IMapFrom<Service>
    {
        public string Description { get; set; }

        public int Price { get; set; }

        public string PriceFor { get; set; }

        public string Address { get; set; }

        public string Category{ get; set; }

        public ServiceType ServiceType { get; set; }
       
        public string UserId { get; set; }
    }
}