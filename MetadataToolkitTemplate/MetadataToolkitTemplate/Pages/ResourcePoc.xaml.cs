﻿/*
COPYRIGHT 1995-2009 ESRI
TRADE SECRETS: ESRI PROPRIETARY AND CONFIDENTIAL
Unpublished material - all rights reserved under the 
Copyright Laws of the United States.
For additional information, contact:
Environmental Systems Research Institute, Inc.
Attn: Contracts Dept
380 New York Street
Redlands, California, USA 92373
email: contracts@esri.com
*/

using ArcGIS.Desktop.Metadata;
using ArcGIS.Desktop.Metadata.Editor.Pages;

namespace $safeprojectname$.Pages
{
  internal class ResourcePocSidebarLabel : ISidebarLabel
  {
    string ISidebarLabel.SidebarLabel
    {
      get { return ResourcePocSidebarLabel.SidebarLabel; }
    }

    public static string SidebarLabel
    {
      get { return $safeprojectname$.Properties.Resources.CFG_LBL_RESOURCEPOC; }
    }
  }
  /// <summary>
  /// Interaction logic for MTK_ResourcePoc.xaml
  /// </summary>
  internal partial class MTK_ResourcePoc : EditorPage
  {
    public MTK_ResourcePoc()
    {
      InitializeComponent();
    }

    public override string SidebarLabel
    {
      get { return ResourcePocSidebarLabel.SidebarLabel; }
    }
  }
}
