
namespace TractorsPrismUnityApp.Models
{
    public class Tractor
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }

        //[JsonConstructor]
        public Tractor(string title, string description, string imageLink)
        {
            Title = title;
            Description = description;
            ImageLink = imageLink;
        }
    }
}
