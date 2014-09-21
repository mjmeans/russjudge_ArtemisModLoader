﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RussLibrary.Xml;
using RussLibrary.WPF;
using System.Xml;
using System.Windows;
using RussLibrary;

namespace DMXCommander.Xml
{
    public class EventCollection: ChangeDependentCollection<EventObject>, IXmlStorage
    {
        public EventCollection()
        {

            Storage = new List<XmlNode>();
        }
      

       
        protected override void ProcessValidation()
        {
            
           
        }

        public IList<System.Xml.XmlNode> Storage { get; private set; }
    }
}
