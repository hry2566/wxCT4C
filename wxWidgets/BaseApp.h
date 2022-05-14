/***************************************************************
 * Name:      BaseApp.h
 * Purpose:   Defines Application Class
 * Author:     ()
 * Created:   2020-01-20
 * Copyright:  ()
 * License:
 **************************************************************/

#ifndef FRAME_BASEAPP_H
#define FRAME_BASEAPP_H

#include <wx/app.h>

class BaseApp : public wxApp
{
public:
    virtual bool OnInit();
};

#endif // FRAME_BASEAPP_H
