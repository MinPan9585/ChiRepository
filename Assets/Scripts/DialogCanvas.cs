using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogCanvas : MonoBehaviour
{
    public GameObject[] characters;
    public string[] names;
    public int[] whoTalk;
    public string[] sentenceTalk;

    public TMP_Text sentenceText;
    public TMP_Text nameText;
    public int index;

    public GameObject oldBG;
    public GameObject newBG;
    public GameObject button;
    public GameObject dialogueBoxImage;
    public GameObject mask;
    public GameObject castleAnim;
    public GameObject castleAnim2;
    public GameObject nextLevelUI;

    void Start()
    {
        index = 0;
        characters[0].SetActive(false);
        characters[1].SetActive(false);

        nameText.text = names[whoTalk[index]];
        sentenceText.text = sentenceTalk[index];
        characters[whoTalk[index]].SetActive(true);

    }

    public void MoveNext()
    {
        index++;
        if(index == 13)
        {
            oldBG.SetActive(true);
            newBG.SetActive(true);
        }
        characters[0].SetActive(false);
        characters[1].SetActive(false);

        nameText.text = names[whoTalk[index]];
        sentenceText.text = sentenceTalk[index];
        characters[whoTalk[index]].SetActive(true);

        if(index == 15)
        {
            button.SetActive(false);
            StartCoroutine(NextStep());
        }
    }

    IEnumerator NextStep()
    {
        yield return new WaitForSeconds(1);
        characters[0].SetActive(false);
        characters[1].SetActive(false);
        dialogueBoxImage.SetActive(false);
        mask.SetActive(false);
        this.gameObject.SetActive(false);
        castleAnim.SetActive(true);
        castleAnim2.SetActive(true);
        nextLevelUI.SetActive(true);
    }
}
