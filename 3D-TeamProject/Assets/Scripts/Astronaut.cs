using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronaut : MonoBehaviour
{
	public float speed = 0.05f;
	public Animator animator;

	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.D))
		{

			transform.Translate(-Vector2.right * speed);

		}

		if (Input.GetKey(KeyCode.A))
		{

			transform.Translate(Vector2.right * speed);

		}

		if (Input.GetKey(KeyCode.W))
		{

			transform.Translate(Vector2.up * speed);

		}

		if (Input.GetKey(KeyCode.S))
		{

			transform.Translate(-Vector2.up * speed);

		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			animator.Play("jump_start", -1, 0);
		}
	}

}


