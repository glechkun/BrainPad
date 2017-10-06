using GHIElectronics.TinyCLR.BrainPad;
using System;
using System.Threading;

namespace BrainPadApplication_MultiThreading_experiment
{
    class Program
    {
        public void BrainPadSetup()
        {
            //Put your setup code here. It runs once when the BrainPad starts up.

            BrainPad.Display.DrawTextAndShowOnScreen(0,0,"Multi");
        }

        public void BrainPadLoop()
        {
            Thread light = new Thread(Second_thread);
            light.Start();



            BrainPad.Display.DrawTextAndShowOnScreen(0, 0, "Line 1");
            BrainPad.Wait.Seconds(1);
            BrainPad.Display.DrawTextAndShowOnScreen(15, 15, "Line 2");
            BrainPad.Wait.Seconds(1);
            BrainPad.Display.DrawTextAndShowOnScreen(30, 30, "Line 3");
            BrainPad.Wait.Seconds(1);
        }

        public void Second_thread()
        {
            BrainPad.LightBulb.TurnWhite();
            BrainPad.Wait.Seconds(1);
            BrainPad.LightBulb.TurnOff();
            BrainPad.Wait.Seconds(1);
        }
    }
}
