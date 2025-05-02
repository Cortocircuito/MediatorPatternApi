using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MediatorPatternApi.Domain;
using MediatR;

namespace MediatorPatternApi.Handlers
{
    public class Notifier2 : INotificationHandler<NotificationMessage>
    {
        public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Debugging from Notifier 2. Message : {notification.NotifyText}");
            return Task.CompletedTask;
        }
    }
}
