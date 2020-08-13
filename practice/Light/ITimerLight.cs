using System;
using System.Threading.Tasks;

namespace practice.Light
{
    public interface ITimerLight : ILight
    {
        public async Task TurnOnFor(int duration)
        {
            Console.WriteLine("Using the default interface method for the ITimerLight.TurnOnFor.");
            SwitchOn();
            await Task.Delay(duration);
            SwitchOff();
            Console.WriteLine("Completed ITimerLight.TurnOnFor sequence.");
        }
    }
}
