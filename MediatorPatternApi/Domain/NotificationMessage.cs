using MediatR;

namespace MediatorPatternApi.Domain
{
    public class NotificationMessage : INotification
    {
        public string NotifyText { get; set; }
    }
}
