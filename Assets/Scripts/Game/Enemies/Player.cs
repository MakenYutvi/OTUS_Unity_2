using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player I;

    private void Awake()
    {
        I = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.GetComponent<Character>() == null)
            return;
        GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Projectile>() == null)
            return;
        GameOver();
    }

    public static void GameOver()
    {
        Time.timeScale = 0.1f;
        Debug.Log("Game over");
    }
}
