using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mummyIA : MonoBehaviour {

    public float distance;
    public Transform target;
    public float lookAtDistance = 25.0f;
    public float chaseRange = 20.0f;
    public float chaseRunRange = 10.0f;
    public float attackRange = 2.2f;
    public float moveSpeed = 3.0f;
    public float moveSpeedRun = 6.0f;
    public float damping = 6.0f;
    public float attackRepeatTime = 1.5f;

    public int attackDamage = 34;

    private float attackTime;

    public CharacterController controller;
    public float gravity = 20.0f;
    
    private Vector3 moveDirection = Vector3.zero;
    void Start()
    {
        attackTime = Time.time;
        FindHealth();

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);

        if (distance < lookAtDistance)
            lookAt();
        if (distance < attackRange)
            attack();
        else if (distance < chaseRunRange)
            chaseRun();
        else if (distance < chaseRange)
            chase();
    }

    void lookAt()
    {
        Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }

    void chase()
    {
        GetComponent<Animator>().Play("Weaponless");
        moveDirection = transform.forward;
        moveDirection *= moveSpeed;

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void chaseRun()
    {
        GetComponent<Animator>().Play("Run_Weponless");
        moveDirection = transform.forward;
        moveDirection *= moveSpeedRun;

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void attack()
    {
        if (Time.time > attackTime)
        {
            GetComponent<Animator>().Play("Atack_Weaponless");
            Debug.Log("The enemy has attacked");
            target.SendMessage("applyDamage", attackDamage);
            attackTime = Time.time + attackRepeatTime;
        }
    }

    void noise()
    {
        lookAtDistance += 20;
        chaseRange += 15;
        chaseRunRange += 10;
        moveSpeed += 1;
        moveSpeedRun += 2;
    }

    void FindHealth()
    {
        //target = GameObject.Find("PlayerStats").GetComponent(PlayerStats).transform;
    }
}
