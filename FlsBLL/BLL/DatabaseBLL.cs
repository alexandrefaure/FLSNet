using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.IO;
using System.Reflection;
using FormotsCommon.DTO;
using FormotsDAL.DAL;

namespace FormotsBLL.BLL
{
    public class DatabaseBLL
    {
        protected static DatabaseBLL _current = new DatabaseBLL();

        public static DatabaseBLL Current
        {
            get
            {
                return _current;
            }
        }

        public void CreateIfNotExists()
        {
            //var fileName = "FormotsDatabase.sdf";
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //// Set the data directory to the users %AppData% folder            
            //// So the database file will be placed in:  C:\\Users\\<Username>\\AppData\\Roaming\\            
            //AppDomain.CurrentDomain.SetData("DataDirectory", path);
            //string solutiondir = Directory.GetParent(
            //    Directory.GetCurrentDirectory()).Parent.FullName;
            //string[] names = typeof(Database).Assembly.GetManifestResourceNames();
            //string saveDir = Directory.GetCurrentDirectory();
            ////var tititit = FormotsDAL.Resources.


            ////var formotsDal = System.Reflection.Assembly.LoadFrom("FormotsDAL").GetManifestResourceStream("FormotsDatabase.sdf");
            //// Enure that the database file is present
            //if (!System.IO.File.Exists(System.IO.Path.Combine(path, fileName)))
            //{
            //    //Get path to our .exe, which also has a copy of the database file
            //    var exePath = System.IO.Path.GetDirectoryName(
            //        new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            //    //Copy the file from the .exe location to the %AppData% folder
            //    System.IO.File.Copy(
            //        System.IO.Path.Combine(exePath, fileName),
            //        System.IO.Path.Combine(path, fileName));
            //}
            DatabaseDAL.CreateIfNotExists();

            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "MyCompany.MyProduct.MyFile.txt";

            //using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    string result = reader.ReadToEnd();
            //}
        }
    }
}
