using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Autohand;

public class CheckGrabing : MonoBehaviour
{
	public FollowHand handLFollow;
	public FollowHand handRFollow;
	public Hand handL;
	public Hand handR;
	public bool isLeft;
	public bool isGrabbed;
	private void OnEnable()
	{
		handL.OnGrabbed += OnGrabbed;
		handL.OnReleased += OnReleased;
		handR.OnGrabbed += OnGrabbed;
		handR.OnReleased += OnReleased;
	}
	private void OnDisable()
	{
		handL.OnGrabbed -= OnGrabbed;
		handL.OnReleased -= OnReleased;
		handR.OnGrabbed -= OnGrabbed;
		handR.OnReleased -= OnReleased;
	}

	void OnGrabbed(Hand hand, Grabbable grab)
	{
		if (gameObject.GetComponent<Grabbable>() == grab)
		{
			isGrabbed = true;
			if (hand.left) isLeft = true;
			else isLeft = false;
		}
	}
	void OnReleased(Hand hand, Grabbable grab)
	{

		if (gameObject.GetComponent<Grabbable>() == grab)
		{
			isGrabbed = false;
		}
	}
}
