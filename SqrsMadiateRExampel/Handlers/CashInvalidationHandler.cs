using CqrsMadiatRExampel.Models;
using MediatR;
using SqrsMadiateRExampel.Notifications;

namespace SqrsMadiateRExampel.Handlers
{
    public class CashInvalidationHandler : INotificationHandler<ProductAddNotifications>
    {
        private readonly FakeDataStore _fakeDataStore;
        public CashInvalidationHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public async Task Handle(ProductAddNotifications notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccured(notification.Product, "Cache Invalidated");
            await Task.CompletedTask;
        }
    }
}
