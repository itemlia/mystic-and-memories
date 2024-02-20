using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newLine : dialogueManager
{

    public dialogueManager dm;
    public void OnMouseDown()
    {
        //starts new line of dialogue when the button is pressed

        if (dm.textComp.text == dm.dialogueLines[dm.i])
        {
            dm.startNewLine();
        }
        else
        {
            StopAllCoroutines();
            dm.textComp.text = dm.dialogueLines[dm.i];
        }
    }
}
