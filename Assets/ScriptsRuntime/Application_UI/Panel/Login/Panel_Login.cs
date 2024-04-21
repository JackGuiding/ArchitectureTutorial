using System;
using UnityEngine;
using UnityEngine.UI;

namespace ArchiTutorial {

    public class Panel_Login : MonoBehaviour {

        [SerializeField] Button startBtn;

        public Action OnStartHandle;

        public void Ctor() {
            startBtn.onClick.AddListener(() => {
                OnStartHandle.Invoke();
            });
        }

    }

}