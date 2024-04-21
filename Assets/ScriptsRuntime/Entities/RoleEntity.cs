using UnityEngine;

namespace ArchiTutorial {

    // Model 数据模型
    // 数据建模: 设计字段和方法, 除了程序员之外也通用
    // 角色
    public class RoleEntity {

        // 字段
        public int id;
        public string roleName;

        public int hp;
        public int hpMax;

        public float moveSpeed;
        public Vector2 position;

        public GameContext ctx;

        public RoleEntity() {

        }

        // 方法
        public void Move(Vector2 dir, float dt) {
            // 移动
            position += dir * moveSpeed * dt;
        }

        public void Jump() {

        }

    }

}