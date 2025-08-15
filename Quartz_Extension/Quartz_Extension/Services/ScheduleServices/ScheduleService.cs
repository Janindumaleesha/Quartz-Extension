using Quartz;

namespace Quartz_Extension.Services.ScheduleServices
{
    [DisallowConcurrentExecution]
    public class ScheduleService : IJob
    {
        private readonly ILogger<ScheduleService> _logger;

        public ScheduleService(ILogger<ScheduleService> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("{UTCDate}", DateTime.UtcNow);

            Console.WriteLine("DateTime Now: ", DateTime.UtcNow);

            return Task.CompletedTask;
        }
    }
}
