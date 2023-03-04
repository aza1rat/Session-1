using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOO_Sportivnye_Tovary.Entities;

namespace OOO_Sportivnye_Tovary.Classes
{
    public static class Helper
    {
        public static ModelDB ModelDB = new ModelDB();
        public enum Role { Администратор, Менеджер, Клиент};
        public static User User;
        public static Role UserRole;
        public static void GetRole(string role)
        {
            UserRole = (Role)Enum.Parse(UserRole.GetType(), role);
        }
    }
}
