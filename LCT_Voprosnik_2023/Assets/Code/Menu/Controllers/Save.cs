using UnityEngine;
using System.IO;

public static class Save 
{
    private static SaveDataClass _saveDataClass;
    private static string _path = Application.persistentDataPath + "/JsonSaving.json";

    private static int _level;
    private static bool[] _collections;
    private static bool _music;
    private static bool _finish;

    public static int Level => _level;
    public static bool[] Collections => _collections;
    public static bool Music => _music;
    public static bool Finish => _finish;


    public static void SaveLevel(int level)
    {
        _level = level;
        _saveDataClass.Level = level;
        SaveClass();
    }

    public static void SaveCollection(int idCollection)
    {
        _collections[idCollection] = true;
        _saveDataClass.Collections = _collections;
        SaveClass();
    }

    public static void SaveMusic(bool music)
    {
        _music = music;
        _saveDataClass.Music = music;
        SaveClass();
    }

    public static void SaveFinish(bool finish)
    {
        _finish = finish;
        _saveDataClass.FinishGame = _finish;
        SaveClass();
    }

    public static void LoadData()
    {
        if (!File.Exists(_path))
        {
            _saveDataClass = new SaveDataClass()
            {
                Level = 0,
                Collections = new bool[10],
                Music = true
            };

            SaveClass();
        }
        _saveDataClass = JsonUtility.FromJson<SaveDataClass>(File.ReadAllText(_path));

        _level = _saveDataClass.Level;
        _collections = _saveDataClass.Collections;
        _music = _saveDataClass.Music;
        _finish = _saveDataClass.FinishGame;
    }

    public static void ResetData()
    {
        _saveDataClass = new SaveDataClass()
        {
            Level = 0,
            Collections = new bool[10],
            Music = true,
            FinishGame = false
        };

        SaveClass();
    }

    private static void SaveClass()
    {
        File.WriteAllText(_path, JsonUtility.ToJson(_saveDataClass));
    }
}
