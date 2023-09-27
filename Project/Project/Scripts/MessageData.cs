using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supply_control_system;

namespace Supply_control_system.Scripts
{
    public class MessageData
    {
        private string _myRole;
        private string _firstName;
        private string _secondName;
        private Image _image;

        private MessageData() { }

        public string MyRole
        {
            get
            {
                return _myRole;
            }
        }

        public string FirstName 
        { 
            get 
            { 
                return _firstName; 
            } 
        }

        public string SecondName
        {
            get
            {
                return _secondName;
            }
        }
        public Image Image
        {
            get
            {
                return _image;
            }
        }

        static public Dictionary<Role, string> roleToString = new Dictionary<Role, string>() 
            { { Role.Admin, "Admin" }, 
            { Role.Manager, "Manager" }, 
            { Role.Logistician, "Logistician" }, 
            { Role.Client, "Client" } };

        static public MessageData GetData(Role role, string firstName, string secondName, string path)
        {
            MessageData data = new MessageData();
            data._myRole = roleToString[role];
            data._firstName = firstName;
            data._secondName = secondName;
            data._image = new Bitmap(path);
            return data;
        }
    }
}
