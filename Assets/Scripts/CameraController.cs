using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
  public GameObject player;
  private Vector3 offset;

	// Use this for initialization
	void Start ()
  {
    offset = transform.position;
	}
	
	// lateUpdate is better than update for:
  //   follow cameras, procedural animation, 
  //   and gathering last known states
	void LateUpdate ()
  {
    transform.position = player.transform.position + offset;
	}
}
