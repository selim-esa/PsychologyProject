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
        [HttpPost]
        public IActionResult Update(Slider slider)
        {
            if (slider == null)
            {
                // Eğer gelen veriler hatalı ise veya null ise uygun bir şekilde işlem yapabilirsiniz.
                return BadRequest("Güncelleme için gerekli veriler eksik veya hatalı.");
            }

            var hasSlider = _context.sliders.FirstOrDefault(slider => slider.Id == slider.Id);

            if (hasSlider == null)
            {
                throw new Exception($"Bu id sahip ürün bulunmamakta");
            }

            // Güncelleme işlemleri
          hasSlider.Title=slider.Title;
            hasSlider.Text=slider.Text;
            hasSlider.ImageUrl=slider.ImageUrl;
            

            _context.Update(hasSlider);
            _context.SaveChanges();

            // Güncelleme işlemi tamamlandıktan sonra belirli bir sayfaya yönlendirme yapabilirsiniz.
            return RedirectToAction("Index");
        }
    }
}
