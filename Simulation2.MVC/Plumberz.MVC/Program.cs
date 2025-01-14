using Microsoft.EntityFrameworkCore;
using Plumberz.DAL.Contexts;
using Plumberz.DAL.Configurations.Repository;
using Plumberz.BL.Configurations;
using FluentValidation;
using Plumberz.BL.Validations;
using FluentValidation.AspNetCore;
using Plumberz.BL.Profiles;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(TechnicianProfile));
builder.Services.AddControllersWithViews();
builder.Services.AddValidatorsFromAssembly(typeof(TechnicianValidation).Assembly);
builder.Services.AddServiceConfig();
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
builder.Services.AddRepoConfig();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MsSQL"));
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

app.UseAuthorization();
app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
