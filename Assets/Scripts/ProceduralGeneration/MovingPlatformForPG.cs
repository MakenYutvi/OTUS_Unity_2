using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformForPG : MonoBehaviour, ISaveable
{
    public float speed;
    public float Diff;
    private Vector3 _start;
    private Vector3 _end;

    private float current;  // от 0.0 до 1.0
    private float dir;

    // Start is called before the first frame update
    void Start()
    {
        current = 0.0f;
        dir = 1.0f;
        _start = transform.position;
        _start.y = _start.y - Diff / 2;
        _end = transform.position;
        _end.y = _end.y + Diff / 2;
    }

    // Update is called once per frame
    void Update()
    {
     
        current += dir * speed * Time.deltaTime;
        if (current > 1.0f)
        {
            current = 1.0f;
            dir = -1.0f;
        }
        else if (current < 0.0f)
        {
            current = 0.0f;
            dir = 1.0f;
        }
        transform.position = Vector3.Lerp(_start, _end, current);
    }

    void ISaveable.Save(GameState gameState)
    {
        gameState.platformState.current = current;
        gameState.platformState.dir = dir;
    }

    void ISaveable.Restore(GameState gameState)
    {
        current = gameState.platformState.current;
        dir = gameState.platformState.dir;
    }
}
