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

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Xml;

using ArcGIS.Desktop.Metadata.Editor.Pages;

namespace $safeprojectname$.Pages
{
  /// <summary>
  /// Interaction logic for MTK_EX_GeographicDescription.xaml
  /// </summary>
  internal partial class MTK_EX_GeographicDescription : EditorPage
  {
    public MTK_EX_GeographicDescription()
    {
      InitializeComponent();
    }

    public override string DefaultValue
    {
      get
      {
        IEnumerable<XmlNode> data = GetXmlDataContext();
        if (null == data)
          return String.Empty;

        StringBuilder sb = new StringBuilder();
        foreach (XmlNode root in data)
        {
          // west
          XmlNode node = root.SelectSingleNode("GeoDesc/geoId/identCode");
          if (null != node && 0 < node.InnerText.Length)
          {
            sb.Append(node.InnerText);
          }

          break;
        }

        if (0 < sb.Length)
          return $safeprojectname$.Properties.Resources.LBL_EXTENTS_GEODESC + sb.ToString().Substring(0, 30) + "...";
        else
          return String.Empty; // Properties.Resources.LBL_EXTENTS_GEODESC_EMPTY;
      }
      set
      {
        // NOOP
      }
    }
  }
}