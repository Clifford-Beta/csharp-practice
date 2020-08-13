using System;
using System.Threading.Tasks;

namespace practice.Light
{
    public class LEDLight : IBlinkingLight, ITimerLight, ILight
    {
        private bool isOn;
        public bool IsOn() => isOn;

        public void SwitchOff() => isOn = false;

        public void SwitchOn() => isOn = true;

        public async Task Blink(int duration, int repeatCount)
        {
            Console.WriteLine("LED Light starting the Blink function.");
            await Task.Delay(duration * repeatCount);
            Console.WriteLine("LED Light has finished the Blink funtion.");
        }

        public override string ToString() => $"The light is {(isOn ? "on" : "off")}";

    }
}
