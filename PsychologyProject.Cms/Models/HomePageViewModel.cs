using PsychologyProject.Entities.Concrete;

namespace PsychologyProject.Cms.Models
{
    public class HomePageViewModel
    {
        public Home Home { get; set; }
        public List<Brief> Brief { get; set; }
        public Slider Slider { get; set; }
        public Slider SliderSecond { get; set; }
    }
}
