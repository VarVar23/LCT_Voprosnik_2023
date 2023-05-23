using UnityEngine;
using UnityEngine.UI;

public class MusicGameView : MonoBehaviour
{
    [SerializeField] private Button[] _allButtonsUI;
    [SerializeField] private AudioSource _audioClickUI;
    [SerializeField] private AudioSource _trueAnswer;
    [SerializeField] private AudioSource _falseAnswer;
    [SerializeField] private Sprite _musicSpriteOn;
    [SerializeField] private Sprite _musicSpriteOff;
    [SerializeField] private Button _musicButton;

    public Button[] AllButtonsUI => _allButtonsUI;
    public AudioSource AudioClickUI => _audioClickUI;
    public AudioSource TrueAnswer => _trueAnswer;
    public AudioSource FalseAnswer => _falseAnswer;
    public Sprite MusicSpriteOn => _musicSpriteOn;
    public Sprite MusicSpriteOff => _musicSpriteOff;
    public Button MusicButton => _musicButton;
}
