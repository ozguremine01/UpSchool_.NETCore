using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.BusinessLayer.Abstract;
using UpSchool.BusinessLayer.Concrete;
using UpSchool.BusinessLayer.ValidationRules.ContactValidation;
using UpSchool.DataAccessLayer.Abstract;
using UpSchool.DataAccessLayer.EntityFramework;
using UpSchool_.NETCore.DTOLayer.DTOs.ContactDTOs;

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


            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerDal, EFCustomerDal>();


            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EFMessageDal>();
            services.AddScoped<IAnnouncementDal, EFAnnouncementDal>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EFContactDal>();

        }

        public static void CustomizeValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<ContactAddDto>, ContactAddValidator>();
            services.AddTransient<IValidator<ContactUpdateDto>, ContactUpdateValidator>();

        }
    }
}
