using CqrsMadiatRExampel.Models;
using MediatR;
using SqrsMadiateRExampel.Notifications;

namespace SqrsMadiateRExampel.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddNotifications>
    {
        private readonly FakeDataStore _fakeDataStore;
        public EmailHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public async Task Handle(ProductAddNotifications notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccured(notification.Product, "Email send");
            await Task.CompletedTask;
        }
    }
}
