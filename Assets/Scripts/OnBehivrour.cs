using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBehivrour : StateMachineBehaviour {
    public string[] EnterMessagesUp;
    public string[] EnterMessages;
    public string[] ExitMessages;
	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        for (int i = 0; i < EnterMessagesUp. Length ; i++)
        {
            animator.SendMessageUpwards(EnterMessagesUp[i]);

        } for (int i = 0; i < EnterMessages. Length ; i++)
        {
            animator.SendMessage(EnterMessages[i]);

        }
      
    }

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        for (int i = 0; i < ExitMessages.Length; i++)
        {
            animator.SendMessageUpwards(ExitMessages[i]);

        }
    }

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}
}
