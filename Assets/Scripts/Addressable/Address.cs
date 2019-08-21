using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Addressable
{
    public class Address : MonoBehaviour
    {
        public AssetReference Ship;
        private GameObject _s;
        [SerializeField] private Transform pos;

        private void Start()
        {
            Ship.LoadAssetAsync<GameObject>().Completed += OnLoadDone;
            if (_s != null)
            {
                Instantiate(_s, pos.position, pos.rotation);
            }
            else
            {
                Debug.Log("Null");
            }
        }


        private void OnLoadDone(AsyncOperationHandle<GameObject> obj)
        {
            Debug.Log(obj.Status);
            _s = obj.Result;
            //Instantiate(obj.Result, pos.position, pos.rotation);
        }

    }
}



