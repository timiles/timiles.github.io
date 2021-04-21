using SiteGenerator.Models;
using System;

namespace SiteGenerator
{
    class ModelBuilder
    {
        public static IndexModel GetIndexModel()
        {
            var model = new IndexModel
            {
                Domain = "https://timiles.github.io",
                CompanyName = "Telamon Software Ltd",
                CompanyNumber = "07522796",
                FirstName = "Tim",
                LastName = "Iles",
                CareerStartDate = new DateTime(2004, 10, 1),
                Tagline = "Web and app developer based in Berkshire, UK.",
                Intro = "Hi! I'm Tim and I love writing software.",
                ProfileImageSrc = "/img/profile.jpg",

                EmailAddress = "dev@timiles.com",
                LinkedInUrl = "https://uk.linkedin.com/in/timiles",
                GitHubUsername = "timiles",

                FrontEndTechnologies = new[]
                {
                    new ToolModel("React / React Native", "/img/logos/react-2.svg"),
                    new ToolModel("Redux", "/img/logos/redux.svg"),
                    new ToolModel("Apollo GraphQL", "/img/logos/apollo-graphql-compact.svg"),
                },
                BackEndTechnologies = new[]
                {
                    new ToolModel("C#, .NET Core, ASP.NET, WebAPI, MVC", "/img/logos/csharp-icon.svg"),
                    new ToolModel("RESTful API design", "/img/logos/rest.png"),
                    new ToolModel("Microsoft SQL Server, Entity Framework", "/img/logos/sql.png"),
                },
                Architectures = new[]
                {
                    new ToolModel("Microservices architecture", "/img/logos/microservices.png"),
                    new ToolModel("Amazon Web Services (AWS)", "/img/logos/Amazon_Web_Services_Logo.svg"),
                    new ToolModel("Microsoft Azure", "/img/logos/Microsoft_Azure_Logo.svg"),
                },
                DevelopmentPractices = new[]
                {
                    new ToolModel("Continuous integration and delivery", "/img/logos/cicd.png"),
                    new ToolModel("Test-driven development", "/img/logos/tdd.png"),
                    new ToolModel("Scrum, Agile", "/img/logos/scrum.png"),
                },
            };

            model.HowCanIHelpYou = new[] {
                "I specialise in <b>rapid prototyping</b> and building systems from scratch, while also having proven experience with <b>large complex systems</b>, including microservice architectures.",
                "I deliver <b>quality code in fast iterations</b>. An agile approach can improve efficiency of development time, while giving you regular visibility of progress. A thorough suite of automated tests helps to guarantee that the code not only works, but is clear and maintainable, which your team will be confident to extend further as you require.",
                $"I have over {model.TotalYearsExperience} years’ commercial experience, including as <b>team lead</b> and <b>providing mentorship</b> as needed.",
                "I'm a fast learner, and I’m very quick to pick up the specifics of your existing systems, so I can usually start to make <b>valuable contributions from day 1</b> of working with your team.",
            };

            return model;
        }
    }
}