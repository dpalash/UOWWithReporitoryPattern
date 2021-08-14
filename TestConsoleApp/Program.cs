using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using TestConsoleApp.ServiceReferenceUKHO;
using UOWWithReporitoryPattern;
using UOWWithReporitoryPattern.DBFirst;
using UOWWithReporitoryPattern.Voyage;

namespace TestConsoleApp
{
    class Program
    {
        private static OrderingServiceClient _ukhoOrderServiceClient;
        private static OrderingServiceClient UkhoOrderServiceClient
        {
            get
            {
                if (_ukhoOrderServiceClient == null || _ukhoOrderServiceClient.State == CommunicationState.Faulted)
                    _ukhoOrderServiceClient = CreateOrderServiceClient();

                return _ukhoOrderServiceClient;
            }
        }

        private static OrderingServiceClient CreateOrderServiceClient()
        {
            if (string.IsNullOrEmpty("https://extenavigator.ukho.gov.uk/serviceB2B/submitUKHOOrdering.svc"))
            {
                throw new InvalidOperationException("Unable to create order service client. ServiceEndpointAddress is missing.");
            }

            var binding = new WSHttpBinding { MaxReceivedMessageSize = 16553600 };

            binding.Security = new WSHttpSecurity
            {
                Mode = SecurityMode.TransportWithMessageCredential,
                Transport = new HttpTransportSecurity
                {
                    ClientCredentialType = HttpClientCredentialType.None
                },
                Message = new NonDualMessageSecurityOverHttp
                {
                    ClientCredentialType = MessageCredentialType.UserName
                }
            };

            var endpointAdress = new EndpointAddress("https://extenavigator.ukho.gov.uk/serviceB2B/submitUKHOOrdering.svc");

            var client = new OrderingServiceClient(binding, endpointAdress);
            client.ClientCredentials.UserName.UserName = "B2BNautisk";
            client.ClientCredentials.UserName.Password = "Wa3EBgwO";

            return client;
        }

        private static void DisposeOrderServiceClientGracefully()
        {
            try
            {
                if (UkhoOrderServiceClient.State == CommunicationState.Faulted)
                {
                    UkhoOrderServiceClient.Abort();
                }
                else
                {
                    UkhoOrderServiceClient.Close();
                }
            }
            finally
            {
                _ukhoOrderServiceClient = null;
            }
        }

        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }

