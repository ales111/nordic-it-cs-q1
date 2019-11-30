using System;
namespace Lesson9_2
{
    interface IReminderItem
    {
        DateTimeOffset AlarmDate { get; set; }
        string AlarmMessage { get; set; }
        TimeSpan TimeToAlarm { get; }
        bool IsOutdated
        {
            get;
        }
        void WriteProperties();

        class ReminderItem : IReminderItem
        {
            private DateTimeOffset alarmDate;
            private string alarmMessage;
            public DateTimeOffset AlarmDate { get; set; }
            public string AlarmMessage { get; set; }
            public TimeSpan TimeToAlarm
            {
                get { return DateTime.Now - AlarmDate; }
            }

            public bool IsOutdated
            {
                get
                {
                    if (TimeToAlarm.TotalSeconds >= 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            public ReminderItem()
            {
                this.AlarmDate = alarmDate;
                this.AlarmMessage = alarmMessage;
            }
            public void WriteProperties()
            {
                Console.WriteLine(
                $"AlarmDate: {AlarmDate},\n" +
                $"AlarmMessage: {AlarmMessage},\n" +
                $"TimeToAlarm: {TimeToAlarm},\n" +
                $"IsOutdated: {IsOutdated}\n");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var alarm1 = new ReminderItem()
                {
                    AlarmDate = DateTimeOffset.Parse("2019-11-31 12:3:3"),
                    AlarmMessage = "Wake up!"
                };
                alarm1.WriteProperties();

                var alarm2 = new ReminderItem()
                {
                    AlarmDate = DateTimeOffset.Parse("2019-12-01 23:15:10"),
                    AlarmMessage = "Wake up!"
                };
                alarm2.WriteProperties();
                Console.ReadKey();
            }
        }
    }
}