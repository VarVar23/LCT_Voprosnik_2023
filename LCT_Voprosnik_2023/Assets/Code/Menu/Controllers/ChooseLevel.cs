using UnityEngine.SceneManagement;

public class ChooseLevel 
{
    private PlayWindowView _playWindowView;

    public ChooseLevel(PlayWindowView playWindowView)
    {
        _playWindowView = playWindowView;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {
        var buttons = _playWindowView.LevelButtons;

        int i = 0;
        foreach (var button in buttons)
        {
            int j = i;
            button.onClick.AddListener(() => ChooseLevelMethod(j));
            i++;
        }
    }

    private void ChooseLevelMethod(int level)
    {
        CurrentLevel.Level = level;
        SceneManager.LoadScene(1);
    }
}
