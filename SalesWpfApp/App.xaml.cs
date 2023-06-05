using AutoMapper;
using BusinessObject.IService;
using BusinessObject.Mapper;
using BusinessObject.Service;
using Data_Layer.IRepository;
using Data_Layer.Repository;
using Microsoft.Extensions.DependencyInjection;
using SalesWpfApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SalesWpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;
        public ServiceProvider ServiceProvider { get { return _serviceProvider; } }

        public static int userId { get; set; } = 1;
        public App()
        {
            var services = new ServiceCollection();
            ConfigurationServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigurationServices(ServiceCollection services)
        {
            // Register AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile)); //register with IoC & singleton service

            // Register other services (Interface..) here
            services.AddSingleton<IMemberRepository, MemberRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IOrderRepository, OrderRepository>();
            services.AddSingleton<IMemberService, MemberService>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IOrderService, OrderService>();

            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<ProductViewModel>();
            services.AddSingleton<OrderViewModel>();
            services.AddSingleton<MemberViewModel>();
            services.AddSingleton<MenuViewModel>();
        }
    }
}
