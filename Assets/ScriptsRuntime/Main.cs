using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArchiTutorial {

    public class Main : MonoBehaviour {

        bool isTearDown;

        RoleRepository roleRepository;

        // 整个程序中只能有唯一的: Start/Update/LateUpdate
        void Awake() {

            Application.targetFrameRate = 15;

            isTearDown = false;

            roleRepository = new RoleRepository();

            // 想创建一个实体时, 找Factory
            RoleEntity role = GameFactory.Role_Spawn();
            roleRepository.Add(role);

            // 面向对象
            // Logger logger = new Logger();
            // logger.Log(); // object.function();

            // 面向过程
            // Logger.Log(logger); // function(object);

        }

        // Update is called once per frame
        void Update() {

            float dt = Time.deltaTime;

            roleRepository.Foreach(role => {
                RoleDomain.Move(role, Vector2.right, dt);
            });

        }

        void OnDrawGizmos() {
            Gizmos.color = Color.red;
            if (roleRepository != null) {
                roleRepository.Foreach(role => {
                    Gizmos.DrawWireSphere(role.position, 0.5f);
                });
            }
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
