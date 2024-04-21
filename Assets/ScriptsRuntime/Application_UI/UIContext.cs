using UnityEngine;

namespace ArchiTutorial {

    public class UIContext {

        public Canvas canvas;
        public AssetModule assetModule;

        public Panel_Login p_login;

        public UIContext() { }

        public void Inject(Canvas canvas, AssetModule assetModule) {
            this.canvas = canvas;
            this.assetModule = assetModule;
        }

    }
}