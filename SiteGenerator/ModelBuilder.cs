using SiteGenerator.Models;

namespace SiteGenerator
{
    class ModelBuilder
    {
        public static IndexModel GetIndexModel()
        {
            var model = new IndexModel
            {
                Domain = "https://timiles.github.io",
                CompanyName = "Tim Iles",
                FirstName = "Tim",
                LastName = "Iles",
                Tagline = "Software engineer and full stack web developer, specialising in .NET and associated technologies.",
                //ProfileImageSrc = "/img/profile.jpg",
                //ProfileImageWidth = 350,
                //ProfileImageHeight = 350,
                //DateNextAvailableForWork = new DateTime(2017, 1, 1),

                LinkedInUrl = "https://uk.linkedin.com/in/timiles",
                //StackOverflowUserId = 487544,
                //StackOverflowUsername = "tim-iles",
                TwitterUsername = "tim_iles",
                TwitterWidgetId = 599922965321490432,
                GitHubUsername = "timiles",
            };

            model.Blurb = $"<p>Over {model.TotalYearsExperience} years’ commercial experience in <span class='skill'>C#</span>, <span class='skill'>ASP.NET</span>, <span class='skill'>JavaScript</span>, <span class='skill'>SQL Server</span> and more.</p>" +
                       "<p>Passionate about domain-driven design, CI/CD automation, and using the right tool for the job.  Particular experience turning legacy monolith codebases into scalable, testable, manageable code.</p>"
                ;

            return model;
        }
    }
}