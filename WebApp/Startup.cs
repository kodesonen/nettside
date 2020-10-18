using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DatabaseHandler.Dataset;
using WebApp.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WebApp {

	public class Startup {

		public Startup(IConfiguration configuration) {
			Configuration = configuration;
			//DbConfig = new ConfigurationBuilder().AddJsonFile("connection.json").SetBasePath(Directory.GetCurrentDirectory()).Build();
		}

		public IConfiguration Configuration { get; }
		//public IConfiguration DbConfig { get; }

		public void ConfigureServices(IServiceCollection services) {
			services.AddDbContextPool<DataContext>(
				options => options.UseMySql("server=dev.kodesonen.no;port=3306;database=kodesonen;user=root;password=Kodesonen!0"));

			services.AddRouting(options => options.LowercaseUrls = true);
			services.AddControllersWithViews();

			//services.AddIdentity<KodesonenUser, IdentityRole>(options => {
			//	options.SignIn.RequireConfirmedEmail = false;

			//	options.Password.RequireNonAlphanumeric = false;
			//	//options.User.RequireUniqueEmail = true;
			//	//options.Lockout.AllowedForNewUsers = true;
			//	//options.Lockout.MaxFailedAccessAttempts = 5;
			//	//options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
			//}).AddEntityFrameworkStores<DataContext>();/*.AddDefaultTokenProviders();*/

			services.ConfigureApplicationCookie(options => {
				options.LoginPath = "/login";
				options.ReturnUrlParameter = "";
				options.AccessDeniedPath = "/Error/404";
			});

			services.AddIdentity<KodesonenUser, IdentityRole>().AddEntityFrameworkStores<DataContext>();
			//services.Configure<DataProtectionTokenProviderOptions>(options => {
			//    options.TokenLifespan = TimeSpan.FromMinutes(30);
			//});

			//services.Configure<EmailConfirmationTokenProviderOptions>(options => {
			//    options.TokenLifespan = TimeSpan.FromDays(30);
			//});
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			} else {
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			//app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints => {
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");

				endpoints.MapControllerRoute(
					name: "login",
					pattern: "login",
					defaults: new { controller = "User", action = "Login" });
			});
		}
	}
}