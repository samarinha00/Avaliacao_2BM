using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
    public int volume;
    public int volumeSFX;
    public bool musica;
    
    public Slider volumeSlider;
    public Slider volumeSFXSlider;
    public Toggle toggleMusica;
    public TextMeshProUGUI textoMusica;

    void Start()
    {
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumeSFX = (int)volumeSFXSlider.value;
    }

    void Update()
    {
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumeSFX = (int)volumeSFXSlider.value;

        if (musica == true)
        {
            textoMusica.text = "LIGADO";
            textoMusica.color = Color.white;
        }
        else
        {
            textoMusica.text = "DESLIGADO";
            textoMusica.color = Color.black;
        }
    }
}
