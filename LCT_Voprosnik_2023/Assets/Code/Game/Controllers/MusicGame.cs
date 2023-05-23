using UnityEngine.UI;

public class MusicGame
{
    private MusicGameView _musicView;
    private ChooseAnswer _chooseAnswer;
    private Image _musicImage;
    private bool _music;

    public MusicGame(MusicGameView musicGameView, ChooseAnswer chooseAnswer)
    {
        _musicView = musicGameView;
        _chooseAnswer = chooseAnswer;
    }

    public void Awake()
    {
        _musicImage = _musicView.MusicButton.GetComponent<Image>();
        _music = Save.Music;
        Initialize();
        CheckMusic();
    }

    private void Initialize()
    {
        foreach (var button in _musicView.AllButtonsUI)
        {
            button.onClick.AddListener(Click);
        }

        _musicView.MusicButton.onClick.AddListener(ChangeMusic);
        _chooseAnswer.Correct += PlayTrueAnswer;
        _chooseAnswer.UnCorrect += PlayFalseAnswer;
    }

    private void ChangeMusic()
    {
        _music = !_music;

        Save.SaveMusic(_music);
        CheckMusic();
    }

    private void CheckMusic()
    {
        if (_music)
        {
            _musicView.gameObject.SetActive(true);
            _musicImage.sprite = _musicView.MusicSpriteOn;
        }
        else
        {
            _musicView.gameObject.SetActive(false);
            _musicImage.sprite = _musicView.MusicSpriteOff;
        }
    }

    private void Click()
    {
        _musicView.AudioClickUI.Play();
    }

    private void PlayTrueAnswer()
    {
        _musicView.TrueAnswer.Play();
    }

    private void PlayFalseAnswer()
    {
        _musicView.FalseAnswer.Play();
    }
}
