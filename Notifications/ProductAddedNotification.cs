using CqrsMediatorExample.Models;
using MediatR;

namespace CqrsMediatorExample.Notifications
{
    public record ProductAddedNotification(Product Product) : INotification;
}
