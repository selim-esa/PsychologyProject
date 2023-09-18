namespace PsychologyProject.Entities.Concrete;

public class Home
{
    public int HomeId { get; set; }
    public virtual ICollection<Slider> Sliders { get; set; }

}
