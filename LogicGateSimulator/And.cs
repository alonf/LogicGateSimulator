namespace LogicGateSimulator
{
    public sealed class And : ShortcutCircuitComponent
    {
        public And(int numberOfInputs) : base(numberOfInputs)
        {
        }

        protected override bool TestValue => false;
    }
}