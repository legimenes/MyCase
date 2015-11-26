using LGG.MyCase.SharedKernel.DomainNotificationHelper.Events;
using System.Collections.Generic;

namespace LGG.MyCase.SharedKernel.DomainNotificationHelper.Handlers
{
    public class DomainNotificationHandler : IHandler<DomainNotification>
    {
        private List<DomainNotification> _notifications;

        public DomainNotificationHandler()
        {
            _notifications = new List<DomainNotification>();
        }

        public void Handle(DomainNotification args)
        {
            _notifications.Add(args);
        }

        public IEnumerable<DomainNotification> Notify()
        {
            return GetValue();
        }

        public bool HasNotifications()
        {
            return GetValue().Count > 0;
        }

        public void Dispose()
        {
            _notifications = new List<DomainNotification>();
        }

        private List<DomainNotification> GetValue()
        {
            return _notifications;
        }
    }
}