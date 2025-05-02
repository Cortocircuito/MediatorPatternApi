using MediatorPatternApi.Domain;
using MediatR;

namespace MediatorPatternApi.Services
{
    public class NotifierMediatorService(IMediator mediator) : INotifierMediatorService
    {
        public void Notify(string notifyText)
        {
            mediator.Publish(new NotificationMessage { NotifyText = notifyText });
        }
    }
}
