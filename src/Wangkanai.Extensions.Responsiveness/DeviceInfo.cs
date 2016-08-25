namespace Wangkanai.Extensions.Responsiveness
{
    public class DeviceInfo
    {
        public virtual string Name { get; }
        public virtual DeviceType Device { get; }
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