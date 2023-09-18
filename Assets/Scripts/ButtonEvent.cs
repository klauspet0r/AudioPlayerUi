using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UIElements;
using UnityEngine.UIElements.UIR;

public class ButtonEvent : MonoBehaviour
{   
    public VisualTreeAsset uiTemplate;

    public Button PlayButton;
    public Button PauseButton;

    public VisualElement canvas;

    public AudioPlayer audioplayer;

    // Start is called before the first frame update
    void Start()
    {
        if (uiTemplate != null)
        {
            canvas = uiTemplate.CloneTree();
            Debug.Log("canvas childCount is: " + canvas.childCount);
            PlayButton = canvas.Q<Button>("Play");
            PauseButton = canvas.Q<Button>("Pause");
        }

        if (PlayButton != null && PauseButton != null)
        {
            //PlayPauseButton.clickable.clicked += audioplayer.PlayAudio;
            PlayButton.clickable.clicked += audioplayer.PlayAudio;
            PauseButton.clickable.clicked += audioplayer.PauseAudio;
            
        }
        else
        {
            Debug.LogError("Button not found in the UI Canvas.");
        }
        
        GetComponent<UIDocument>().rootVisualElement.Add(canvas);
        Debug.Log("canvas childCount is: " + canvas.childCount);
    }

    private void HandleButtonClick()
    {
        Debug.Log("Button Clicked!");
        // Add your custom code here to execute when the button is clicked
    }
}
