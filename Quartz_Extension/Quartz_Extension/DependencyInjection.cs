
using Quartz;
using Quartz_Extension.Services.ScheduleServices;

namespace Quartz_Extension
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services) 
        {
            services.AddQuartz(options => 
            {
                options.UseMicrosoftDependencyInjectionJobFactory();
            });

            services.AddQuartzHostedService(options => 
            {
                options.WaitForJobsToComplete = true;
            });

            services.ConfigureOptions<ScheduleSetupService>();
        }
    }
}
