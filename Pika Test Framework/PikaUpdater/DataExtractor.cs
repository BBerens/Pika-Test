using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;


namespace PikaUpdater
{
    class DataExtractor
    {
        System.IO.FileSystemWatcher watcher;
        string directoryToWatch;

        public DataExtractor(string path)
        {
            watcher = new System.IO.FileSystemWatcher();
            directoryToWatch = path;
        }

        public void watch()
        {
            watcher.Path = directoryToWatch;
            watcher.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName | System.IO.NotifyFilters.LastWrite;
            watcher.Filter = "TestResult.xml";
            watcher.Created += new System.IO.FileSystemEventHandler(OnChanged);

        }

        public void OnChanged(object sender, System.IO.FileSystemEventArgs e)
        {
            
        }


    }
}
