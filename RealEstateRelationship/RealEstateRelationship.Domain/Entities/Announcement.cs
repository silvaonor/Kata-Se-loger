﻿namespace RealEstateRelationship.Domain.Entities
{
    public class Announcement
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Localisation Localisation { get; set; }
        public AnouncementTypeEnum Type { get; set; }
    }
}