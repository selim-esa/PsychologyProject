namespace PsychologyProject.Cms.Models
{
    public class SliderViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
    }
}
