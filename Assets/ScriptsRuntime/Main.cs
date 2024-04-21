using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArchiTutorial {

    public class Main : MonoBehaviour {

        GameContext ctx;

        bool isTearDown;

        // 整个程序中只能有唯一的: Start/Update/LateUpdate
        void Awake() {

            ctx = new GameContext();

            Application.targetFrameRate = 15;

            isTearDown = false;

            // 想创建一个实体时, 找Factory
            // RoleEntity role = GameFactory.Role_Spawn();
            // roleRepository.Add(role);

            // 面向对象
            // Logger logger = new Logger();
            // logger.Log(); // object.function();

            // 面向过程
            // Logger.Log(logger); // function(object);

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
        }

    }
}
