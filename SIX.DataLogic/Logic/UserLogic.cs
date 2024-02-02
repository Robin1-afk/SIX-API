using SIX.DataENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIX.DataLogic.Logic
{
    public class UserLogic
    {
        public static UserLogic intance = new UserLogic();
        public List<UserMOD> GetUserMOD()
        {
            List<UserMOD> objectList = new  List<UserMOD>();
            using (var context = new ContextDB())
            {

                 objectList = context.UserMOD.ToList();
            }

            return objectList;

        }
    }
}
