namespace LogicGateSimulator
{
    /// <summary>
    /// The base class for any component that has one or more inputs
    /// </summary>
    abstract public class MultiInputComponent : Component
    {
        private Component[] _inputs;
        
        public MultiInputComponent(int numberOfInputs) : base(numberOfInputs)
        {
            _inputs = new Component[numberOfInputs];
        }
        /// <summary>
        /// Connect a component to a specific input
        /// </summary>
        public virtual void SetInputComponentAt(int line, Component component)
        {
            if (line < 0 || line > NumberOfInputs - 1)
                throw new ArgumentException("The line is out of range", nameof(line));

            _inputs[line] = component;
        }

        protected Component[] Inputs => _inputs;
    }
}