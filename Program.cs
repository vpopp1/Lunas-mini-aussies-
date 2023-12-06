using Puppy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorPagesPuppyDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesPuppyDbContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesPuppyDbContext' not found.")));

builder.Services.AddDbContext<PuppyDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PuppyContext"))); 
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
