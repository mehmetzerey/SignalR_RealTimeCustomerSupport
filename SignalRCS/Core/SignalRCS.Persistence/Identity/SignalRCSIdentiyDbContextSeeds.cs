namespace SignalRCS.Persistence.Identity;

public static class SignalRCSIdentiyDbContextSeeds
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        await roleManager.CreateAsync(new IdentityRole(Constants.Roles.ADMINISTRATORS));

        //var defaultUser = new ApplicationUser { UserName = "demouser@microsoft.com", Email = "demouser@microsoft.com" };
        //await userManager.CreateAsync(defaultUser, AuthorizationConstants.DEFAULT_PASSWORD);

        var adminUser = new ApplicationUser { UserName = Constants.UserInfos.DEFAULT_ADMIN_USERNAME, Email = Constants.UserInfos.DEFAULT_ADMIN_USERNAME };
        await userManager.CreateAsync(adminUser, Constants.UserInfos.DEFAULT_PASSWORD);
        adminUser = await userManager.FindByNameAsync(Constants.UserInfos.DEFAULT_ADMIN_USERNAME);
        await userManager.AddToRoleAsync(adminUser, Constants.Roles.ADMINISTRATORS);
    }
}
