using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunInstallationFiles
{
    enum MessagesToShow
    {
        Success,
        Failure,
        AlreadyInstalled
    }

    static class MessagesToShowTextExtender
    {
        public static String AsText(this MessagesToShow messagesToShow)
        {
            switch (messagesToShow)
            {
                case MessagesToShow.Success: return "Application installed successsfully";
                case MessagesToShow.Failure: return "Some Problem in installing the application";
                case MessagesToShow.AlreadyInstalled:return "Application has alreay installed";
           }
            return "";
        }
    }

    class InstallationClass 
    {
        private string FilePath { get; set; }
        private string DisplayName { get; set; }

        public InstallationClass(string filePath, string displayName)
        {
            this.FilePath = filePath;
            this.DisplayName = displayName;
        }

        public string InstallPackage()
        {
            string extension = Path.GetExtension(this.FilePath).ToLower();
            string outputStatus = string.Empty;
            switch (extension)
            {
                case ".msi":
                    outputStatus = this.installApplication("msi", this.FilePath, this.DisplayName);
                    break;
                case ".exe":
                    outputStatus = this.installApplication("exe", this.FilePath, this.DisplayName);
                    break;
            };
            return outputStatus;
        }

        private string installApplication(string type, string filePath , string displayName)
        {
            if (!this.IsApplictionInstalled(this.DisplayName))
            {
                switch (type)
                {
                    case "msi":
                        InstallMSIOrExe.InstallMSi(this.FilePath);
                        break;
                    case "exe":
                        InstallMSIOrExe.InstallExe(this.FilePath);
                        break;
                }
                
                if (this.IsApplictionInstalled(this.DisplayName))
                {
                    return MessagesToShow.Success.AsText();
                }
                else
                {
                    return MessagesToShow.Failure.AsText();
                }
            }
            else
            {
                return MessagesToShow.AlreadyInstalled.AsText();
            }
        }

        private  bool IsApplictionInstalled(string p_name)
        {
            string keyName;

            // search in: CurrentUser
            keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            if (ExistsInSubKey(Registry.CurrentUser, keyName, "DisplayName", p_name) == true)
            {
                return true;
            }

            // search in: LocalMachine_32
            keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            if (ExistsInSubKey(Registry.LocalMachine, keyName, "DisplayName", p_name) == true)
            {
                return true;
            }

            // search in: LocalMachine_64
            keyName = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            if (ExistsInSubKey(Registry.LocalMachine, keyName, "DisplayName", p_name) == true)
            {
                return true;
            }

            return false;
        }

        private  bool ExistsInSubKey(RegistryKey p_root, string p_subKeyName, string p_attributeName, string p_name)
        {
            RegistryKey subkey;
            string displayName;

            using (RegistryKey key = p_root.OpenSubKey(p_subKeyName))
            {
                if (key != null)
                {
                    foreach (string kn in key.GetSubKeyNames())
                    {
                        using (subkey = key.OpenSubKey(kn))
                        {
                            displayName = subkey.GetValue(p_attributeName) as string;
                            if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

    }

    class InstallMSIOrExe
    {
        public static void InstallMSi(string FilePath)
        {
            Process process = new Process();
            process.StartInfo.FileName = "msiexec.exe";
            process.StartInfo.Arguments = string.Format(" /qb /i \"{0}\" ALLUSERS=1", FilePath);
            process.Start();
            process.WaitForExit();

            //while (installerProcess.HasExited == false)
            //{
            //    //indicate progress to user 
            //    Application.DoEvents(); System.Threading.Thread.Sleep(250);
            //}
        }

        public static void InstallExe(string filePath)
        {
            Process process = new Process();
            process.StartInfo.FileName = filePath;
            process.StartInfo.Arguments = "/VERYSILENT";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();
        }

        
    }
}
