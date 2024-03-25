using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class DataControl : MonoBehaviour
{
    private TestScript testScript;
    private void Awake()
    {
        testScript = GameObject.FindObjectOfType<TestScript>();
    }

    public void Save(string fileName)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/" + fileName + ".dat");

        PlayerData playerData = new PlayerData();
        playerData.health = testScript.playerHealth;
        playerData.experience = testScript.playerExperience;
        
        bf.Serialize(file, playerData);
        file.Close();
    }

    public void Load(string fileName)
    {
        if (File.Exists(Application.persistentDataPath + "/" + fileName + ".dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/" + fileName + ".dat", FileMode.Open);
            PlayerData playerData = (PlayerData)bf.Deserialize(file);
            file.Close();
            testScript.playerHealth = playerData.health;
            testScript.playerExperience = playerData.experience;
        }
    }
}

//Create your [Serializable] class here(or somewhere else) and create your variables to store in a file. It's just a data container
//Example: PlayerData class that stores _health and _experience variables
[Serializable]
class PlayerData
{
    public float health = 100f;
    public float experience = 0f;
}