namespace MyFirstWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }
        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            // Logic to handle startup
            Console.WriteLine("Service Starting...");
            await base.StartAsync(cancellationToken);
        }


        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            // Logic to handle shutdown
            Console.WriteLine("Service Stopping...");
            await base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
