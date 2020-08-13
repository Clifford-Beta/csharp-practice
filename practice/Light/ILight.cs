using System;
namespace practice.Light
{
    public interface ILight
    {
        void SwitchOn();
        void SwitchOff();
        bool IsOn();
        public PowerStatus Power() => PowerStatus.NoPower;

    }
}
