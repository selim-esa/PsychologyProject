using PsychologyProject.Business.Abstract;
using PsychologyProject.DataAccess.Abstract;
using PsychologyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.Business.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider t)
        {
            _sliderDal.Add(t);
        }

        public Slider TGetById(int id)
        {
           return _sliderDal.GetById(id);
        }

        public List<Slider> TGetList()
        {
            return _sliderDal.GetAll();
        }

        public void TRemove(Slider t)
        {
            _sliderDal.Delete(t);
        }

        public void TUpdate(Slider t)
        {
            _sliderDal.Update(t);
        }
    }
}
