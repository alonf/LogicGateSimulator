namespace LogicGateSimulator
{
    abstract public class ShortcutCircuitComponent : MultiInputComponent
    {

        public ShortcutCircuitComponent(int numberOfInputs) : base(numberOfInputs)
        {
        }

        protected abstract bool TestValue
        {
            get;
        }

        public override bool TheOutput => Inputs.Any(c => c.TheOutput == TestValue) ^ !TestValue;
    }
}