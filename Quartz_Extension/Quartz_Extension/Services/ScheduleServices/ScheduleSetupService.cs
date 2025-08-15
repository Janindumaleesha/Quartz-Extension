using Microsoft.Extensions.Options;
using Quartz;

namespace Quartz_Extension.Services.ScheduleServices
{
    public class ScheduleSetupService : IConfigureOptions<QuartzOptions>
    {
        public void Configure(QuartzOptions options)
        {
            var jobKey = new JobKey("SchedulerService");

            options.AddJob<ScheduleService>(opts => opts.WithIdentity(jobKey));

            options.AddTrigger(opts => opts
                .ForJob(jobKey)
                .WithIdentity("SchedulerService-trigger")
                .WithCronSchedule("0 * * * * ?"));
        }
    }
}
