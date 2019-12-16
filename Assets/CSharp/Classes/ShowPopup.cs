using UnityEngine;
using UnityEngine.UI;

public class ShowPopup : IButton
{
    private readonly Button showPopupButton;
    private readonly Animator popupAnimator;
    private readonly Button exitPopupButton;
    private const string ShowPopupBool = "IsShown";

    public ShowPopup(Button showPopupButton, Animator popupAnimator, Button exitPopupButton)
    {
        this.showPopupButton = showPopupButton;
        this.popupAnimator = popupAnimator;
        this.exitPopupButton = exitPopupButton;
        SetButtonFunction();
    }

    public void SetButtonFunction()
    {
        showPopupButton.onClick.AddListener(delegate { Execute(); });
        exitPopupButton.onClick.AddListener(delegate { Execute(); });
    }

    public void Execute()
    {
        try
        {
            //Set bool to turn on or turn off popup always on opposite state
            popupAnimator.SetBool(ShowPopupBool, !popupAnimator.GetBool(ShowPopupBool));
        }
        catch (System.Exception e)
        {
            Debug.LogError(e);
        }
    }
}
