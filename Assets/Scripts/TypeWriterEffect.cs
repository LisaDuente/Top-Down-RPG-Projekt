using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeWriterEffect : MonoBehaviour
{
    public float typewriterSpeed;
    public string textToType;



    public void Run(string textToType, TMP_Text textLabel) //responsible for running the Coroutine
    {
        StartCoroutine(TypeText(textToType, textLabel));
    }

    private IEnumerator TypeText(string textToType, TMP_Text textLabel) //draws the text on screen
    {
        textLabel.text = string.Empty;
       //yield return new WaitForSeconds(2);
        
        float t = 0;
        int charIndex = 0;

        while (charIndex < textToType.Length)
        {
            t += Time.deltaTime * typewriterSpeed; //becomes 1 after one second
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);

            textLabel.text = textToType.Substring(0, charIndex);
            
            yield return null; //wait one frame

        }

        textLabel.text = textToType;
    }
}
