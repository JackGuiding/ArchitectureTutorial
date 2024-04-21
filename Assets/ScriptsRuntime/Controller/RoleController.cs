using UnityEngine;

namespace ArchiTutorial {

    // 控制逻辑
    // 调用 -> Domain
    public static class RoleController {

        // RoleRepository
        public static void Tick(GameContext ctx, float dt) {
            ctx.roleRepository.Foreach(role => {
                RoleDomain.Move(role, Vector2.right, dt);
            });
        }

        public static void DrawGizmos(GameContext ctx) {
            Gizmos.color = Color.red;
            if (ctx != null && ctx.roleRepository != null) {
                ctx.roleRepository.Foreach(role => {
                    Gizmos.DrawWireSphere(role.position, 0.5f);
                });
            }
        }

    }

}