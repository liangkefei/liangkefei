using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public partial  class Comment
    {
       public Comment ()
       { }
       private int _commentid;

       public int Commentid
       {
           get { return _commentid; }
           set { _commentid = value; }
       }
       private int _workid;

       public int Workid
       {
           get { return _workid; }
           set { _workid = value; }
       }
       private string _workname;

       public string Workname
       {
           get { return _workname; }
           set { _workname = value; }
       }
       private string _username;

       public string Username
       {
           get { return _username; }
           set { _username = value; }
       }
       private string _commentcontent;

       public string Commentcontent
       {
           get { return _commentcontent; }
           set { _commentcontent = value; }
       }
       private DateTime _commenttime;

       public DateTime Commenttime
       {
           get { return _commenttime; }
           set { _commenttime = value; }
       }
    }
}
