/***************************************************************
 * Name:      BaseApp.cpp
 * Purpose:   Code for Application Class
 * Author:     ()
 * Created:   2020-01-20
 * Copyright:  ()
 * License:
 **************************************************************/

#include "BaseApp.h"

//(*AppHeaders
#include "{project_name}.h"
#include <wx/image.h>
//*)

IMPLEMENT_APP(BaseApp);

bool BaseApp::OnInit()
{
    //(*AppInitialize
    bool wxsOK = true;
    wxInitAllImageHandlers();
    if (wxsOK)
    {
        {frame_name} *Frame = new {frame_name}(0);
        Frame->Show();
        SetTopWindow(Frame);
    }
    //*)
    return wxsOK;
}
