using UnityEngine;
using UnityEngine.UI;

public class MusicOnOff : MonoBehaviour
{
    public Sprite OnMusic;
    public Sprite OffMusic;
    public bool isOn;
    public AudioSource Music;
    public Image MusicButton;
    

    private void Start()
    {
        isOn = true;
    }
    private void FixedUpdate()
    {
        if(PlayerPrefs.GetInt("music") == 0)
        {
            MusicButton.GetComponent<Image>().sprite = OnMusic;

            Music.enabled = true;

            isOn = true;
        }
        else if (PlayerPrefs.GetInt("music") == 1)
        {
            MusicButton.GetComponent<Image>().sprite = OffMusic;

            Music.enabled = false;

            isOn = false;
        }
    }
    public void OffSound()
    {
        if (!isOn)
        {
            PlayerPrefs.SetInt("music", 0);
        }else if (isOn) 
        {
            PlayerPrefs.SetInt("music", 1);
        }
    }

}

