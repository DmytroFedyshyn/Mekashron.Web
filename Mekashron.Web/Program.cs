using IcuTech;
using Mekashron.Web.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
});
// Add services to the container.
builder.Services.AddRazorPages();



builder.Services.AddScoped<IIcuTechService, IcuTechService>();

builder.Services.AddScoped<IICUTech, ICUTechClient>();

var app = builder.Build();

app.UseResponseCompression();

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
