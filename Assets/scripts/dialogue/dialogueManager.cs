using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dialogueManager : MonoBehaviour
{

    [SerializeField] public TextMeshProUGUI textComp;
    [SerializeField] public string[] dialogueLines;
    private float textSpeed = 0.1f;

    public int i;
  

    private void Start()
    {
       
        textComp.text = string.Empty;
        startDialogue();
    }

    private void startDialogue()
    {
        StartCoroutine(typeCharacters());
    }

    IEnumerator typeCharacters()
    {
        while (i >= dialogueLines.Length)
        {
            yield return new WaitForNextFrameUnit();
        }


        string s = dialogueLines[i];
        foreach (char c in s.ToCharArray(0, s.Length))
        {
            textComp.text = textComp.text + c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void startNewLine()
    {
        if (i < dialogueLines.Length - 1 )
        {
            i++;
            textComp.text = string.Empty;
            StartCoroutine(typeCharacters());
        } 
        
        
    }

   
}
