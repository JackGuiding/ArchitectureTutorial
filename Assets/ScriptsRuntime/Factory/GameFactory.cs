namespace ArchiTutorial {

    public static class GameFactory {

        // 创建实体
        public static RoleEntity Role_Spawn() {
            RoleEntity role = new RoleEntity();
            role.id = 1;
            role.hp = 1;
            role.hpMax = 1;

            role.moveSpeed = 5.5f;
            return role;
        }

    }

}