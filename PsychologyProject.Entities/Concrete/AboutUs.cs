using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.Entities.Concrete;

public class AboutUs
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string SubTitle { get; set; }
    public string SubDescription { get; set; }
    public int HappyClient  { get; set; }
    public int YearInBusiness { get; set; }
    public int HighScore { get; set; }
    public int CupsOfCoffee { get; set; }
    public string WeAreTitle { get; set; }
    public string WeArePreDescription { get; set; }
    public string WeAreDescription { get; set;}
    public string OurTeamTitle { get; set; }
    public string OurTeamPreDescription { get; set; }
    public string OurTeamDescription { get;set; }

}
