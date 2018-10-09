using System;

namespace VirtualAndOverride
{
    public class Owner
    {
        private Jewels _returnedContents;

        public void ReceiveContents(Jewels safeContents)
        {
            _returnedContents = safeContents;
            Console.WriteLine("Thank you for returning my jewels!" + safeContents.Sparkle());



        }
    }
}