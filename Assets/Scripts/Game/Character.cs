using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Character : MonoBehaviour, ISaveable
{
    public Transform Visual;
    public float MoveForce;
    public float JumpForce;

    Rigidbody2D rigidBody2D;
    TriggerDetector triggerDetector;
    Animator animator;
    float visualDirection;
    float scaleX;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        visualDirection = 1.0f;
        rigidBody2D = GetComponent<Rigidbody2D>();
        triggerDetector = GetComponentInChildren<TriggerDetector>();
        animator = GetComponentInChildren<Animator>();
        scaleX = Visual.localScale.x;
    }

    public void MoveLeft()
    {
        //if (triggerDetector.InTrigger)
            rigidBody2D.AddForce(new Vector2(-MoveForce, 0), ForceMode2D.Impulse);
    }

    public void MoveRight()
    {
        //if (triggerDetector.InTrigger)
            rigidBody2D.AddForce(new Vector2(MoveForce, 0), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.GetComponent<MovingPlatform>() != null)
            transform.SetParent(collision.transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.GetComponent<MovingPlatform>() != null)
            transform.SetParent(null);
    }

    public void Jump()
    {
        if (triggerDetector.InTrigger) {
            rigidBody2D.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            transform.SetParent(null);
        }
    }

    protected virtual void Update()
    {
        float vel = rigidBody2D.velocity.x;

        if (vel < -0.01f)
            visualDirection = -scaleX;
        else if (vel > 0.01f)
            visualDirection = scaleX;

        Vector3 scale = Visual.localScale;
        scale.x = visualDirection;
        Visual.localScale = scale;

        animator.SetFloat("speed", Mathf.Abs(vel));
    }

    void ISaveable.Save(GameState gameState)
    {
        gameState.playerState.visualDirection = visualDirection;
        gameState.playerState.body.Init(rigidBody2D);
    }

    void ISaveable.Restore(GameState gameState)
    {
        visualDirection = gameState.playerState.visualDirection;
        gameState.playerState.body.Apply(rigidBody2D);
    }
}
