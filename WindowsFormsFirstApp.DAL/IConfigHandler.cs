using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsFirstApp.Model;

namespace WindowsFormsFirstApp.DAL
{
     public interface IConfigHandler
    {
        void AddQaUserToJson(QaUser qaUser);
        QaUser GetQaUser();
    }
}
