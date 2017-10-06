using GHIElectronics.TinyCLR.BrainPad;

namespace BrainPadApplication_Annoy_Mom
{
    class Program
    {
        public void BrainPadSetup()
        {
            BrainPad.Display.DrawTextAndShowOnScreen(0, 0, "Annoy!");
        }

        public void BrainPadLoop()
        {
            //BrainPad.Wait.Seconds(2);

            double X = 200;

            while (X < 2000)
            {
                BrainPad.Display.DrawNumberAndShowOnScreen(0, 0, X);
                BrainPad.Buzzer.StartBuzzing(X);

                X+= 10;
            }

            while (X > 200)
            {
                BrainPad.Display.DrawNumberAndShowOnScreen(0, 0, X);
                BrainPad.Buzzer.StartBuzzing(X);

                X-= 10;
            }
            
        }
    }
}
