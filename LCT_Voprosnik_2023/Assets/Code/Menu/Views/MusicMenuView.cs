using UnityEngine;
using UnityEngine.UI;

public class MusicMenuView : MonoBehaviour
{
    [SerializeField] private Button[] _allButtonsUI;
    [SerializeField] private AudioSource _audioClickUI;
    [SerializeField] private Sprite _musicSpriteOn;
    [SerializeField] private Sprite _musicSpriteOff;
    [SerializeField] private Button _musicButton;

    public Button[] AllButtonsUI => _allButtonsUI;
    public AudioSource AudioClickUI => _audioClickUI;
    public Sprite MusicSpriteOn => _musicSpriteOn;
    public Sprite MusicSpriteOff => _musicSpriteOff;
    public Button MusicButton => _musicButton;
}
