using FluentAssertions.Common;
using GerenciamentoProject.Data;
using GerenciamentoProject.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using GerenciamentoProject.Helper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DbPath")));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<IFuncionarioRepositorio,FuncionarioRepositorio>();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IUsuarioRepositorio,UsuarioRepositorio>();
builder.Services.AddScoped<IDescontosRepositorio, DescontosRepositorio>();
builder.Services.AddScoped<ISessao, Sessao>();
builder.Services.AddSession(o =>
{
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;
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
app.UseSession();

app.MapControllerRoute(
    name: "default",
      pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
