using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[CreateAssetMenu]
public class DialogueTree : ScriptableObject
{
    public dialougeSection[] sections;


    [System.Serializable]
    public struct dialougeSection
    {
        [TextArea]
        public string[] dialogue;
        public bool endAfterDialogue;
        public branchPoint branchPoint;
    }

    [System.Serializable] 
    public struct branchPoint
    {
        [TextArea]
        public string question;
        public Answer[] answers;
    }

    [System.Serializable] 
    public struct Answer
    {
        [TextArea]
        public string answerType;
        public int nextDialogueElement;
    }
}
