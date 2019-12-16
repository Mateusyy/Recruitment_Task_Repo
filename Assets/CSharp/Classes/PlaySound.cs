using UnityEngine;
using UnityEngine.UI;

public class PlaySound : IButton
{
    private readonly Button playSoundButton;
    private readonly AudioSource audio;

    public PlaySound(Button playSoundButton, AudioSource audio)
    {
        this.playSoundButton = playSoundButton;
        this.audio = audio;
        SetButtonFunction();
    }

    public void SetButtonFunction()
    {
        playSoundButton.onClick.AddListener(delegate { Execute(); });
    }

    public void Execute()
    {
        try
        {
            //Play sound from audio source
            audio.Play(0);
        }
        catch (System.Exception e)
        {
            Debug.LogError(e);
        }
    }
}
