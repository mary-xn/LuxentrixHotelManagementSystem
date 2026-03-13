namespace LuxentrixContentManagementSystem.Core
{
    public static class AccessControl
    {
        public static bool HasAccess(params string[] allowedRoles)
        {
            if (string.IsNullOrWhiteSpace(UserSession.Role))
                return false;

            return allowedRoles.Contains(UserSession.Role);
        }
    }
}
