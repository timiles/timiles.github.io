namespace SiteGenerator.Models
{
    public class ToolModel
    {
        public ToolModel(string name, string imageSrc)
        {
            this.Name = name;
            this.ImageSrc = imageSrc;
        }

        public string Name { get; set; }
        public string ImageSrc { get; set; }
    }
}
