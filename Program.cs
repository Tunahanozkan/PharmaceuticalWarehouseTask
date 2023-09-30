using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Context;
using DataAccesLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PharmacyContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<PharmacyContext>();

builder.Services.AddScoped<IMedicineService, MedicineManager>();
builder.Services.AddScoped<IMedicineDal, EfMedicineDal>();

builder.Services.AddScoped<IStockService, StockManager>();
builder.Services.AddScoped<IStockDal,EfStockDal>();

builder.Services.AddScoped<IOrderService, OrderManager>();
builder.Services.AddScoped<IOrderDal,EfOrderDal>();

//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//        .RequireAuthenticatedUser()
//        .Build();
//    config.Filters.Add(new AuthorizeFilter(policy));
//});   // Yetkilendirme Eriþim Onayý

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
