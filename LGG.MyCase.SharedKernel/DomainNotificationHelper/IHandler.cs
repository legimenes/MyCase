using LGG.MyCase.SharedKernel.DomainNotificationHelper.Events.Contracts;
using System;
using System.Collections.Generic;

namespace LGG.MyCase.SharedKernel.DomainNotificationHelper
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}