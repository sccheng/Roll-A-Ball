using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
  public float speed;
  
  //called before rendering a frame (usually game code goes here)
  void Update()
  {
    
  }
  
  //called before performing any physics calculations
  void FixedUpdate()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");
    
    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    
    rigidbody.AddForce(movement * speed * Time.deltaTime);
  }
}
