using System;

namespace SiteGenerator.Models
{
    public class IndexModel
    {
        public string Domain { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string CompanyName { get; set; }
        public string Tagline { get; set; }
        public string Blurb { get; set; }
        public DateTime? DateNextAvailableForWork { get; set; }
        public string ProfileImageSrc { get; set; }
        public int ProfileImageWidth { get; set; }
        public int ProfileImageHeight { get; set; }
        public string CurrentStatus { get; set; }

        public MapModel Map { get; set; }

        // extra info
        public long? StackOverflowUserId { get; set; }
        public string StackOverflowUsername { get; set; }
        public string TwitterUsername { get; set; }
        public long? TwitterWidgetId { get; set; }
        public string GitHubUsername { get; set; }
        public string LinkedInUrl { get; set; }

        public int TotalYearsExperience
        {
            get
            {
                var earliestDate = new DateTime(2004, 10, 1);
                return (int)Math.Floor((DateTime.Today - earliestDate).TotalDays / 365.25);
            }
        }
    }
}
