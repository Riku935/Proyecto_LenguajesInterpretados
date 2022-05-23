using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLedgeGrab : MonoBehaviour
{
    private bool greenBox, redBox;
      public float  redXOffset, redYOffset, redXSize, redYSize, greenXOffset, greenYOffset, greenXSize, greenYSize;
      private Rigidbody2D rb;
      private float starlingGrav;
      public LayerMask groundMask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        starlingGrav = rb.gravityScale;
        if(greenBox && !redBox &&!playerVariables.isGrabbing && playerVariables.isJumping){
            playerVariables.isGrabbing = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
       greenBox =Physics2D.OverlapBox (new Vector2(transform.position.x+(greenXOffset*transform.localScale.x), transform.position.y+greenYOffset), new Vector2(greenXSize, greenYSize), 0f, groundMask);
        redBox= Physics2D.OverlapBox(new Vector2(transform.position.x+(redXOffset*transform.localScale.x), transform.position.y+redYOffset), new Vector2(redXSize, redYSize), 0f, groundMask);
    }
    public void ChangePos(){
       transform.position = new Vector2(transform.position.x + (0.5f * transform.localScale.x),transform.position.y + 0.4f);
       rb.gravityScale = starlingGrav;
       playerVariables.isGrabbing = false;
    }
   private void OnDrawGizmosSelected(){ 
    Gizmos.color=Color.red;
    Gizmos.DrawWireCube(new Vector2(transform.position.x+(redXOffset*transform. localScale.x), transform.position.y+redYOffset), new Vector2(redXSize, redYSize));
    Gizmos.color=Color.green;
    Gizmos.DrawWireCube(new Vector2(transform.position.x+(greenXOffset*transform.localScale.x), transform.position.y+greenYOffset), new Vector2(greenXSize, greenYSize));
}
}
