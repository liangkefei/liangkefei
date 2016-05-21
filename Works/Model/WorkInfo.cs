using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public partial  class WorkInfo
    {
        // WorkInfo:实体类(属性说明自动提取数据库字段的描述信息)
        public WorkInfo()
        { }
        #region Model
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
        private string _workpicture;

        public string Workpicture
        {
            get { return _workpicture; }
            set { _workpicture = value; }
        }
        private DateTime _uploadtime;

        public DateTime Uploadtime
        {
            get { return _uploadtime; }
            set { _uploadtime = value; }
        }
        private string _workintroduction;

        public string Workintroduction
        {
            get { return _workintroduction; }
            set { _workintroduction = value; }
        }
        private string _workverify = "待审核";

        public string Workverify
        {
            get { return _workverify; }
            set { _workverify = value; }
        }
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _activityname;

        public string Activityname
        {
            get { return _activityname; }
            set { _activityname = value; }
        }
        private string _recommend = "否";

        public string Recommend
        {
            get { return _recommend; }
            set { _recommend = value; }
        }
        private DateTime? _recommendtime;

        public DateTime? Recommendtime
        {
            get { return _recommendtime; }
            set { _recommendtime = value; }
        }

        #endregion Model
    }
}
