using UnityEngine;
using UnityEngine.UI;

public class EndGameView : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _bestWinPanel;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private Image _collectionImage;

    public GameObject WinPanel => _winPanel;
    public GameObject BestWinPanel => _bestWinPanel;
    public GameObject LosePanel => _losePanel;
    public Image CollectionImage => _collectionImage;
}
