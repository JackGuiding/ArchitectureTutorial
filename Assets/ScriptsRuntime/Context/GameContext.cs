namespace ArchiTutorial {

    // 上下文
    // : 存放所有数据
    public class GameContext {

        public RoleRepository roleRepository;

        public UIApp uiApp;
        public AssetModule assetModule;

        public GameContext() {
            roleRepository = new RoleRepository();
        }

        public void Inject(UIApp uiApp, AssetModule assetModule) {
            this.uiApp = uiApp;
            this.assetModule = assetModule;
        }

    }

}