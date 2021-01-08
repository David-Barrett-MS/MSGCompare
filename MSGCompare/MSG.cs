using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MSGCompare
{
    public class MSG
    {
        private List<MAPIProperty> _properties;
        private List<int> _propertyTags;

        public MSG()
        {
            _properties = new List<MAPIProperty>();
            _propertyTags = new List<int>();
        }

        public List<MAPIProperty> Properties
        {
            get
            {
                return _properties;
            }
        }

        public void ParseFromXML(string XMLFile)
        {
            if (!File.Exists(XMLFile)) return;

            // Read all the properties
            XMLPropertyReader oReader = new XMLPropertyReader(XMLFile);
            oReader.ReadXML(this);

            // Create an index of the property tags (will speed up comparisons later)
            _propertyTags = new List<int>();
            foreach (MAPIProperty oProperty in _properties)
            {
                _propertyTags.Add(oProperty.Tag);
            }
        }

        public bool ContainsProperty(int Tag)
        {
            return _propertyTags.Contains(Tag);
        }

        public MAPIProperty Property(int Tag)
        {
            // Return the property with the given tag
            if (!_propertyTags.Contains(Tag))
                return null;

            foreach (MAPIProperty oProperty in _properties)
            {
                if (oProperty.Tag == Tag)
                    return oProperty;
            }

            return null;
        }
    }
}
