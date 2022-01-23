using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))] // Should be a trigger collider
[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Animator))]

public class PlayerMovement : MonoBehaviour
{

	[Header("Movement Parameters")]
		[Tooltip("Speed at which player moves horizontally.")]
		[SerializeField] private float speed = 5.0f;

		[Tooltip("How high the player jumps.")]
		[SerializeField] private float jumpHeight = 5.0f;

	// The current player input for movement
	private Vector2 movement = Vector2.zero;

	// How many ground objects the player is touching
	private int grounded = 0;

	private Rigidbody2D rb;
	private Animator animator;

	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}

	// Update movement when player inputs controls
	void OnMove(InputValue movementValues)
	{
		movement = movementValues.Get<Vector2>();

		if (movement.x == 0)
		{
			animator.SetBool("isRunning", false);
		}
		else
		{
			animator.SetBool("isRunning", true);
			transform.localScale = new Vector3(transform.localScale.y * (movement.x > 0 ? 1 : -1), transform.localScale.y, transform.localScale.z);
		}
	}

	void FixedUpdate()
	{
		if (grounded > 0 && movement.y > 0)
		{
			rb.velocity = new Vector2(movement.x * speed, movement.y * jumpHeight);
			animator.ResetTrigger("landed");
			animator.SetBool("isJumping", true);
		}
		else
		{
			rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Ground")
		{
			grounded++;
			animator.SetBool("isJumping", false);
			animator.SetTrigger("landed");
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Ground")
		{
			grounded--;
		}
	}
}
