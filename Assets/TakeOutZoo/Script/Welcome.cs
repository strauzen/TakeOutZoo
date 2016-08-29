using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace tutorial
{
    public class Welcome : MonoBehaviour
    {

        public string myMessage;
        private float waitTime = 3.5f;
        public Text textWelcome;
        public GameObject canvasWelcome;

        // Use this for initialization
        void Start()
        {
            SetInitialReference();
            MyWelcomeMessage();
        }

        void SetInitialReference()
        {
            textWelcome = GameObject.Find("TextWelcome").GetComponent<Text>();
        }

        void MyWelcomeMessage()
        {
            if (textWelcome != null)
            {
                textWelcome.text = myMessage;
            }
            else
            {
                Debug.LogWarning("WelcomeText not assigned");
            }

            StartCoroutine(DisableCanvas(this.waitTime));

        }

        IEnumerator DisableCanvas(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            canvasWelcome.SetActive(false);
        }
    }
}