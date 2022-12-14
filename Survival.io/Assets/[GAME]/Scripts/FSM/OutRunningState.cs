using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutRunningState : PlayerStates
{
    public override void EnterState(PlayerController fsm)
    {
        Debug.Log("out running");
    }

    public override void UpdateState(PlayerController fsm)
    {
            if (fsm.executingState != ExecutingState.OUTRUN)
            {
                ExitState(fsm);
            }
            else
            {
                fsm.animator.SetBool("isOutRunning", true);
                fsm.animator.SetBool("isOutIdle", false);
                fsm.animator.SetBool("isInRunning", false);
                fsm.animator.SetBool("isInIdle", false);
            }
    }

    public override void ExitState(PlayerController fsm)
    {
        if(fsm.executingState == ExecutingState.INRUN) 
        {
            fsm.SwitchState(fsm.inRunningState);
        }
        else if(fsm.executingState == ExecutingState.OUTIDLE)
        {
            fsm.SwitchState(fsm.outIdleState);
        } 
    }
}
