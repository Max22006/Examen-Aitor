using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public List<GameObject> enemiesInScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EnemyList()
    {
        foreach (GameObject enemy in EnemyList)
        {
            Destroy(enemy);
        }
    }
//esto va en el script del goomba
    void OnBecameVisible()
    {
        //_gameManager.EnemyList.Add(gameObject);
    }
    void OnBecameInvisible()
    {
        //_gameManager.EnemyList.Remove(gameObject);
    }
}
