using Radzen;

namespace Parcial2_Jose_angel.Extenciones
{
    public static class Notificationes
    {
       public static void ShowNotification(this NotificationService notifier, string mensaje, NotificationSeverity severity = NotificationSeverity.Success)
        {
            var message = new NotificationMessage
            {
                Severity = severity,
                Summary = mensaje
            };

            notifier.Notify(message);
        }

    }
}