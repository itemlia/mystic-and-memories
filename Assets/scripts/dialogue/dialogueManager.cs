using System.Collections;
using TMPro;
using UnityEngine;

public class dialogueManager : MonoBehaviour
{

    [SerializeField] public TextMeshProUGUI textComp;
    [SerializeField] public string[] dialogueLines;
    [SerializeField] private float textSpeed;

    public int i;

    private void Start()
    {
        textComp.text = string.Empty;
        startDialogue();
    }

    private void startDialogue()
    {
        i = 0;
        StartCoroutine(typeCharacters());
    }

    IEnumerator typeCharacters()
    {
        foreach (char c in dialogueLines[i].ToCharArray())
        {
            textComp.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void startNewLine()
    {
        if (i < dialogueLines.Length - 1)
        {
            i++;
            textComp.text = string.Empty;
            StartCoroutine(typeCharacters());
        }
        
    }

   
}
