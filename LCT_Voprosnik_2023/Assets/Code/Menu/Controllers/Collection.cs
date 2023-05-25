using UnityEngine.UI;

public class Collection 
{
    private CollectionView _collectionView;
    private ButtonsView _buttonsView;
    private CollectionSO _collectionSO;

    public Collection(CollectionView collectionView, ButtonsView buttonsView, CollectionSO collectionSO)
    {
        _collectionView = collectionView;
        _buttonsView = buttonsView;
        _collectionSO = collectionSO;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {
        _collectionView.BackCollectionButton.onClick.AddListener(OpenCollection);

        for(int i = 0; i < Save.Collections.Length; i++)
        {
            int j = i;

            _collectionView.CollectionButtons[i].enabled = false;
            _collectionView.CollectionButtons[i].onClick.AddListener(() => OpenCollectionCartWindow(j));

            if (Save.Collections[i])
            {
                _collectionView.CollectionButtons[i].GetComponent<Image>().sprite = _collectionSO.SpritesCart2DCollection[i];
                _collectionView.CollectionButtons[i].enabled = true;
            }
        }
    }

    private void OpenCollectionCartWindow(int idButton)
    {
        for(int i = 0; i < Save.Collections.Length; i++)
        {
            _collectionView.CollectionButtons[i].gameObject.SetActive(false);
        }
        _collectionView.CartCollection3D.sprite = _collectionSO.SpritesCart3DCollection[idButton];
        _collectionView.BackMenuButton.gameObject.SetActive(false);
        _collectionView.OpenCartWindow.gameObject.SetActive(true);
    }

    private void OpenCollection()
    {
        for (int i = 0; i < Save.Collections.Length; i++)
        {
            _collectionView.CollectionButtons[i].gameObject.SetActive(true);
        }

        _collectionView.BackMenuButton.gameObject.SetActive(true);
        _collectionView.OpenCartWindow.gameObject.SetActive(false);
    }
}
