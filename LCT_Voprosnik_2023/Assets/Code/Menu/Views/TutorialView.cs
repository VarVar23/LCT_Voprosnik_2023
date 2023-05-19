using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialView : MonoBehaviour
{ 
    [SerializeField] private Image _tutorialImage;
    [SerializeField] private Button _tutorialButton;
    [SerializeField] private List<Sprite> _listSprites;

    public Image TutorialImage => _tutorialImage;
    public Button TutorialButton => _tutorialButton;
    public List<Sprite> ListSprites => _listSprites;
}
