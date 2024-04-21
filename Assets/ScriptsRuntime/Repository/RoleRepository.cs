using System;
using System.Collections.Generic;

namespace ArchiTutorial {

    // 角色 仓库
    // 增删改查(CRUD)
    public class RoleRepository {

        Dictionary<int, RoleEntity> all;

        public RoleRepository() {
            all = new Dictionary<int, RoleEntity>();
        }

        // 添加
        public void Add(RoleEntity role) {
            all.Add(role.id, role);
        }

        // 移除
        public void Remove(RoleEntity role) {
            all.Remove(role.id);
        }

        // 找单个
        public bool TryGet(int id, out RoleEntity role) {
            return all.TryGetValue(id, out role);
        }

        // 遍历
        public void Foreach(Action<RoleEntity> action) {
            foreach (var role in all.Values) {
                action.Invoke(role);
            }
        }

    }

}