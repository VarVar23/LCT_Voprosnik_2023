using UnityEngine;

public class ActivationWindows 
{
    private ButtonsView _buttonsView;
    private WindowsView _windowsView;
    private GameObject _activeWindow;

    public ActivationWindows(ButtonsView buttonsView, WindowsView windowsView)
    {
        _buttonsView = buttonsView;
        _windowsView = windowsView;
    }

    public void Awake() => AddListeners();

    private void AddListeners()
    {
        _buttonsView.ExitButton.onClick.AddListener(Exit);
        _buttonsView.PlayButton.onClick.AddListener(() => ActivateWindow(_windowsView.PlayWindow));
        _buttonsView.AuthorsButton.onClick.AddListener(() => ActivateWindow(_windowsView.AuthorsWindow));
        _buttonsView.TutorialButton.onClick.AddListener(() => ActivateWindow(_windowsView.TutorialWindow));

        foreach(var backButton in _buttonsView.BackButtons)
        {
            backButton.onClick.AddListener(DeactivateWindow);
        }
    }

    private void ActivateWindow(GameObject window)
    {
        _windowsView.MenuWindow.SetActive(false);
        window.SetActive(true);
        _activeWindow = window;
    }

    private void DeactivateWindow()
    {
        _windowsView.MenuWindow.SetActive(true);
        _activeWindow.SetActive(false);
    }

    private void Exit()
    {
        Application.Quit();
    }
}
