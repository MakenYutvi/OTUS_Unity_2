using UnityEngine;

public class EnemyZaGeroemControllerFly : Character
{
    
    public float Velocity = 1;

    protected override void Update()
    {
        base.Update();
       
            transform.position += (Player.I.transform.position - transform.position).normalized
               * Velocity * Time.deltaTime;
       
       
    }
}
