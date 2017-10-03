using GHIElectronics.TinyCLR.BrainPad;

namespace BrainPadApplication1
{
    class Program
    {
        public void BrainPadSetup()
        {
            //Put your setup code here. It runs once when the BrainPad starts up.

            BrainPad.Display.DrawTextAndShowOnScreen(0, 0, "Rainbow");
        }

        public void BrainPadLoop()
        {
            //Put your program code here. It runs repeatedly after the BrainPad starts up.

            //BrainPad.Buzzer.Beep 
            //test loop colors
            /*BrainPad.LightBulb.TurnWhite();
            BrainPad.Wait.Seconds(1);
            BrainPad.LightBulb.TurnBlue();
            BrainPad.Wait.Seconds(1);
            BrainPad.LightBulb.TurnGreen();
            BrainPad.Wait.Seconds(1);
            BrainPad.LightBulb.TurnRed();
            BrainPad.Wait.Seconds(1);*/

            //BrainPad.LightBulb.TurnColor(RED, GREEN, BLUE);  EXAMPLE!!
            double RED = 100, BLUE = 0, GREEN = 0; //100 is max

            //BrainPad.LightBulb.TurnColor(100, 1, 0);
            
           

            while (GREEN < 100)
            {
                BrainPad.LightBulb.TurnColor(RED, GREEN, BLUE);
                //BrainPad.Display.DrawTextAndShowOnScreen(0, 0, $"{RED},{GREEN},{BLUE}");
                BrainPad.Wait.Milliseconds(5);
                GREEN++;
            }
            while (RED > 0)
            {
                BrainPad.LightBulb.TurnColor(RED, GREEN, BLUE);
                //BrainPad.Display.DrawTextAndShowOnScreen(0, 0, $"{RED},{GREEN},{BLUE}");
                BrainPad.Wait.Milliseconds(5);
                RED--;
            }
            while (BLUE < 100)
            {
                BrainPad.LightBulb.TurnColor(RED, GREEN, BLUE);
                //BrainPad.Display.DrawTextAndShowOnScreen(0, 0, $"{RED},{GREEN},{BLUE}");
                BrainPad.Wait.Milliseconds(5);
                BLUE++;
            }
            while (GREEN > 0)
            {
                BrainPad.LightBulb.TurnColor(RED, GREEN, BLUE);
                //BrainPad.Display.DrawTextAndShowOnScreen(0, 0, $"{RED},{GREEN},{BLUE}");
                BrainPad.Wait.Milliseconds(5);
                GREEN--;
            }
            while (RED < 100)
            {
                BrainPad.LightBulb.TurnColor(RED, GREEN, BLUE);
                //BrainPad.Display.DrawTextAndShowOnScreen(0, 0, $"{RED},{GREEN},{BLUE}");
                BrainPad.Wait.Milliseconds(5);
                RED++;
            }
            while (BLUE > 0)
            {
                BrainPad.LightBulb.TurnColor(RED, GREEN, BLUE);
                //BrainPad.Display.DrawTextAndShowOnScreen(0, 0, $"{RED},{GREEN},{BLUE}");
                BrainPad.Wait.Milliseconds(5);
                BLUE--;
            }

        }
    }
}
