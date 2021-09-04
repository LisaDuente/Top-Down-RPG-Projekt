using TMPro;
using UnityEngine;

public class ShowingText : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;

    private void Start()
    {
        //GetComponent<TypeWriterEffect>().Run("Here is my text!\nIwant to say you smell bad!", textLabel);
    }

    public void displayText(string text)
    {
        GetComponent<TypeWriterEffect>().Run(text, textLabel);

    }

}
