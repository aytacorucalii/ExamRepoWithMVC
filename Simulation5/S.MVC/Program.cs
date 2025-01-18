using Microsoft.EntityFrameworkCore;
using S.DAL.Contexts;
using S.DAL.Configrations;
using S.BL.Configurations;
using S.BL.Profiles;
using FluentValidation;
using S.BL.Validations.AtractionValidation;
using FluentValidation.AspNetCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRepoConfig();
builder.Services.AddServiceConfig();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"));
});
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(AtractionProfile));
builder.Services.AddValidatorsFromAssembly(typeof(AtractionValidation).Assembly);
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
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
