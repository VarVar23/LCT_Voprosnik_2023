public class TutorialChangeImage 
{
    private TutorialView _tutorialView;
    private WindowsView _windowsView;
    private int _countClick = 0;
    private int _maxCountClick = 0;

    public TutorialChangeImage(TutorialView tutorialView, WindowsView windowsView)
    {
        _tutorialView = tutorialView;
        _windowsView = windowsView;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {
        _tutorialView.TutorialButton.onClick.AddListener(NextImage);

        _maxCountClick = _tutorialView.ListSprites.Count;
    }

    private void NextImage()
    {
        _countClick++;

        if(_countClick >= _maxCountClick)
        {
            _countClick = 0;
            var startSprite = _tutorialView.ListSprites[_countClick];
            _tutorialView.TutorialImage.sprite = startSprite;

            _windowsView.MenuWindow.SetActive(true);
            _windowsView.TutorialWindow.SetActive(false);
        }
        else
        {
            var nextSprite = _tutorialView.ListSprites[_countClick];

            _tutorialView.TutorialImage.sprite = nextSprite;
        }
    }
}
