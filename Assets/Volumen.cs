using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour 
{
    
    public AudioSource audioSource;
    public Slider volumeSlider;

    private void Start() {
        // Obtener el valor actual del volumen del AudioSource y asignarlo al valor del slider
        volumeSlider.value = audioSource.volume;

        // Suscribirse al evento onValueChanged del slider
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderValueChanged);
    }

    private void OnVolumeSliderValueChanged(float volume) {
        // Actualizar el volumen del AudioSource con el valor del slider
        audioSource.volume = volume;
    }
}
