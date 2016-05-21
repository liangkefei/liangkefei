using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public partial  class UserInfo
    {
       public UserInfo ()
       { }
    
       private string _username;

       public string Username
       {
           get { return _username; }
           set { _username = value; }
       }
       private string _password;

       public string Password
       {
           get { return _password; }
           set { _password = value; }
       }
       private string _qq;

       public string Qq
       {
           get { return _qq; }
           set { _qq = value; }
       }
       private string _email;

       public string Email
       {
           get { return _email; }
           set { _email = value; }
       }
       private string _type = "普通用户";

       public string Type
       {
           get { return _type; }
           set { _type = value; }
       }
       private string _userimg;

       public string Userimg
       {
           get { return _userimg; }
           set { _userimg = value; }
       }
    }
}
