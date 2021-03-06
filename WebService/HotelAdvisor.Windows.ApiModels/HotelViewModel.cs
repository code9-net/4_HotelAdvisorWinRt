﻿using System.Collections.Generic;

namespace HotelAdvisor.Windows.ApiModels
{
    public class HotelViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public int HouseNumber { get; set; }

        public string City { get; set; }

        public byte[] Image { get; set; }

        public string ImagePath { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
