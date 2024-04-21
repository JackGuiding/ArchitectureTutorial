namespace ArchiTutorial {

    // 上下文
    // : 存放所有数据
    public class GameContext {

        public RoleRepository roleRepository;

        public GameContext() {
            roleRepository = new RoleRepository();
        }

    }

}