using UnityEngine;
using System.Collections;

namespace tutorial
{

    public class Shoot : MonoBehaviour
    {
        public float fireRate = 0.3f;
        private float nextFire;
        private RaycastHit hit;
        private float range = 300;
        private Transform myTransform;

        // Use this for initialization
        void Start()
        {
            SetInitialReferences();
        }

        // Update is called once per frame
        void Update()
        {
            CheckForInput();
        }

        void SetInitialReferences()
        {
            myTransform = transform;
        }

        void CheckForInput()
        {

            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                Debug.DrawRay(myTransform.TransformPoint(0,0,1), myTransform.forward, Color.green, 3);
                if (Physics.Raycast(myTransform.TransformPoint(0,0,1), myTransform.forward, out hit, range))
                {
                    if(hit.transform.CompareTag("Enemy"))
                    {
                        Debug.Log("Enemy " + hit.transform.name);
                    } else
                    {
                        Debug.Log("Not an enemy");
                    }
                }

                nextFire = Time.time + fireRate;
                //Debug.Log("Key pressed");
            }
        }
    }
}
