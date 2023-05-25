using UnityEngine;

public class MainMenu : MonoBehaviour
{

    #region Views

    [Header("Views")]
    [SerializeField] private ButtonsView _buttonsView;
    [SerializeField] private WindowsView _windowsView;
    [SerializeField] private TutorialView _tutorialView;
    [SerializeField] private CollectionView _collectionView;
    [SerializeField] private PlayWindowView _playWindowView;
    [SerializeField] private MusicMenuView _musicView;
    [SerializeField] private ButterflyView _butterflyView;

    #endregion

    #region Model

    [Header("Scriptable Objects")]
    [SerializeField] private MapSO _mapSO;
    [SerializeField] private CollectionSO _collectionSO;
    [SerializeField] private EndGameSO _endGameSO;

    #endregion

    #region Controllers

    private LoadSaveData _loadSaveData;
    private ActivationWindows _activationWindows;
    private TutorialChangeImage _tutorialChangeImage;
    private Collection _collectionDemo;
    private MapLevels _mapLevels;
    private ChooseLevel _chooseLevel;
    private MusicMenu _musicController;
    private ButterflyActive _butterflyActive;

    #endregion

    private void Awake()
    {
        InitializeControllers();

        _loadSaveData.Awake();
        _activationWindows.Awake();
        _tutorialChangeImage.Awake();
        _collectionDemo.Awake();
        _mapLevels.Awake();
        _chooseLevel.Awake();
        _musicController.Awake();
        _butterflyActive.Awake();
    }

    private void InitializeControllers()
    {
        _loadSaveData = new LoadSaveData();
        _activationWindows = new ActivationWindows(_buttonsView, _windowsView);
        _tutorialChangeImage = new TutorialChangeImage(_tutorialView, _windowsView);
        _collectionDemo = new Collection(_collectionView, _buttonsView, _collectionSO);
        _mapLevels = new MapLevels(_playWindowView, _mapSO);
        _chooseLevel = new ChooseLevel(_playWindowView);
        _musicController = new MusicMenu(_musicView);
        _butterflyActive = new ButterflyActive(_butterflyView, _endGameSO);
    }
}
