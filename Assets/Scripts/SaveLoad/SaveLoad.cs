using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace SaveLoad
{
    public static class SaveLoad
    {
        public static void Save<T>(T d) where T : Data
        {
            var bf = new BinaryFormatter();
            var stream = File.Create(Application.persistentDataPath + "/Data.data");
            var data = new DataClass();  
            data.PassClass(d);
            bf.Serialize(stream, data);
            stream.Close();
        }

        public static DataClass Load()
        {
            if (File.Exists(Application.persistentDataPath + "/Data.data"))
            {
                var bf = new BinaryFormatter();
                var stream = File.Open(Application.persistentDataPath + "/Data.data", FileMode.Open);
                var data = bf.Deserialize(stream) as DataClass;
                if (data == null)
                {
                    Debug.Log("Data is Null");
                }
                stream.Close();
                var ret = new DataClass(0,0);
                if (data != null)
                {
                    ret = data;
                }
                return ret;
            }
            else
            {
                var z = new DataClass(0,0);
                return z;
            }
        }
    
    }

    [Serializable]
    public class DataClass
    {
        public int Level;
        public float Health;
        public void PassClass<T>(T d) where T : Data
        {
        
            Level = d.level; 
            Health = d.health;
        }

        public DataClass(int level, float health)
        {
            Level = level; 
            Health = health;
        }
        public DataClass(){}

    }
}