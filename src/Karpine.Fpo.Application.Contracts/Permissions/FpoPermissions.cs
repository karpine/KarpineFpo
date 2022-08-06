namespace Karpine.Fpo.Permissions;

public static class FpoPermissions
{
    public const string GroupName = "Fpo";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Crops
    {
        public const string Default = GroupName + ".Crops";
        public const string Create = Default + ".Create";
        public const string Read = Default + ".Read";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class FarmerProfiles
    {
        public const string Default = GroupName + ".FarmerProfiles";
        public const string Create = Default + ".Create";
        public const string Read = Default + ".Read";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
