namespace _3D
{
    using System;
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface |
        AttributeTargets.Enum, AllowMultiple = false)]
    [Version(1, 5)]
    public class VersionAttribute : Attribute
    {
        public int Dur { get; private set; }    // dur in music means major, the musicians knows that

        public int Moll { get; private set; }   // moll in music means minor

        public VersionAttribute(int major, int minor)
        {
            this.Dur = major;
            this.Moll = minor;
        }

        public override string ToString()
        {
            return string.Format("Version: {0}.{1}", this.Dur, this.Moll);
        }
    }
}
