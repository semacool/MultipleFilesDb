using ConsoleApp1.Database;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ConsoleApp1
{
    public class TestLogic
    {
        private Timer _timer;

        public ILoggerFactory AppLoggerFactory { get; private set; }

        private ILogger<TestLogic> _logger;

        public void Start()
        {
            _timer = new Timer();
            _timer.Elapsed += _timer_Elapsed;
            _timer.AutoReset = true;
            _timer.Interval = 100;
            _timer.Start();

            AppLoggerFactory = LoggerFactory.Create(builder =>
            {
                LoggerConfiguration loggerConfiguration = new LoggerConfiguration()
                .ReadFrom.AppSettings("general")
                .ReadFrom.AppSettings("sqlite");

                builder.AddSerilog(loggerConfiguration.CreateLogger());
            });
            _logger = AppLoggerFactory.CreateLogger<TestLogic>();
        }

        private void _timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            SendData();
        }

        public void SendData()
        {
            string longText = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,";
            using (var db = new TestDbContext()) 
            {
                var data = new Data();
                data.Data1 = longText;
                data.Data2 = longText;
                data.Data3 = longText;
                data.Data4 = longText;
                data.Data5 = longText;
                data.Data6 = longText;
                data.Data7 = longText;
                data.Data8 = longText;
                data.Data9 = longText;
                data.Data10 = longText;
                db.Datas.Add(data);
                db.SaveChanges();

                _logger.LogDebug("{@Data}", data);
            }
        }
    }
}
