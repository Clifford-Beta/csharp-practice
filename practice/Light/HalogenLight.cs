﻿using System;
using System.Threading.Tasks;

namespace practice.Light
{
    public class HalogenLight : ITimerLight
    {
        private enum HalogenLightState
        {
            On,
            Off,
            TimerModeOn
        }

        private HalogenLightState state;



        public void SwitchOn() => state = HalogenLightState.On;

        public void SwitchOff() => state = HalogenLightState.Off;

        public bool IsOn() => state != HalogenLightState.Off;

        public async Task TurnOnFor(int duration)
        {
            Console.WriteLine("Halogen light starting timer function.");
            state = HalogenLightState.TimerModeOn;
            await Task.Delay(duration);
            state = HalogenLightState.Off;
            Console.WriteLine("Halogen light finished custom timer function");
        }

        public override string ToString() => $"The light is {state}";

    }
}
