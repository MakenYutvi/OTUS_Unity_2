using System.Collections;
using UnityEngine;

public enum EEnemy { EnemyZaGeroem, EnemyTudaSuda }

public class SpawnSystem : MonoBehaviour
{
    //public Character SpaEnemyPrefab;
    public Character SpaEnemy;
    
    void Update()
    {
        if (SpaEnemy != null) return;
        var pos = new Vector3(Random.Range(-10, -7), 7, 0);
        var hit = Physics2D.Raycast(pos, Vector2.down);
        //  if (hit.collider != null && hit.collider.GetComponent<MovingPlatform>() != null)
        if (hit.collider != null)
        {
            var prefab = Resources.Load<Character>("Persons/" + EEnemy.EnemyZaGeroem.ToString());
            SpaEnemy = Instantiate(prefab, pos, Quaternion.identity, transform);
            StartCoroutine(DestroyCorutine()); // аналогично Destroy(SpaEnemy, 15);
        }
        else Debug.Log("No platform under " + pos);
    }

    IEnumerator DestroyCorutine()
    {
        yield return new WaitForSeconds(15);
        Destroy(SpaEnemy);
    }
}
