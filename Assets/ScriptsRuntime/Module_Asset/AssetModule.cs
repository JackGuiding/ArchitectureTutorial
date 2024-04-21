using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace ArchiTutorial {

    // 资源管理: 对文件进行管理
    // 通常处理IO(从硬盘/网络加载资源)

    // 资源包括:
    // 实体的prefab/UI的prefab
    // Texture/AudioClip/VideoClip
    public class AssetModule {

        AsyncOperationHandle uiOp;
        Dictionary<string, GameObject> uiDict;

        // 1. 拖拽式加载
        // 2. 标记式加载, 好用的插件: Addressables

        public AssetModule() {
            uiDict = new Dictionary<string, GameObject>();
        }

        public void LoadAll() {
            {
                AssetLabelReference labelReference = new AssetLabelReference();
                labelReference.labelString = "UI"; // 标签

                // 指针, 非托管内存
                var op = Addressables.LoadAssetsAsync<GameObject>(labelReference, null);
                var list = op.WaitForCompletion();
                for (int i = 0; i < list.Count; i++) {
                    var go = list[i];
                    uiDict.Add(go.name, go);
                }
                uiOp = op;
                Debug.Log("AssetModule.LoadAll: UI");
            }
        }

        public void UnloadAll() {
            if (uiOp.IsValid()) {
                Addressables.Release(uiOp);
            }
        }

        public bool UI_TryGet(string name, out GameObject prefab) {
            return uiDict.TryGetValue(name, out prefab);
        }

    }

}