using UnityEngine.SceneManagement;

public class Lose 
{
    private LoseView _loseView;

    public Lose(LoseView loseView)
    {
        _loseView = loseView;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {
        _loseView.RetryButton.onClick.AddListener(RetryButton);
        _loseView.ExitButton.onClick.AddListener(ExitButton);
    }

    private void ExitButton()
    {
        SceneManager.LoadScene(0);
    }

    private void RetryButton()
    {
        SceneManager.LoadScene(1);
    }
}
