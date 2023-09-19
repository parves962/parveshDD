using Notifications.Core.Requests;

namespace Notifications.Core.Responses;

public record CreateUserResponse : CreateUserRequest
{
    public int ID { get; init; }

    public DateTimeOffset CreatedAt { get; init; }

}
