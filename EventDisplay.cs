using TMPro;
using UnityEngine;

public class EventDisplay : MonoBehaviour
{
    public GameObject textFrame; // Przypisz obiekt "TextFrame" w inspektorze

    private CanvasGroup canvasGroup;
    private TextMeshProUGUI option01_text;

    private void Start()
    {
        canvasGroup = textFrame.GetComponent<CanvasGroup>();
        option01_text = textFrame.GetComponent<TextMeshProUGUI>();
        HideTextFrame();

    }

    public void ShowTextFrame()
    {
        canvasGroup.alpha = 1;
        option01_text.text = "OPTION 01 TEXT";
        Debug.Log("text enabled");
    }

    public void HideTextFrame()
    {
        canvasGroup.alpha = 0;
        option01_text.text = "";
    }

    private void OnMouseEnter()
    {
        ShowTextFrame();
    }

    private void OnMouseExit()
    {
        HideTextFrame();
    }
}