﻿using System;
using System.Collections.Generic;
using System.Text;
using MusteriYonetimSistemi.Entities;

namespace MusteriYonetimSistemi
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }
    }

}
