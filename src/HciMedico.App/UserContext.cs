using HciMedico.Domain.Models.Entities;

namespace HciMedico.App;

public static class UserContext
{
    public static UserAccount? CurrentUser { get; private set; } = null;

    public static void Initialize(UserAccount userAccount)
    {
        ArgumentNullException.ThrowIfNull(userAccount);

        CurrentUser = userAccount;
    }

    public static void Clean() => CurrentUser = null;
}
