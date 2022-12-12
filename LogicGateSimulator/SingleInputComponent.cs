namespace LogicGateSimulator
{
    abstract public class SingleInputComponent : Component
    {
        protected Component? Input { get; set; }
        public SingleInputComponent(Component? component = null)
            : base(1)
        {
            Input = component;
        }

        /// <summary>
        /// Connect a component to a specific input
        /// </summary>
        public virtual void SetInput(Component component)
        {
            Input = component;
        }
      
    }
}