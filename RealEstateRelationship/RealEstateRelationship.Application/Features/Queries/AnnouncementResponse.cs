namespace RealEstateRelationship.Application.Features.Queries
{
    public class AnnouncementResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public LocalisationResponse Localisation { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
    }

    public class LocalisationResponse
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

}
