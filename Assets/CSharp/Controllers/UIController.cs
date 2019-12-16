using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button _showPopupButton;
    public Button _displayTextButton;
    public Button _playSoundButton;

    [Header("Popup properties")]
    public Animator _popup;
    public Button _exitPopupButton;

    [Header("DisplayText properties")]
    public Text _displayText;

    [Header("PlaySound properties")]
    public AudioSource _audio;

    private void Start()
    {
        IButton showPopup = new ShowPopup(_showPopupButton, _popup, _exitPopupButton);
        IButton displayText = new DisplayText(_displayTextButton, _displayText);
        IButton playSound = new PlaySound(_playSoundButton, _audio);
    }
}
