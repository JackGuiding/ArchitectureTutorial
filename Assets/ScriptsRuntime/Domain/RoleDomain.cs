using UnityEngine;

namespace ArchiTutorial {

    // 角色 领域
    public static class RoleDomain {

        public static void Attack(RoleEntity role, RoleEntity target) {

        }

        public static void Move(RoleEntity role, Vector2 moveDir, float dt) {
            role.Move(moveDir, dt);
        }

    }
}