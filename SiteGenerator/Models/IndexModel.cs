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
        public string CompanyNumber { get; set; }
        public string Tagline { get; set; }
        public string ProfileImageSrc { get; set; }

        public DateTime CareerStartDate { get; set; }
        public int TotalYearsExperience => (int)Math.Floor((DateTime.Today - this.CareerStartDate).TotalDays / 365.25);

        // Get in touch info
        public string EmailAddress { get; set; }
        public string TwitterUsername { get; set; }
        public string GitHubUsername { get; set; }
        public string LinkedInUrl { get; set; }

        public string Intro { get; set; }
        public string[] HowCanIHelpYou { get; set; }

        // Tools
        public ToolModel[] FrontEndTechnologies { get; set; }
        public ToolModel[] BackEndTechnologies { get; set; }
        public ToolModel[] Architectures { get; set; }
        public ToolModel[] DevelopmentPractices { get; set; }
    }
}
