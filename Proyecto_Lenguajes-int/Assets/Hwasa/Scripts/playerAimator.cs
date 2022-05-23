using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAimator : MonoBehaviour
{
    private Animator playerAnimators;
    public string currentState;
    public string playerIdle= "PlayerIdle";
     public string playerWalk= "PlayerWalk";
      public string playerJump = "PlayerJump";



    void Start()
    {
        playerAnimators = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerVariables.isWalking && !playerVariables.isJumping){
            PlayerAnim(playerWalk);
        }
        else if(!playerVariables.isWalking && !playerVariables.isJumping){
            PlayerAnim(playerIdle);
        }
         else if(!playerVariables.isJumping ){
            PlayerAnim(playerJump);
        }
    }
    public void PlayerAnim(string newState){
        if(currentState == newState)return;
        playerAnimators.Play(newState);
        currentState = newState;

        
    }
}
