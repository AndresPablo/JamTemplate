using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveData  {

    public static InfoContainer infoContainer = new InfoContainer();

    public delegate void SerializeAction();
    public static event SerializeAction OnLoaded;
    public static event SerializeAction OnBeforeSave;

    public static void Load(string path)
    {
        infoContainer = LoadInfo(path);

        GameManager.Instance.data = infoContainer.gameData;

        OnLoaded();
        ClearInfo();
    }

    public static void Save(string path, InfoContainer infoContainer)
    {
        OnBeforeSave();

        SaveGame(path, infoContainer);

        ClearInfo();
    }


    public static void AddGameManagerData(GameData data)
    {
        infoContainer.gameData = data;
    }



    public static void ClearInfo()
    {
        infoContainer.gameData = null;
    }

    public static InfoContainer LoadInfo(string path)
    {
        string json = File.ReadAllText(path);

        return JsonUtility.FromJson<InfoContainer>(json);
    }

    public static void SaveGame(string path, InfoContainer info)
    {
        string json = JsonUtility.ToJson(info);

        StreamWriter sw = File.CreateText(path);
        sw.Close();

        File.WriteAllText(path, json);

    }
