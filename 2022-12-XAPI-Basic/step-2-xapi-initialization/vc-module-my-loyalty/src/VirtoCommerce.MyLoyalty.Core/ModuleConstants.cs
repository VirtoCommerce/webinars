using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Settings;

namespace VirtoCommerce.MyLoyalty.Core;

public static class ModuleConstants
{
    public static class Security
    {
        public static class Permissions
        {
            public const string Access = "MyLoyalty:access";
            public const string Create = "MyLoyalty:create";
            public const string Read = "MyLoyalty:read";
            public const string Update = "MyLoyalty:update";
            public const string Delete = "MyLoyalty:delete";

            public static string[] AllPermissions { get; } =
            {
                Access,
                Create,
                Read,
                Update,
                Delete,
            };
        }
    }

    public static class Settings
    {
        public static class General
        {
            public static SettingDescriptor MyLoyaltyEnabled { get; } = new SettingDescriptor
            {
                Name = "MyLoyalty.MyLoyaltyEnabled",
                GroupName = "MyLoyalty|General",
                ValueType = SettingValueType.Boolean,
                DefaultValue = false,
            };

            public static SettingDescriptor MyLoyaltyPassword { get; } = new SettingDescriptor
            {
                Name = "MyLoyalty.MyLoyaltyPassword",
                GroupName = "MyLoyalty|Advanced",
                ValueType = SettingValueType.SecureString,
                DefaultValue = "qwerty",
            };

            public static IEnumerable<SettingDescriptor> AllGeneralSettings
            {
                get
                {
                    yield return MyLoyaltyEnabled;
                    yield return MyLoyaltyPassword;
                }
            }
        }

        public static IEnumerable<SettingDescriptor> AllSettings
        {
            get
            {
                return General.AllGeneralSettings;
            }
        }
    }
}
