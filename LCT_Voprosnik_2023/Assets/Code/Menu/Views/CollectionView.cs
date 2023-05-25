using UnityEngine;
using UnityEngine.UI;

public class CollectionView : MonoBehaviour
{
    [SerializeField] private Button[] _collectionButtons;
    [SerializeField] private Button _backCollectionButton;
    [SerializeField] private Button _backMenuButton;
    [SerializeField] private GameObject _openCartWindow;
    [SerializeField] private Image _cartCollection3D;

    public Button[] CollectionButtons => _collectionButtons;
    public Button BackCollectionButton => _backCollectionButton;
    public Button BackMenuButton => _backMenuButton;
    public GameObject OpenCartWindow => _openCartWindow;
    public Image CartCollection3D => _cartCollection3D;
}
