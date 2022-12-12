namespace LogicGateSimulator
{
    public class Not : SingleInputComponent
    {
        public override bool TheOutput =>  !Input!.TheOutput; 
    }
}