using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace tutorial
{
    public class Welcome : MonoBehaviour
    {

        public string myMessage = "WELCOME";
        public Text textWelcome;

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
            if(textWelcome != null)
            {
                textWelcome.text = myMessage;
            }
            else
            {
                Debug.LogWarning("WelcomeText not assigned");
            }
        }
    }
}