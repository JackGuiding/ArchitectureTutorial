using System;
using UnityEngine;

namespace ArchiTutorial {

    // 打开/Tick/关闭
    public class UIApp {

        UIContext ctx;

        public Action Login_OnStartHandle;

        public UIApp() {
            ctx = new UIContext();
        }

        public void Inject(Canvas canvas, Panel_Login loginPrefab) {
            ctx.canvas = canvas;
            ctx.p_loginPrefab = loginPrefab;
        }

        public void Panel_Login_Open() {
            if (ctx.p_login == null) {
                Panel_Login panel = GameObject.Instantiate(ctx.p_loginPrefab, ctx.canvas.transform);
                panel.Ctor();

                // 低层访问高层, 但低层不需要知道高层的存在
                // 高层知道低层的存在
                panel.OnStartHandle = () => {
                    Login_OnStartHandle.Invoke();
                };

                ctx.p_login = panel;
            }
        }

        public void Panel_Login_Close() {
            if (ctx.p_login != null) {
                GameObject.Destroy(ctx.p_login.gameObject);
                ctx.p_login = null;
            }
        }

    }

}