using System;

namespace VirtualAndOverride
{
    public class JewelThief : Locksmith
    {
        private Jewels _stolenJewels;

        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            _stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! " + _stolenJewels.Sparkle());
        }
    }
}