using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using static DialogueTree;


public class dialogueController : MonoBehaviour
{
 
    public static dialogueController Instance;

    [SerializeField] private TextMeshProUGUI dialouge;
    [SerializeField] private TextMeshProUGUI nameCard;
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private GameObject answerBox;
    [SerializeField] private Button[] answerButton;

    public static event Action onDialogueStart;
    public static event Action onDialogueStop;

    private bool skipLine;
    private bool answerTriggered;
    private int answerIndex;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void Start()
    {
        skipLine = true;
    }

    public void answerQs(int answer)
    {
        answerIndex = answer;
        answerTriggered = true;
    }

    public void showAnswer(branchPoint branchPoint)
    {
        answerBox.SetActive(true);
        for (int i = 1; i < 3; i++)
        {
            if (i < branchPoint.answers.Length)
            {
                answerButton[i].GetComponentInChildren<TextMeshProUGUI>().text = branchPoint.answers[i].answerType;
                answerButton[i].gameObject.SetActive(true);
            }
            else
            {
                answerButton[i].gameObject.SetActive(false);
            }
        }
    }
}
