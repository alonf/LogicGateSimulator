namespace LogicGateSimulator
{
    interface IComponent
    {
        int NumberOfInputs { get; }
        bool TheOutput { get; }
    }
}