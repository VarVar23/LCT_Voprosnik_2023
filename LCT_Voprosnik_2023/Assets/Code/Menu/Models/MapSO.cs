using UnityEngine;

[CreateAssetMenu(fileName = "MapSO", menuName = "Config/MapSO", order = 0)]
public class MapSO : ScriptableObject
{
    [SerializeField] private float _minScale;
    [SerializeField] private float _maxScale;
    [SerializeField] private float _defaultScale;
    [SerializeField] private float _step;

    public float MinScale => _minScale;
    public float MaxScale => _maxScale;
    public float DefaultScale => _defaultScale;
    public float Step => _step; 
}
