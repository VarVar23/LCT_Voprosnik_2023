using UnityEngine;
using UnityEngine.UI;

public class CatView : MonoBehaviour
{
    [SerializeField] private AudioSource _catSound;
    [SerializeField] private Button[] _catButtons;

    public AudioSource CatSound => _catSound;
    public Button[] CatButtons => _catButtons;
}
