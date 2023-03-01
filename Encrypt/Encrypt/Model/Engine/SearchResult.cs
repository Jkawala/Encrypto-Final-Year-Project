using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.IO;


namespace Encrypt.Model.Engine
{
    class SearchResult
    {
        public SearchResult(FileSystemInfo fileSystemInfo)
        {
            this.FileSystemInfo = fileSystemInfo;
        }

        public FileSystemInfo FileSystemInfo { get; private set;  }
    }

}
