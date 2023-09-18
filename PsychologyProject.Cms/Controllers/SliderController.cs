using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PsychologyProject.Business.Abstract;
using PsychologyProject.Entities.Enums;
using PsychologyProject.Cms.Models;
using PsychologyProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using PsychologyProject.DataAccess.Concrete;
using GenericFileService.Files;

namespace PsychologyProject.Cms.Controllers
{

    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly DataContext _context;

        public SliderController(DataContext context, ISliderService sliderService)
        {
            _context = context;
            _sliderService = sliderService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SliderViewModel slider)
        {
            if(slider.Image.Length > 0)
            {          
                string fileName = FileService.FileSaveToServer(slider.Image, "wwwroot/resimler");
                var path = Path.Combine("wwwroot/resimler", fileName);
                slider.ImageUrl = path;

                Slider newSlider = new Slider
                {
                    Title = slider.Title,
                    Text = slider.Text,
                    ImageUrl = slider.ImageUrl,
                    Type = slider.Type
                };
                _context.sliders.Add(newSlider);
                await _context.SaveChangesAsync();


            }
            //Slider entity = new()
            //{
            //    SliderImageUrl = slider.SliderImageUrl

            //};

            //_sliderService.TAdd(entity);
            return View();
        }

        [HttpDelete]
        public IActionResult Delete(Slider slider)
        {
            _sliderService.TRemove(slider);
            return View(slider);
        }
        [HttpPut]
        public IActionResult Update(Slider slider)
        {
            _sliderService.TUpdate(slider);
            return View(slider);
        }
    }
}
