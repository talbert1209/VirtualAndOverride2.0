namespace VirtualAndOverride
{
    public class Safe
    {
        private Jewels _contents = new Jewels();
        private string _safeCombination = "12345";

        public Jewels Open(string combination)
        {
            if (combination == _safeCombination)
                return _contents;
            else
                return null;
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}