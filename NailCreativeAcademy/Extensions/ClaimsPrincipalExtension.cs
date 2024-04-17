namespace System.Security.Claims
{
    using static NailCreativeAcademy.Core.Constants.AdminConstants;
    public static class ClaimsPrincipalExtension
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            string currUser = user.FindFirstValue(ClaimTypes.NameIdentifier);

            return currUser;
        }

        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(RoleAdmin);
        }

    }
}