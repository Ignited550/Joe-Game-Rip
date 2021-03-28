using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;
	public float speed;
	public float gravity;
	public float jumpHeight;
	public Transform groundCheck;
	public float groundDistance;
	public LayerMask groundMask;
}
