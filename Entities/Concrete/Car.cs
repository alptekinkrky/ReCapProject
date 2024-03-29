﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntitiy
    {
        public int Id { get; set; }
        public string CarName { get; set; }

        public int BrandId { get; set; }

        public short ColorId { get; set; }
        public short ModelYear { get; set; }

        public decimal DailyPrice { get; set; }

        public string Description { get; set; }
    }
}
