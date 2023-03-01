using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;


namespace Encrypt.Model.Engine
{
   internal class SearchEngine
    {
        private readonly EngineOptions _engineOptions;
            private bool _stop;
        private Task<List<SearchResult>> _currentTask;
       

        public SearchEngine(EngineOptions engineOptions)
        {
            if (engineOptions == null) throw new ArgumentNullException("engineOptions");

            _engineOptions = engineOptions;
        }
       
                }
            }
    
