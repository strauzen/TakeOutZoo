using UnityEngine;
using System.Collections;

namespace tutorial
{
    public class FindEnemies : MonoBehaviour
    {

        GameObject[] enemies;

        // Use this for initialization
        void Start()
        {
            SearchForEnemies();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void SearchForEnemies()
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy");

            if (enemies.Length > 0)
            {
                foreach(GameObject enemy in enemies)
                {
                    Debug.Log("Found: " + enemy.name);
                    enemy.SetActive(false);
                }
            }
        }
    }
}