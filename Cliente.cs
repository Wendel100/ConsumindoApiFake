﻿using ConsumindoApiFake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiFake
{
    internal class Cliente
    {
        public partial class Company
        {
            public string Name { get; set; }
            public string CatchPhrase { get; set; }
            public string Bs { get; set; }
        }
        public partial class Address
        {
            public string Street { get; set; }
            public string Suite { get; set; }
            public string City { get; set; }
            public string Zipcode { get; set; }
            public Geo Geo { get; set; }
        }
        public partial class Geo
        {
            public string Lat { get; set; }
            public string Lng { get; set; }
        }
        public partial class Welcome
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public Address Address { get; set; }
            public string Phone { get; set; }
            public string Website { get; set; }
            public Company Company { get; set; }
        }
    }
}
