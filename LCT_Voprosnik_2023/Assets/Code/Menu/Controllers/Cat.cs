public class Cat 
{
    public CatView _catView;

    public Cat(CatView catView)
    {
        _catView = catView;
    }

    public void Awake()
    {
        foreach(var button in _catView.CatButtons)
        {
            button.onClick.AddListener(Mew);
        }
    }

    private void Mew()
    {
        _catView.CatSound.Play();
    }
}
