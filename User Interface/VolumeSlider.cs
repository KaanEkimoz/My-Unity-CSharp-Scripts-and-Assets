using UnityEngine;
using UnityEngine.UI;

//Adjusts the volume of the game via a slider. Uses PlayerPrefs to save volume data. 
public class VolumeSlider : MonoBehaviour
{
    [Range(0f, 1.0f)]
    [SerializeField] private float defaultVolume = 0.5f;
    [SerializeField] private Slider volumeSlider;
    
    void Start()
    {
        //if there is no saved volume value, it assigns the default value
        if (!PlayerPrefs.HasKey("volumeLevel"))
            SaveVolume(defaultVolume);

        LoadVolume();
    }

    //Add this method to the slider's OnValueChanged event via inspector
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        SaveVolume(volumeSlider.value);
    }

    private void SaveVolume(float value)
    {
        PlayerPrefs.SetFloat("volumeLevel", volumeSlider.value);
    }
    private void LoadVolume()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("volumeLevel");
        volumeSlider.value = AudioListener.volume;
    }
}
