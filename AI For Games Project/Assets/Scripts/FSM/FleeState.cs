using UnityEngine;

public class FleeState : State
{
    Agent owner;
    public FleeState(Agent owner) { this.owner = owner; }

    public override void Enter()
    {
        Debug.Log("Entering Flee");
    }
    public override void Execute()
    {
        Debug.Log("Entering Flee");
    }
    public override void Exit()
    {
        Debug.Log("Entering Flee");
    }
}
