using PsychologyProject.Entities.Concrete;

namespace PsychologyProject.Web.ViewModel
{
    public class HomeViewModel
    {
        public Home Home { get; set; }
        public List<Brief> Brief { get; set; }
        public List<Slider> Sliders {get; set; } 
        public Slider SliderSecond {get; set; } 
    }
}
