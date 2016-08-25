namespace Wangkanai.Extensions.Browser
{
    public class DeviceInfo
    {
        public string Name { get; }
        public DeviceType Device { get; }
        public DeviceInfo(string name)
        {
            Name = name;
        }

        public DeviceInfo(DeviceType type)
        {
            Device = type;
            Name = type.ToString().ToLowerInvariant();
        }

        private DeviceType SetType(string name)
        {

            return DeviceType.Other;
        }
    }
}