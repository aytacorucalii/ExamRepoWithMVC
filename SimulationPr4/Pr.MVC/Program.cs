using Microsoft.EntityFrameworkCore;
using Pr.DAL.Contexts;
using Pr.DAL.Configurations;
using Pr.BL.Configurations.ServiceConfig;
using Pr.BL.Profiles;
using FluentValidation.AspNetCore;
using FluentValidation;
using Pr.BL.Validations.Doctors;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRepoConfig();
builder.Services.AddConfig();
builder.Services.AddAutoMapper(typeof(DoctorProfile));
builder.Services.AddValidatorsFromAssembly(typeof(DoctorValidation).Assembly);
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"));
});
// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
