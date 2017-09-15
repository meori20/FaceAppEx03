using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01_Logic
{
    public static class FaceBookInfoDisplayFactory
    {
        public static FaceBookInfoDisplay Create(string i_DataType, UserDataFacade i_UserData)
        {
            FaceBookInfoDisplay faceBookInfoDisplay = null;
            if (i_DataType == "Pages Info")
            {
                faceBookInfoDisplay = new PageInfoDisplay(i_UserData);
            }
            else if (i_DataType == "Events Info")
            {
                faceBookInfoDisplay = new EventsInfoDisplay(i_UserData);
            }

            return faceBookInfoDisplay;
        }
    }
}
