using UnityEngine;

public class MapLevels 
{
    private PlayWindowView _playWindowView;
    private MapSO _mapSO;

    public MapLevels(PlayWindowView playWindowView, MapSO mapSO)
    {
        _playWindowView = playWindowView;
        _mapSO = mapSO;
    }

    public void Awake()
    {
        Initialize();

        var defaultVector = new Vector3(_mapSO.DefaultScale, _mapSO.DefaultScale, _mapSO.DefaultScale);
        _playWindowView.Content.transform.localScale = defaultVector;
    }

    private void Initialize()
    {
        _playWindowView.PlusButton.onClick.AddListener(() => ChangeScale(true));
        _playWindowView.MinusButton.onClick.AddListener(() => ChangeScale(false));
 
        Debug.Log(Save.Level);
        for(int i = 0; i <= Save.Level; i++)
        {
            _playWindowView.LevelButtons[i].gameObject.SetActive(true);
        }
    }

    private void ChangeScale(bool plus)
    {
        Vector3 content = _playWindowView.Content.transform.localScale;
        float minScale = _mapSO.MinScale;
        float maxScale = _mapSO.MaxScale;
        float step = _mapSO.Step;

        _playWindowView.PlusButton.enabled = true;
        _playWindowView.MinusButton.enabled = true;


        if (plus)
        {
            content = new Vector3(content.x + step, content.y + step, content.z + step);

            if(content.x >= maxScale)
            {
                _playWindowView.PlusButton.enabled = false;
                content = new Vector3(maxScale, maxScale, maxScale);
            }
        }
        else
        {
            content = new Vector3(content.x - step, content.y - step, content.z - step);

            if (content.x <= minScale)
            {
                _playWindowView.MinusButton.enabled = false;
                content = new Vector3(minScale, minScale, minScale);
            }
        }


        _playWindowView.Content.transform.localScale = content;
    }
}
