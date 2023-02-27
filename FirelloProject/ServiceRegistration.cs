using FirelloProject.DAL;
using Microsoft.EntityFrameworkCore;

namespace FirelloProject
{
    public static class ServiceRegistration
    {
        public static void FirelloServiceRegistration(this IServiceCollection services)
        {
            services.AddControllersWithViews();

        } 
    }
}