        public static void CopyStream(Stream stream, string destPath)
        {
            using (var fileStream = new FileStream(destPath, FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }
        }

        static void Main(string[] args)
        {
            string startPath = @"C:\Nautisk\FileUpload";
            string zipPath = @"C:\Nautisk\result.zip";
            string extractPath = @"c:\example\extract";

            ZipFile.CreateFromDirectory(startPath, zipPath);



            using (TextReader reader = new StringReader(File.ReadAllText(@"C:\Users\cefalo\Documents\FileUpload\Route_20180119_113334_932830.xml")))
            {
                try
                {
                    var voyageObject = (Voyage)new XmlSerializer(typeof(Voyage)).Deserialize(reader);
                }
                catch (InvalidOperationException ex)
                {
                    throw;
                }
            }

            var destinationDirectory = @"C:\Users\cefalo\Documents\20180117112345\";
            var reservePermitDirectory = Directory.GetDirectories(destinationDirectory, "reserve", SearchOption.AllDirectories).FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(reservePermitDirectory))
            {
                string destinationFolderName = reservePermitDirectory.Replace("reserve", "reserve1").Replace("RESERVE", "RESERVE1");
                Directory.Move(reservePermitDirectory, destinationFolderName);
            }

            using (var context = new neptuneEntities())
            {

                //var variable = new Variable { C_Variable = "NullValueCheck", C_Value = "null-value" };
                //context.Variables.Add(variable);
                //context.SaveChanges();
            }

            using (var context = new neptuneEntities())
            {
                // var x = context.Variables.ToList();
            }

            string datetime = "21‎-10-‎14";
            datetime = Regex.Replace(datetime, @"[^\u0000-\u007F]", string.Empty);

            string[] formats = {"dd-MM-yyyy hh:mm:ss",
                   "dd MMM yyyy hh:mm:ss",
                   "dd MMM yyyy",
                   "hh-mm-ss",
                   "dd-MM-yyyy",
                   "dd-MM-yy",
                  };

            DateTime result;
            if (DateTime.TryParseExact(datetime, formats, CultureInfo.CurrentCulture, DateTimeStyles.None, out result))
            {
                var x = 10;

            }

            DateTime dateTime;
            if (DateTime.TryParseExact(datetime, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime)
                || DateTime.TryParseExact(datetime, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime)
                || DateTime.TryParseExact(datetime, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            {
                var x = 10;
            }

            string dateTimeString = "21‎-‎10‎-‎2014‎";
            dateTimeString = Regex.Replace(dateTimeString, @"[^\u0000-\u007F]", string.Empty);

            string inputFormat = "dd-MM-yyyy";
            string outputFormat = "yyyy-MM-dd";
            dateTime = DateTime.ParseExact(dateTimeString, inputFormat, CultureInfo.InvariantCulture);
            string output = dateTime.ToString(outputFormat);

            Console.WriteLine(output);

            //string datetime = "18-12-2017";
            //DateTime dateTime;
            DateTime.TryParseExact(datetime.Replace('-', '/'), "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);

            AddKeyToRegistry();
            System.Diagnostics.Process.Start("net.exe", @"use Z: \\sfneptuneclassic.file.core.windows.net\demo /u:AZURE\sfneptuneclassic yyZOgITAecU0ANRZGnnQ/u96PUZBqRY3v/FPo19Xg/blbRCtRYwSxaGwbkQXZcByDZlstKPSgvb69K4NKJCS1w==");
            //System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            //psi.FileName = "C:\\application.exe";
            //psi.WorkingDirectory = "K:\\working\\directory";
            //psi.WindowStyle = System.Diagnostics.
            //ProcessWindowStyle.Maximized;
            //System.Diagnostics.Process p =
            //System.Diagnostics.Process.Start(psi);

            Utility.NetworkDrive.MapNetworkDrive("Z", @" \\sfneptuneclassic.file.core.windows.net\demo");
            var dirs = Directory.GetDirectories("Z:"); // got many nice directories...

            string packageKey = "";
            string packagePath = Path.Combine(@"Z:\", packageKey);

            Directory.CreateDirectory(packagePath);


            string sourcePath = @"E:\Weather\ENC";
            string targetPath = @"Z:\ENC";
            string fileName = string.Empty;
            string destFile = string.Empty;

            // To copy all the files in one directory to another directory. 
            // Get the files in the source folder. (To recursively iterate through 
            // all subfolders under the current directory, see 
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously 
            //       in this code example. 
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist. 
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    CopyStream(fs, destFile);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }


            //var xxx = UkhoOrderServiceClient.SubmitOrder(null);
            //ExampleClass exc = new ExampleClass();
            //exc.UnitOfWorkWithRepositoryPattern();
            var xx = Directory.Exists(@"Z:");
            var xxx = Directory.GetFiles(@"Z:");

            ZipFile.CreateFromDirectory(@"Z:\Package", @"Z:\ZipPackage");

            GetAllDownloadedFileList(@"E:\Git\NaviPlannerWPF\NaviPlannerWPF\bin\Debug\NaviPlannerData--11-01-2017\enc\AVCS\ENC_ROOT");
        }

        private static void AddKeyToRegistry()
        {
            // Delete the example key if it exists.
            try
            {
                Registry.CurrentUser.DeleteSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");
                Console.WriteLine("Example key has been deleted.");
            }
            catch (ArgumentException)
            {
                // ArgumentException is thrown if the key does not exist. In
                // this case, there is no reason to display a message.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete the example key: {0}", ex);
                return;
            }

            string user = Environment.UserDomainName + "\\" + Environment.UserName;

            RegistrySecurity rs = new RegistrySecurity();

            // Allow the current user to read and delete the key.
            //
            rs.AddAccessRule(new RegistryAccessRule(user,
                RegistryRights.ReadKey | RegistryRights.Delete,
                InheritanceFlags.None,
                PropagationFlags.None,
                AccessControlType.Allow));

            // Prevent the current user from writing or changing the
            // permission set of the key. Note that if Delete permission
            // were not allowed in the previous access rule, denying
            // WriteKey permission would prevent the user from deleting the 
            // key.
            rs.AddAccessRule(new RegistryAccessRule(user,
                RegistryRights.WriteKey | RegistryRights.ChangePermissions,
                InheritanceFlags.None,
                PropagationFlags.None,
                AccessControlType.Deny));

            // Create the example key with registry security.
            RegistryKey rk = null;
            try
            {
                rk = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System",
                    RegistryKeyPermissionCheck.Default, rs);
                Console.WriteLine("\r\nExample key created.");
                rk.SetValue("ValueName", "StringValue");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\r\nUnable to create the example key: {0}", ex);
            }
            if (rk != null) rk.Close();

            rk = Registry.CurrentUser;

            RegistryKey rk2;

            // Open the key with read access.
            rk2 = rk.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", false);
            Console.WriteLine("\r\nRetrieved value: {0}", rk2.GetValue("ValueName"));
            rk2.Close();

            // Attempt to open the key with write access.
            try
            {
                rk2 = rk.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true);
            }
            catch (SecurityException ex)
            {
                Console.WriteLine("\nUnable to write to the example key." +
                    " Caught SecurityException: {0}", ex.Message);
            }
            if (rk2 != null) rk2.Close();

            // Attempt to change permissions for the key.
            try
            {
                rs = new RegistrySecurity();
                rs.AddAccessRule(new RegistryAccessRule(user,
                    RegistryRights.WriteKey,
                    InheritanceFlags.None,
                    PropagationFlags.None,
                    AccessControlType.Allow));
                rk2 = rk.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", false);
                rk2.SetAccessControl(rs);
                Console.WriteLine("\r\nExample key permissions were changed.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("\nUnable to change permissions for the example key." +
                    " Caught UnauthorizedAccessException: {0}", ex.Message);
            }
            if (rk2 != null) rk2.Close();

            Console.WriteLine("\r\nPress Enter to delete the example key.");
            Console.ReadLine();

            try
            {
                rk.DeleteSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");
                Console.WriteLine("Example key was deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete the example key: {0}", ex);
            }

            rk.Close();

        }

        private static List<EncFileInfo> GetAllDownloadedFileList(string basePath)
        {
            List<EncFileInfo> fileInfos = new List<EncFileInfo>();
            string[] files = Directory.GetFiles(basePath, "*", System.IO.SearchOption.AllDirectories);

            foreach (var item in files)
            {
                try
                {
                    var filePathParts = item.Replace(basePath, "").Trim().Split('\\');
                    fileInfos.Add(new EncFileInfo()
                    {
                        CountryCode = filePathParts[0],
                        CellName = filePathParts[1],
                        EDTN = short.Parse(filePathParts[2]),
                        UPDN = short.Parse(filePathParts[3]),
                        FileName = filePathParts[4],
                        FilePath = item
                    });
                }
                catch (Exception e)
                {
                    //LogMessage($"PRIMAR CellDownloader.GetCatalog031Entries failed for file: {item}, error: {e.Message}", LogLevel.Error);
                    //LogError(e);
                }
            }

            return fileInfos;
        }

    }

