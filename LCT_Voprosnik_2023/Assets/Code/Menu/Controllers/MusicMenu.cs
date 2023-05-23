using UnityEngine.UI;

public class MusicMenu 
{
    private MusicMenuView _musicView;
    private Image _musicImage;
    private bool _music;

    public MusicMenu(MusicMenuView musicView)
    {
        _musicView = musicView;
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
        foreach(var button in _musicView.AllButtonsUI)
        {
            button.onClick.AddListener(Click);
        }

        _musicView.MusicButton.onClick.AddListener(ChangeMusic);
    }


    private void ChangeMusic()
    {
        _music = !_music;

        Save.SaveMusic(_music);
        CheckMusic();
    }

    private void CheckMusic()
    {
        if(_music)
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
}
