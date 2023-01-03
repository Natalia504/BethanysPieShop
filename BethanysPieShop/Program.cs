using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); // looks at appsetting.json and loads those settings. These are defaults! Don't change!

//register our own services:
// addSingleton() - a single instance created when the request comes in
// addScoped()
// addTransient()
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); //a
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddControllersWithViews(); // Enable MVC in this app. We started with Empty app template
// registed DB Context:
builder.Services.AddDbContext<BethanysPieShopDbContext>(options => {
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BethanysPieShopLocalDbContextConnection"]); // this comes from AppSettings
});

var app = builder.Build();

//add middleware components
app.UseStaticFiles();

DbInitializer.Seed(app);
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // dev exception page, only for dev env
};

app.MapDefaultControllerRoute(); // to see the pages/views

app.Run();

