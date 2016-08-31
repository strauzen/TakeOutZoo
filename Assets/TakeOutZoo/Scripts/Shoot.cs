using UnityEngine;
using System.Collections;

namespace tutorial
{

    public class Shoot : MonoBehaviour
    {
        public float fireRate = 0.3f;
        private float nextFire;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            CheckForInput();
        }

        void CheckForInput()
        {
            /*
            if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Debug.Log("Key pressed");
            }
            */

            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Debug.Log("Key pressed");
            }
        }
    }
}
