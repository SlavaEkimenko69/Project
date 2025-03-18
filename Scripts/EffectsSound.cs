using UnityEngine;
using UnityEngine.UI;

public class EffectsSound : MonoBehaviour
{
    public bool onOff;


    private void Start()
    {
        onOff = false;
    }
    private void Update()
    {
        SoundsOff();
    }

    public void SoundsOff()
    {
        if (!onOff)
        {
            
            AudioListener.volume = 2f;
            onOff = true;
        }else
        {
           
            AudioListener.volume = 0f;
            onOff = false;

        }

    }
    
}
