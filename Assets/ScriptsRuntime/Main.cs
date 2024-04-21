using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArchiTutorial {

    // 登录~进入游戏前: 登录业务(Login/Lobby)
    // 游戏内: 游戏业务
    public class Main : MonoBehaviour {

        [SerializeField] Canvas canvas;

        UIApp uiApp;
        AssetModule assetModule;
        GameContext ctx;

        bool isTearDown;

        // 整个程序中只能有唯一的: Start/Update/LateUpdate
        void Awake() {

            isTearDown = false;

            // ==== Instantiate ====
            ctx = new GameContext();
            uiApp = new UIApp();
            assetModule = new AssetModule();

            // ==== Inject ====
            ctx.Inject(uiApp, assetModule);
            uiApp.Inject(canvas, assetModule);

            // ==== Init ====
            assetModule.LoadAll();

            // ==== Binding Event ====
            BindineEvent();

            // ==== Enter ====
            LoginBusiness.Enter(ctx);

        }

        void BindineEvent() {
            uiApp.Login_OnStartHandle = () => {
                // 登录
                LoginBusiness.Exit(ctx);
                GameBusiness.Enter(ctx);
            };
        }

        // Update is called once per frame
        void Update() {

            float dt = Time.deltaTime;

            RoleController.Tick(ctx, dt);

            // 控制: 控制哪个角色移动
            // 行为: 角色移动

        }

        void OnDrawGizmos() {
            RoleController.DrawGizmos(ctx);
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
            assetModule.UnloadAll();
            LoginBusiness.TearDown();
            GameBusiness.TearDown();
        }

    }
}
