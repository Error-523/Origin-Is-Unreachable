using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class mummyAI : MonoBehaviour
{

	public float distance;
	private float attackTime;
	
	public GameObject target;
	//public PlayerStats player = target.gameObject.GetComponent<PlayerStats>();
	public float chaseRange = 10;
	public float attackRepeatTime = 1.5f;
	float damping;
	private float attackRange = 1.3f;
	public NavMeshAgent agent;
	public ThirdPersonCharacter character;
	
	// Use this for initialization
	void Start () {
		agent.updateRotation = false;
		attackTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{
		distance = Vector3.Distance(target.transform.position, transform.position);

		if (distance < attackRange)
			Attack();
		else if (distance < chaseRange)
			Chase();
		else
			Idle();
	}

	void Attack()
	{
		if (Time.time > attackTime)
		{
			GetComponent<Animator>().Play("Atack_1_Axe");
		}
	}

	void Chase()
	{
		GetComponent<Animator>().Play("Run_Weponless");
		if (target.transform.position.x < 1 || target.transform.position.y < 1) { }
			//agent.SetDestination(target.transform.position);
		if (agent.remainingDistance > agent.stoppingDistance)
			character.Move(agent.desiredVelocity, false, false);
		else
		{
			character.Move(Vector3.zero, false, false);
		}
	}

	void Idle()
	{
		GetComponent<Animator>().Play("Look_Around");
	}
}
