using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class dialogueManager : MonoBehaviour
{

    [SerializeField] public TextMeshProUGUI textComp;
    [SerializeField] public string[] dialogueLines;
    [SerializeField] private float textSpeed;

    public int index;

    private void Start()
    {
        textComp.text = string.Empty;
        startDialogue();
    }

    private void startDialogue()
    {
        index = 0;
        StartCoroutine(typeCharacters());
    }

    IEnumerator typeCharacters()
    {
        foreach (char c in dialogueLines[index].ToCharArray()) 
        {
            textComp.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void startNewLine()
    {
        if (index < dialogueLines.Length - 1) 
        { 
            index++;
            textComp.text += string.Empty;
            StartCoroutine(typeCharacters());
        } else
        {
           gameObject.SetActive(false);
        }
    }
}
