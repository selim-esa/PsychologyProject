using PsychologyProject.DataAccess.Abstract;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.DataAccess.Repositories;
using PsychologyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.DataAccess.EntityFrameWork
{
    public class EfSliderDal : GenericRepository<Slider>, ISliderDal
    {
        public EfSliderDal(DataContext context) : base(context)
        {
        }
    }
}
