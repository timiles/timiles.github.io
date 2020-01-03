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
