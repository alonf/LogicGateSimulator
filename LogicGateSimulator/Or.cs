namespace LogicGateSimulator
{
    public sealed class Or : ShortcutCircuitComponent
    {
        public Or(int numberOfInputs) : base(numberOfInputs)
        {
        }

        protected override bool TestValue => true;
    }
}