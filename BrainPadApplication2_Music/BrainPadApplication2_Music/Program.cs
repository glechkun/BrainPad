using GHIElectronics.TinyCLR.BrainPad;

namespace BrainPadApplication2_Music
{
    class Program
    {
        public void BrainPadSetup()
        {
            //Put your setup code here. It runs once when the BrainPad starts up.

            BrainPad.Display.DrawTextAndShowOnScreen(0, 0, "Music");
        }

        public void BrainPadLoop()
        {
            //Put your program code here. It runs repeatedly after the BrainPad starts up.

            //BrainPad.LightBulb.TurnWhite();
            //BrainPad.Wait.Seconds(1);
            //BrainPad.LightBulb.TurnOff();
            //BrainPad.Wait.Seconds(1);

            double E = 329.6, D = 293.6, C = 261.6, G = 391.9;

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);
            
            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(500);

            BrainPad.Buzzer.StartBuzzing(C);
            BrainPad.Wait.Milliseconds(500);

            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(500);

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(1000);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(1000);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(G);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(G);
            BrainPad.Wait.Milliseconds(1000);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            //////////////////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);

            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(500);

            BrainPad.Buzzer.StartBuzzing(C);
            BrainPad.Wait.Milliseconds(500);

            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(500);

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(10);

            BrainPad.Buzzer.StartBuzzing(E);
            BrainPad.Wait.Milliseconds(500);

            BrainPad.Buzzer.StartBuzzing(D);
            BrainPad.Wait.Milliseconds(500);

            BrainPad.Buzzer.StartBuzzing(C);
            BrainPad.Wait.Milliseconds(2000);
        }
    }
}
