using UnityEngine;

public class WindowsView : MonoBehaviour
{
    [Header("Windows")]
    [SerializeField] private GameObject _menuWindow;
    [SerializeField] private GameObject _playWindow;
    [SerializeField] private GameObject _tutorialWindow;
    [SerializeField] private GameObject _authorsWindow;
    [SerializeField] private GameObject _collectionWindow;

    public GameObject MenuWindow => _menuWindow;
    public GameObject PlayWindow => _playWindow;
    public GameObject TutorialWindow => _tutorialWindow;
    public GameObject AuthorsWindow => _authorsWindow;
    public GameObject CollectionWindow => _collectionWindow;
}
