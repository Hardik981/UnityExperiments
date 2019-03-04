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
            global::SaveLoad.SaveLoad.Save(this);
        }

        private void Load()
        {
            var loadedStats = global::SaveLoad.SaveLoad.Load();
            Debug.Log("Levels : " + loadedStats.Level);
            Debug.Log("Health : " + loadedStats.Health);
        }

    }
}
