﻿using ShipmentTracking.Entities.Interfaces;

namespace ShipmentTracking.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TextField 
        { 
            get { return Name; } 
            set { Name = value; } 
        }
    }
}