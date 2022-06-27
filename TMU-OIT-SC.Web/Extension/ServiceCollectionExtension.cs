using AutoMapper;
using TMU_OIT_SC.Model.DB;
using TMU_OIT_SC.Model.Map;
using TMU_OIT_SC.Service.Interface;
using TMU_OIT_SC.Service.Services;

namespace TMU_OIT_SC.Web.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddAutoMapper(this IServiceCollection serviceCollection)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);
        }

        /// <summary>
        /// DI
        /// </summary>
        /// <param name="serviceCollection"></param>
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDBFactory, DBFactory>();
            serviceCollection.AddTransient<ISCInfoService, SCInfoService>();
            serviceCollection.AddTransient<IBorrowService, BorrowService>();
            serviceCollection.AddTransient<IClassService, ClassService>();
            serviceCollection.AddTransient<IEventService, EventService>();
            serviceCollection.AddTransient<ICardService, CardService>();
            serviceCollection.AddTransient<IRefConfigService, RefConfigService>();
            serviceCollection.AddTransient<IAttendanceService, AttendanceService>();
            serviceCollection.AddTransient<ITimeSectionService, TimeSectionService>();
            serviceCollection.AddTransient<IShuttleBusService, ShuttleBusService>();
        }
    }
}
