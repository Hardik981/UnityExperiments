using UnityEngine;

namespace SaveLoad
{
    public class Data : MonoBehaviour
    {
        public int level;
        public float health;

        private void Start()
        {
            Save();
            Load();
            Debug.Log(Application.persistentDataPath);
        }

        private void Save()
        {
            SaveLoad.Save(this);
        }

        private static void Load()
        {
            var loadedStats = SaveLoad.Load();
            Debug.Log("Levels : " + loadedStats.level);
            Debug.Log("Health : " + loadedStats.health);
        }

    }
}
