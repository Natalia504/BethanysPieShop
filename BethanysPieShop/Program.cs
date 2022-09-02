var builder = WebApplication.CreateBuilder(args); // looks at appsetting.json and loads those settings. These are defaults! Don't change!

builder.Services.AddControllersWithViews(); // Enable MVC in this app. We started with Empty app template

var app = builder.Build();

//add middlaware comps
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // dev exception page, only for dev env
};

app.MapDefaultControllerRoute(); // to see the pages/views

app.Run();

