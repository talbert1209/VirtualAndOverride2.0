namespace VirtualAndOverride
{
    public class Locksmith
    {
        private string _writtenDownCombination;

        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(_writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        public void WriteDownCombination(string combination)
        {
            _writtenDownCombination = combination;
        }

        public virtual void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}