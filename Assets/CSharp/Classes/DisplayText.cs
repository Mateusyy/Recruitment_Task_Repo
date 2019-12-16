using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : IButton
{
    private readonly Button displayTextButton;
    private readonly Text displayText;

    private UIController uIController;
    private const float timerValue = 3f;

    public DisplayText(Button displayTextButton, Text displayText)
    {
        this.displayTextButton = displayTextButton;
        this.displayText = displayText;
        SetButtonFunction();
    }

    public void SetButtonFunction()
    {
        displayTextButton.onClick.AddListener(delegate { Execute(); });
    }

    public void Execute()
    {
        try
        {
            //The surrogate MonoBehaviour that we'll use to manage this coroutine.
            uIController = GameObject.FindObjectOfType<UIController>();
            uIController.StartCoroutine(ShowText(timerValue));
        }
        catch (System.Exception e)
        {
            Debug.LogError(e);
        }
    }

    private IEnumerator ShowText(float timer)
    {
        //show displayText if it is turn off now
        if(displayText.gameObject.activeSelf == false)
            displayText.gameObject.SetActive(true);

        float tmpTimer = timer;


        while (tmpTimer >= 0f)
        {
            //decrement timer 1 per second
            tmpTimer -= 1 * Time.deltaTime;

            //Display text formating
            displayText.text = "Here is example text\n";
            for (int i = 0; i < ((int)tmpTimer + 1); i++)
            {
                displayText.text += "<color=red>.</color>";
            }

            yield return null; 
        }

        //turn off displayText when timer is end
        displayText.gameObject.SetActive(false);
    }
}
