namespace ArchiTutorial {

    public static class LoginBusiness {

        public static void Enter(GameContext ctx) {
            // 打开 Panel_Login
            ctx.uiApp.Panel_Login_Open();
        }

        public static void Tick(float dt) {

        }

        public static void Exit(GameContext ctx) {
            ctx.uiApp.Panel_Login_Close();
        }

        public static void TearDown() {

        }

    }
    
}