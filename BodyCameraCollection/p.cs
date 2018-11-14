using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Edward;

namespace BodyCameraCollection
{
    class p
    {

        public static string AppFolder = Application.StartupPath + @"\" + Application.ProductName;
        public static string SysIni = AppFolder + @"\SysConfig.ini";
        public static string AppTitle = "成都恒安执法数据管理平台";
        public static int BodyRow = 4;
        public static int BodyColumn = 5;
        public static bool CheckPwd = false;


        public static void CreateIni()
        {
            if (!File.Exists(SysIni))
            {
                IniFile.CreateIniFile(SysIni);
                IniFile.iniFilePathValue = SysIni;
                IniFile.IniWriteValue("SysConfig", "AppTitle", AppTitle);
                IniFile.IniWriteValue("SysConfig", "AppVer:", Application.ProductVersion);
                IniFile.IniWriteValue("SysConfig", "Row", BodyRow.ToString ());
                IniFile.IniWriteValue("SysConfig", "Column", BodyColumn.ToString());
            }

        }

        public static void ReadIni()
        {
            IniFile.iniFilePathValue = SysIni;
            if (File.Exists(SysIni))
            {
                AppTitle = IniFile.IniReadValue("SysConfig", "AppTitle");
                try
                {
                    BodyRow = Convert.ToInt16(IniFile.IniReadValue("SysConfig", "Row"));
                }
                catch (Exception)
                {
                    BodyRow = 4;
                }
                try
                {
                    BodyColumn  = Convert.ToInt16(IniFile.IniReadValue("SysConfig", "Column"));
                }
                catch (Exception)
                {
                    BodyColumn  = 5;

                }
            }

        }

        public static void CheckFolder()
        {
            if (!Directory.Exists(AppFolder))
            {
                Directory.CreateDirectory(AppFolder);
            }
        }

    }
}
