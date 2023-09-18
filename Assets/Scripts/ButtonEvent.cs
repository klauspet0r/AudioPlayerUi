using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UIElements;
using UnityEngine.UIElements.UIR;

public class ButtonEvent : MonoBehaviour
{   
    public VisualTreeAsset uiTemplate;

    private Button PlayPauseButton;

    private VisualElement canvas;

    public AudioPlayer audioplayer;

    // Start is called before the first frame update
    void Start()
    {
        if (uiTemplate != null)
        {
            VisualElement canvas = uiTemplate.CloneTree();
            PlayPauseButton = canvas.Q<Button>("PlayPause");
            Debug.Log(PlayPauseButton.name);
        }

        if (PlayPauseButton != null)
        {
            //PlayPauseButton.clickable.clicked += audioplayer.PlayAudio;
            PlayPauseButton.clickable.clicked += HandleButtonClick;
            Debug.Log(PlayPauseButton.clickable.ToString());
        }
        else
        {
            Debug.LogError("Button not found in the UI Canvas.");
        }
        
        GetComponent<UIDocument>().rootVisualElement.Add(canvas);
    }

    private void HandleButtonClick()
    {
        Debug.Log("Button Clicked!");
        // Add your custom code here to execute when the button is clicked
    }
}
