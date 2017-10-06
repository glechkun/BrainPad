using GHIElectronics.TinyCLR.BrainPad;

namespace BrainPadApplication3_ImperialMarch
{
    class Program
    {
        public void BrainPadSetup()
        {
            //Put your setup code here. It runs once when the BrainPad starts up.

            BrainPad.Display.DrawTextAndShowOnScreen(0, 0, "Darth" +"\n" + "Vader");
            
        }

        public void BrainPadLoop()
        {
            //Put your program code here. It runs repeatedly after the BrainPad starts up.
            
            //Notes by frequency
            //First octave
            double C_1 = 16.351, Cs_1 = 17.324, Df_1 = 17.324, D_1 = 18.354, Ds_1 = 19.445, Ef_1 = 19.445;
            double E_1 = 20.601, F_1 = 21.827, Fs_1 = 23.124, Gf_1 = 23.124, G_1 = 24.499, Gs_1 = 25.956, Af_1 = 25.956;
            double A_1 = 27.5, As_1 = 29.135, Bf_1 = 29.135, B_1 = 30.868;

            //Second octave
            double C_2 = 32.703, Cs_2 = 34.648, Df_2 = 34.648, D_2 = 36.708, Ds_2 = 38.891, Ef_2 = 38.891;
            double E_2 = 41.203, F_2 = 43.654, Fs_2 = 46.249, Gf_2 = 46.249, G_2 = 48.999, Gs_2 = 51.913, Af_2 = 51.913;
            double A_2 = 55, As_2 = 58.27, Bf_2 = 58.27, B_2 = 61.735;

            //Third octave
            double C_3 = 65.406, Cs_3 = 69.296, Df_3 = 69.296, D_3 = 73.416, Ds_3 = 77.782, Ef_3 = 77.782;
            double E_3 = 82.407, F_3 = 87.307, Fs_3 = 92.499, Gf_3 = 92.499, G_3 = 97.999, Gs_3 = 103.826, Af_3 = 103.826;
            double A_3 = 110, As_3 = 116.541, Bf_3 = 116.541, B_3 = 123.471;

            //Fourth octave
            double C_4 = 130.813, Cs_4 = 138.591, Df_4 = 138.591, D_4 = 146.832, Ds_4 = 155.563, Ef_4 = 155.563;
            double E_4 = 164.814, F_4 = 174.614, Fs_4 = 184.997, Gf_4 = 184.997, G_4 = 195.998, Gs_4 = 207.652, Af_4 = 207.652;
            double A_4 = 220, As_4 = 233.082, Bf_4 = 233.082, B_4 = 246.942;

            //Fifth octave
            double C_5 = 261.626, Cs_5 = 277.183, Df_5 = 277.183, D_5 = 293.665, Ds_5 = 311.127, Ef_5 = 311.127;
            double E_5 = 329.628, F_5 = 349.228, Fs_5 = 369.994, Gf_5 = 369.994, G_5 = 391.995, Gs_5 = 415.305, A5_5 = 415.305;
            double A_5 = 440, As_5 = 466.164, Bf_5 = 466.164, B_5 = 493.883;

            //Sixth octave
            double C_6 = 523.251, Cs_6 = 554.365, Df_6 = 554.365, D_6 = 587.33, Ds_6 = 622.254, Ef_6 = 622.254;
            double E_6 = 659.255, F_6 = 698.456, Fs_6 = 739.989, Gf_6 = 739.989, G_6 = 783.991, Gs_6 = 830.609, Af_6 = 830.609;
            double A_6 = 880, As_6 = 932.328, Bf_6 = 932.328, B_6 = 987.767;



            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Ef_5);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            /////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Ef_5);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(1000);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            /////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(D_6);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(D_6);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(D_6);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Ef_6);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            ////////////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(Gf_5);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Ef_5);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(1000);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            //////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(G_6);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_6);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Gf_6);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(F_6);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            ///////////////////////////////////////////////////^^^^^^^

            BrainPad.Buzzer.StartBuzzing(E_6);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Ds_6);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(E_6); //<------ might need to be flat
            BrainPad.Wait.Milliseconds(250);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Wait.Milliseconds(250);

            BrainPad.Buzzer.StartBuzzing(Gs_5); 
            BrainPad.Wait.Milliseconds(250);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Cs_6); 
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(C_6);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(B_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            /////////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(A_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Bf_5); 
            BrainPad.Wait.Milliseconds(250);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Wait.Milliseconds(250);

            BrainPad.Buzzer.StartBuzzing(Ef_5);
            BrainPad.Wait.Milliseconds(250);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Gf_5);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Ef_5);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Gf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            /////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(Bf_5); 
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(D_6);
            BrainPad.Wait.Milliseconds(1000);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            /////////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(G_6);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_6);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Gf_6);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(F_6);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            //////////////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(E_6);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Ds_6);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(E_6); //<------ might need to be flat
            BrainPad.Wait.Milliseconds(250);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Wait.Milliseconds(250);

            BrainPad.Buzzer.StartBuzzing(Gs_5);
            BrainPad.Wait.Milliseconds(250);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Cs_6);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(C_6);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(B_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            /////////////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(A_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(250);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Wait.Milliseconds(250);

            BrainPad.Buzzer.StartBuzzing(Ef_5);
            BrainPad.Wait.Milliseconds(250);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Gf_5);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Ef_5);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            //////////////////////////////////////////

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(500);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Ef_5);
            BrainPad.Wait.Milliseconds(375);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(Bf_5);
            BrainPad.Wait.Milliseconds(125);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);

            BrainPad.Buzzer.StartBuzzing(G_5);
            BrainPad.Wait.Milliseconds(1000);
            BrainPad.Buzzer.StopBuzzing();
            BrainPad.Wait.Milliseconds(5);



            BrainPad.Wait.Seconds(5);
        }
    }
}
