using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public partial  class Activity
    {
       public Activity ()
       { }
       private int _activityid;

       public int Activityid
       {
           get { return _activityid; }
           set { _activityid = value; }
       }
       private string _activityname;

       public string Activityname
       {
           get { return _activityname; }
           set { _activityname = value; }
       }
       private DateTime _endtime;

       public DateTime Endtime
       {
           get { return _endtime; }
           set { _endtime = value; }
       }
       private string _activitypicture;

       public string Activitypicture
       {
           get { return _activitypicture; }
           set { _activitypicture = value; }
       }
       private string _activityintroduction;

       public string Activityintroduction
       {
           get { return _activityintroduction; }
           set { _activityintroduction = value; }
       }
       private string _summary;

       public string Summary
       {
           get { return _summary; }
           set { _summary = value; }
       }
       private string _activityverify = "待审核";

       public string Activityverify
       {
           get { return _activityverify; }
           set { _activityverify = value; }
       }
       private string _activitystatus;

       public string Activitystatus
       {
           get { return _activitystatus; }
           set { _activitystatus = value; }
       }
       private string _username;

       public string Username
       {
           get { return _username; }
           set { _username = value; }
       }
       
    }
}
