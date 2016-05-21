using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public partial  class Image
    {
       public Image ()
       { }
       private int _imgid;

       public int Imgid
       {
           get { return _imgid; }
           set { _imgid = value; }
       }
       private string _imgurl;

       public string Imgurl
       {
           get { return _imgurl; }
           set { _imgurl = value; }
       }
       private string _imgtext;

       public string Imgtext
       {
           get { return _imgtext; }
           set { _imgtext = value; }
       }
       private string _imglink;

       public string Imglink
       {
           get { return _imglink; }
           set { _imglink = value; }
       }
       private string _imgalt;

       public string Imgalt
       {
           get { return _imgalt; }
           set { _imgalt = value; }
       }

    }
}
