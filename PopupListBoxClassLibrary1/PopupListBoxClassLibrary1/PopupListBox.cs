using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupListBoxClassLibrary1
{
    public class PopupListBox
    {
        private string pixellength;
        public string PixelLength
        {
            get { return pixellength; }
            set
            {
                pixellength = value;
            }
        }
        private string smodetext;
        public string SModeText
        {
            get { return smodetext; }
            set
            {
                smodetext = value;

            }
        }
        private string imagedefaultimagepath;
        public string ImageDefaultImagePath
        {
            get { return imagedefaultimagepath; }
            set
            {
                imagedefaultimagepath = value;
            }
        }
        private string imageselectedimagepath;
        public string ImageSelectedImagePath
        {
            get { return imageselectedimagepath; }
            set
            {
                imageselectedimagepath = value;
            }
        }
    }
}
