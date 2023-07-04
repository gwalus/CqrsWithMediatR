using CqrsMediatorExample.Notifications;
using CqrsMediatorExample.Storage;
using MediatR;

namespace CqrsMediatorExample.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;

        public EmailHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccured(notification.Product, "Email sent");
            await Task.CompletedTask;
        }
    }
}
