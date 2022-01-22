using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]

public class PlayerMovement : MonoBehaviour
{

	[Header("Movement Parameters")]
		[Tooltip("Speed at which player moves horizontally.")]
		[SerializeField] private float speed = 5.0f;

	// The current player input for movement
	private Vector2 movement = Vector2.zero;

	private Rigidbody2D rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update movement when player inputs controls
	void OnMove(InputValue movementValues)
	{
		movement = movementValues.Get<Vector2>();
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
	}
}
