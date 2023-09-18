using Microsoft.AspNetCore.Identity;
using PsychologyProject.Business.Abstract;
using PsychologyProject.Business.Concrete;
using PsychologyProject.DataAccess.Abstract;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.DataAccess.EntityFrameWork;
using PsychologyProject.Entities.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<ISliderDal, EfSliderDal>();
builder.Services.AddScoped<ISliderService, SliderManager>();

builder.Services.AddScoped<IHomeDal, EfHomeDal>();
builder.Services.AddScoped<IHomeService, HomeManager>();

builder.Services.AddScoped<IAboutUsDal, EfAboutUsDal>();
builder.Services.AddScoped<IAboutUsService, AboutUsManager>();

builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();


builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<DataContext>();




builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x =>
    {
        x.LoginPath = "/Account/Index";
        x.LoginPath = "/Account/LogOut";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{     
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

}
           

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Index}/{id?}");

app.Run();
