using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.BusinessLayer.Abstract;
using UpSchool.BusinessLayer.Concrete;
using UpSchool.DataAccessLayer.Abstract;
using UpSchool.DataAccessLayer.EntityFramework;

namespace UpSchool.BusinessLayer.DIContainer
{
    public static class Extensions
    {
        public static void Containerdependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EFCategoryDal>();
            services.AddScoped<IEmployeeService, EmployeeManagercs>();
            services.AddScoped<IEmployeeDal, EFEmployeeDal>();
            services.AddScoped<IEmployeeTaskService, EmployeeTaskManagercs>();
            services.AddScoped<IEmployeeTaskDal, EFEmployeeTaskDal>();

            services.AddScoped<IEmployeeTaskDetailService, EmployeeTaskDetailManager>();
            services.AddScoped<IEmployeeTaskDetailDal, EFEmployeeTaskDetailDal>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EFMessageDal>();
            services.AddScoped<IAnnouncementDal, EFAnnouncementDal>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();

        }
    }
}
