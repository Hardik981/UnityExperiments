using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.Serialization;

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
                stream.Close();
                var ret = new DataClass(0,0);
                if (data != null)
                {
                    ret = data;
                }
                else
                {
                    Debug.Log("Data is Null");
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
        public int level;
        public float health;
        public void PassClass<T>(T d) where T : Data
        {
        
            level = d.level; 
            health = d.health;
        }

        public DataClass(int level, float health)
        {
            this.level = level; 
            this.health = health;
        }
        public DataClass(){}

    }
}