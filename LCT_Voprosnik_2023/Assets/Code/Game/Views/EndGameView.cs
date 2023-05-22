using UnityEngine;

public class EndGameView : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _losePanel;

    public GameObject WinPanel => _winPanel;
    public GameObject LosePanel => _losePanel;
}
