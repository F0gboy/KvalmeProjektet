using UnityEngine;
using System.Collections;
using System;


namespace TMPro.Examples
{
    
    public class TeleType : MonoBehaviour
    {
        //[Range(0, 100)]
        //public int RevealSpeed = 50;

        public bool lang;

        public string[] MessagesDK;
        public string[] MessagesEN;

        public string[] Messages;
        

        public GameObject NextText;

        private TMP_Text m_textMeshPro;

        private int counter = 1;
        private bool isShowing;
        private bool doneShowing;


        void Awake()
        {

            GameObject temp = GameObject.FindGameObjectWithTag("Language");
            if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }

            if (lang)
            {
                Messages = MessagesDK;
            }
            else
            {
                Messages = MessagesEN;
            }

            // Get Reference to TextMeshPro Component
            m_textMeshPro = GetComponent<TMP_Text>();
            m_textMeshPro.text = Messages[0];
            m_textMeshPro.enableWordWrapping = true;
            //m_textMeshPro.alignment = TextAlignmentOptions.Top;

        }


        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("Click");

                Vector2 mousePosition = Input.mousePosition;

                //Debug.Log(mousePosition);
                float distance = Vector2.Distance(GetComponent<BoxCollider2D>().transform.position, mousePosition);

                //Debug.Log(distance);

                if (distance < 260 && counter < Messages.Length && isShowing == false) 
                {
                    Debug.Log("Clicked text");
                    m_textMeshPro.text = MessageFunction(Messages);

                    StartCoroutine(Start());
                }
            }
        }
        
        private string MessageFunction(string[] MessageArray)
        {
            string message;
            message = string.Empty;

            if (counter < MessageArray.Length)
            {
                switch (counter)
                {
                    default:
                        message = string.Empty;
                        break;

                    case 0:
                        message = Messages[0];
                        break;

                    case 1:
                        message = Messages[1];
                        break;

                    case 2:
                        message = Messages[2];
                        break;

                    case 3:
                        message = Messages[3];
                        break;

                    case 4:
                        message = Messages[4];
                        break;

                    case 5:
                        message = Messages[5];
                        break;
                }
            }
            else
            {
                Debug.Log("No more messages to show");
            }
            
            counter++;

            return message;
        }

        private void ShowNextText(GameObject text, bool active)
        {
            if (counter < Messages.Length)
            {
                text.SetActive(active);
            }
            else
            {
                text.SetActive(false);
            }

        }


        IEnumerator Start()
        {
            ShowNextText(NextText, false);

            isShowing = true;

            // Force and update of the mesh to get valid information.
            m_textMeshPro.ForceMeshUpdate();

            int totalVisibleCharacters = m_textMeshPro.textInfo.characterCount; // Get # of Visible Character in text object
            int counter = 0;
            int visibleCount = 0;

            while (true)
            {
                visibleCount = counter % (totalVisibleCharacters + 1);

                m_textMeshPro.maxVisibleCharacters = visibleCount; // How many characters should TextMeshPro display?

                // Once the last character has been revealed, wait 1.0 second and start over.
                if (visibleCount >= totalVisibleCharacters)
                {
                    yield return new WaitForSeconds(1.0f);
                    //m_textMeshPro.text = label02;
                    
                    //m_textMeshPro.text = label01;

                    break;
                }

                counter += 1;

                yield return new WaitForSeconds(0.05f);
            }
            isShowing = false;
            ShowNextText(NextText, true);
            //Debug.Log("Done revealing the text.");

        }

    }
}