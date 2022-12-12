namespace LogicGateSimulator
{
    public sealed class Switch : NonInputComponent
    {
        /// <summary>
        /// The current switch state
        /// </summary>
        public bool State { get; set; }
        
        /// <summary>
        /// Change the switch state to the opposite value
        /// </summary>
        public void Toggle()
        {
            State = !State;
        }

        public override bool TheOutput => State;
    }
}