using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class TestAddressablesLoadUnload : MonoBehaviour
{
    private GameObject _mMyGameObject;

    public void InstantiateGameobjectUsingAssetReference(string key)
    {
        Addressables.InstantiateAsync(key).Completed += OnLoadDone;
    }

    private void OnLoadDone(AsyncOperationHandle<GameObject> obj)
    {
        _mMyGameObject = obj.Result;
    }

    public void ReleaseGameobjectUsingAssetReference()
    {
        Addressables.Release(_mMyGameObject);
    }
}
