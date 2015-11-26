using System;

namespace LGG.MyCase.SharedKernel.DomainNotificationHelper.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTime Date { get; }
    }
}