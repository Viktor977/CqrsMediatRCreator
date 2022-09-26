using CqrsMadiatRExampel.Models;
using MediatR;

namespace SqrsMadiateRExampel.Notifications
{
    public record ProductAddNotifications(Product Product) : INotification;
   
}
