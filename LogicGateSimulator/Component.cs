namespace LogicGateSimulator
{
    public abstract class Component : IComponent
    {
        public Component(int numberofInput)
        {
            NumberOfInputs = numberofInput;
        }

        /// <summary>
        /// The number of inputs that the component has. 
        /// </summary>
        public int NumberOfInputs { get; }
        
        /// <summary>
        /// The calculated output. Avoid circuit loops.
        /// </summary>
        public abstract bool TheOutput
        {
            get;
        }

        public override string ToString()
        {
            return TheOutput ? "1" : "0";
        }
    }
}