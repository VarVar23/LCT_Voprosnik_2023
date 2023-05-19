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

    #endregion

    #region Model

    [Header("Scriptable Objects")]
    [SerializeField] private MapSO _mapSO;

    #endregion


    #region Controllers

    private ActivationWindows _activationWindows;
    private TutorialChangeImage _tutorialChangeImage;
    private CollectionDemo _collectionDemo;
    private MapLevels _mapLevels;

    #endregion

    private void Awake()
    {
        InitializeControllers();

        _activationWindows.Awake();
        _tutorialChangeImage.Awake();
        _collectionDemo.Awake();
        _mapLevels.Awake();
    }

    private void InitializeControllers()
    {
        _activationWindows = new ActivationWindows(_buttonsView, _windowsView);
        _tutorialChangeImage = new TutorialChangeImage(_tutorialView, _windowsView);
        _collectionDemo = new CollectionDemo(_collectionView, _buttonsView);
        _mapLevels = new MapLevels(_playWindowView, _mapSO);
    }
}