    public class EncFileInfo
    {
        public int Id { get; set; }
        public string CellName { get; set; }
        public short EDTN { get; set; }
        public short UPDN { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CountryCode { get; set; }
    }

    namespace Utility
    {
        public class NetworkDrive
        {
            private enum ResourceScope
            {
                RESOURCE_CONNECTED = 1,
                RESOURCE_GLOBALNET,
                RESOURCE_REMEMBERED,
                RESOURCE_RECENT,
                RESOURCE_CONTEXT
            }
            private enum ResourceType
            {
                RESOURCETYPE_ANY,
                RESOURCETYPE_DISK,
                RESOURCETYPE_PRINT,
                RESOURCETYPE_RESERVED
            }
            private enum ResourceUsage
            {
                RESOURCEUSAGE_CONNECTABLE = 0x00000001,
                RESOURCEUSAGE_CONTAINER = 0x00000002,
                RESOURCEUSAGE_NOLOCALDEVICE = 0x00000004,
                RESOURCEUSAGE_SIBLING = 0x00000008,
                RESOURCEUSAGE_ATTACHED = 0x00000010
            }
            private enum ResourceDisplayType
            {
                RESOURCEDISPLAYTYPE_GENERIC,
                RESOURCEDISPLAYTYPE_DOMAIN,
                RESOURCEDISPLAYTYPE_SERVER,
                RESOURCEDISPLAYTYPE_SHARE,
                RESOURCEDISPLAYTYPE_FILE,
                RESOURCEDISPLAYTYPE_GROUP,
                RESOURCEDISPLAYTYPE_NETWORK,
                RESOURCEDISPLAYTYPE_ROOT,
                RESOURCEDISPLAYTYPE_SHAREADMIN,
                RESOURCEDISPLAYTYPE_DIRECTORY,
                RESOURCEDISPLAYTYPE_TREE,
                RESOURCEDISPLAYTYPE_NDSCONTAINER
            }
            [StructLayout(LayoutKind.Sequential)]
            private struct NETRESOURCE
            {
                public ResourceScope oResourceScope;
                public ResourceType oResourceType;
                public ResourceDisplayType oDisplayType;
                public ResourceUsage oResourceUsage;
                public string sLocalName;
                public string sRemoteName;
                public string sComments;
                public string sProvider;
            }
            [DllImport("mpr.dll")]
            private static extern int WNetAddConnection2
                (ref NETRESOURCE oNetworkResource, string sPassword,
                string sUserName, int iFlags);

