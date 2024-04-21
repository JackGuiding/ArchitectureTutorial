using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArchiTutorial {

    public class Main : MonoBehaviour {

        bool isTearDown;

        // 整个程序中只能有唯一的: Start/Update/LateUpdate
        void Awake() {
            isTearDown = false;
        }

        // Update is called once per frame
        void Update() {

        }

        void LateUpdate() {

        }

        // Android / iOS
        void OnApplicationQuit() {
            TearDown();
        }

        // Win / Mac / Linux
        void OnDestroy() {
            TearDown();
        }

        void TearDown() {
            if (isTearDown) {
                return;
            }
            isTearDown = true;

            // 释放资源
        }

    }
}
