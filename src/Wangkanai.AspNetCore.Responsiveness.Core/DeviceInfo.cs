namespace Wangkanai.AspNetCore.Responsiveness
{
    public class DeviceInfo
    {
        public virtual string Name { get; }
        public virtual DeviceType Parent { get; }
        public DeviceInfo(string name)
        {
            Name = name;
        }
    }
}