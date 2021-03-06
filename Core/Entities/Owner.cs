﻿namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }

        //Relationship between Owner & Address
        public Address Address { get; set; }
    }

}
