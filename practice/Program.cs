using System;
using System.Threading.Tasks;
using practice.Light;
using practice.InR;


namespace practice
{
    public class Program
    {
        private static async Task TestLightCapabilities(ILight light)
        {
            // Perform basic tests:
            light.SwitchOn();
            Console.WriteLine($"\tAfter switching on, the light is {(light.IsOn() ? "on" : "off")}");
            light.SwitchOff();
            Console.WriteLine($"\tAfter switching off, the light is {(light.IsOn() ? "on" : "off")}");

            if (light is ITimerLight timer)
            {
                Console.WriteLine("\tTesting timer function");
                await timer.TurnOnFor(1000);
                Console.WriteLine("\tTimer function completed");
            }
            else
            {
                Console.WriteLine("\tTimer function not supported.");
            }

            if (light is IBlinkingLight blinker)
            {
                Console.WriteLine("\tTesting blinking function");
                await blinker.Blink(500, 5);
                Console.WriteLine("\tBlink function completed");
            }
            else
            {
                Console.WriteLine("\tBlink function not supported.");
            }
        }

        static async Task Main(string[] args)
        {
            //Console.WriteLine("Testing the overhead light");
            //var overhead = new OverheadLight();
            //await TestLightCapabilities(overhead);
            //Console.WriteLine();

            //Console.WriteLine("Testing the halogen light");
            //var halogen = new HalogenLight();
            //await TestLightCapabilities(halogen);
            //Console.WriteLine();

            //Console.WriteLine("Testing the LED light");
            //var led = new LEDLight();
            //await TestLightCapabilities(led);
            //Console.WriteLine();

            //Console.WriteLine("Testing the fancy light");
            //var fancy = new ExtraFancyLight();
            //await TestLightCapabilities(fancy);
            //Console.WriteLine();

            int[] a = new int[] { 1, 2, 3, 4, 5, 6 };
            
            //Console.WriteLine(reverseArray(a));
            Console.WriteLine("[{0}]", string.Join(", ", reverseArray(a)));

            IndicesAndRanges.Indices();
            IndicesAndRanges.Scenario();



        }

        static int[] reverseArray(int[] a)
        {
            if (a.Length == 0)
                throw new ArgumentException("Input array cannot be empty");
            int buffer;
            int lastIdx = a.Length - 1;
            int midPt = a.Length % 2 == 0 ? a.Length / 2 : (a.Length / 2) + 1;
            for (int i = lastIdx; i >= midPt; i--)
            {
                buffer = a[lastIdx % i];
                a[lastIdx % i] = a[i];
                a[i] = buffer;
            }
            return a;
        }
    }
}