            [DllImport("mpr.dll")]
            private static extern int WNetCancelConnection2
                (string sLocalName, uint iFlags, int iForce);

            public static void MapNetworkDrive(string sDriveLetter, string sNetworkPath)
            {
                //Checks if the last character is \ as this causes error on mapping a drive.
                if (sNetworkPath.Substring(sNetworkPath.Length - 1, 1) == @"\")
                {
                    sNetworkPath = sNetworkPath.Substring(0, sNetworkPath.Length - 1);
                }

                NETRESOURCE oNetworkResource = new NETRESOURCE()
                {
                    oResourceType = ResourceType.RESOURCETYPE_DISK,
                    sLocalName = sDriveLetter + ":",
                    sRemoteName = sNetworkPath
                };

                //If Drive is already mapped disconnect the current 
                //mapping before adding the new mapping
                if (IsDriveMapped(sDriveLetter))
                {
                    DisconnectNetworkDrive(sDriveLetter, true);
                }

                WNetAddConnection2(ref oNetworkResource, null, null, 0);
            }

            public static int DisconnectNetworkDrive(string sDriveLetter, bool bForceDisconnect)
            {
                if (bForceDisconnect)
                {
                    return WNetCancelConnection2(sDriveLetter + ":", 0, 1);
                }
                else
                {
                    return WNetCancelConnection2(sDriveLetter + ":", 0, 0);
                }
            }

            public static bool IsDriveMapped(string sDriveLetter)
            {
                string[] DriveList = Environment.GetLogicalDrives();
                for (int i = 0; i < DriveList.Length; i++)
                {
                    if (sDriveLetter + ":\\" == DriveList[i].ToString())
                    {
                        return true;
                    }
                }
                return false;
            }

        }

    }

    public class Voyage : DBVoyage
    {
        public Voyage()
        {
            RequiredEncsForVoyage = new List<RequiredEncsForVoyage>();
        }

        [NotMapped]
        public string EncCellNames { get; set; }

        [NotMapped]
        public virtual List<RequiredEncsForVoyage> RequiredEncsForVoyage { get; set; }
    }

    public class RequiredEncsForVoyage : DBRequiredEncsForVoyage
    {

    }

    [Table("Voyages")]
    public partial class DBVoyage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DBVoyage()
        {
            RequiredEncsForVoyage = new HashSet<DBRequiredEncsForVoyage>();
        }

        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int IssuerId { get; set; }

        public DateTime? ETA { get; set; }

        public DateTime? ETD { get; set; }

        public string Destination { get; set; }

        public string Departure { get; set; }

        public string ViaPortNames { get; set; }

        public string PdfFileName { get; set; }

        public string RtzFileName { get; set; }

        public int? RouteStatus { get; set; }

        public int? ProductStatus { get; set; }

        public int? UpdateStatus { get; set; }

        public int? NaviPlannerUserId { get; set; }

        [StringLength(100)]
        public string NaviPlannerUserName { get; set; }

        public string PdfFilePath { get; set; }

        public string RtzFilePath { get; set; }

        public DateTime? UploadedDate { get; set; }

        public DateTime? ChangedDate { get; set; }

        [StringLength(500)]
        public string RouteName { get; set; }

        [StringLength(500)]
        public string SourceName { get; set; }

        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DBRequiredEncsForVoyage> RequiredEncsForVoyage { get; set; }

    }

    [Table("RequiredEncsForVoyage")]
    public partial class DBRequiredEncsForVoyage
    {
        [StringLength(50)]
        public string Id { get; set; }

        public int EncCellId { get; set; }

        public int VoyageId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [Required]
        [StringLength(100)]
        public string EncCellName { get; set; }

        public DateTime? ChangedDate { get; set; }

        [XmlElement("DownloadedIhoBaseEdition")]
        public int? ClientDownloadedIhoBaseEdition { get; set; }

        [XmlElement("DownloadedIhoUpdateNumber")]
        public int? ClientDownloadedIhoUpdateNumber { get; set; }

        [XmlElement("DownloadedIhoUtcDate")]
        public DateTime? ClientDownloadedIhoUtcDate { get; set; }

        [XmlIgnore]
        [ForeignKey("VoyageId")]
        public virtual DBVoyage Voyage { get; set; }
    }
}
