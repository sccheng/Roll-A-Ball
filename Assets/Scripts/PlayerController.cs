using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
  public float speed;
  public GUIText countText;
  public GUIText winText;
  private int count;
  
  void Start()
  {
    count = 0;
    SetCountText();
    winText.text = "";
  }
  
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
  
  //called  by unity when object first touches a trigger collider
  void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag == "PickUp")
    {
      other.gameObject.SetActive(false);
      count++;
      SetCountText();
    }
  }
  
  void SetCountText()
  {
    countText.text = "Count: " + count.ToString();
    if(count >= 12)
    {
      winText.text = "YOU WIN!";
    }
  }
}
