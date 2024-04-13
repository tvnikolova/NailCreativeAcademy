namespace System.Security.Claims
{
    public static class ClaimsPrincipalExtension
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            string currUser = user.FindFirstValue(ClaimTypes.NameIdentifier);

            return currUser;
        }
        
    }
}