using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSGCompare
{
    public enum MAPIPropertyType
    {
        // This is not a definitive list and may be added to as needed
        PT_APPTIME,
        PT_BINARY,
        PT_BOOLEAN,
        PT_CLSID,
        PT_CURRENCY,
        PT_DOUBLE,
        PT_ERROR,
        PT_FLOAT,
        PT_I2,
        PT_I4,
        PT_I8,
        PT_LONGLONG,
        PT_LONG,
        PT_NULL,
        PT_OBJECT,
        PT_R4,
        PT_R8,
        PT_SHORT,
        PT_STRING8,
        PT_SYSTIME,
        PT_UNICODE,
        PT_UNSPECIFIED
    }
    public class MAPIProperty
    {
        private Int32 _tag;
        private MAPIPropertyType _type;
        private List<string> _exactNames;
        private List<string> _partialNames;
        private string _namedPropName = String.Empty;
        private string _value = String.Empty;
        private string _altValue = String.Empty;

        public MAPIProperty()
        {
            _exactNames = new List<string>();
            _partialNames = new List<string>();
            _value = "";
            _altValue = "";
        }

        public MAPIProperty(Int16 Tag, MAPIPropertyType Type) : this()
        {
            _tag = Tag * 0x10000;
            _type = Type;
        }

        public MAPIProperty(Int32 Tag) : this()
        {
            _tag = Tag;
            _type = MAPITagToType(Tag);
        }

        public Int32 Tag
        {
            get { return _tag; }
            set
            {
                _tag = value;
                _type = MAPITagToType(value);
            }
        }

        public string TagString
        {
            get
            {
                string sHex = String.Format("{0:X}", _tag);
                if (sHex.Length < 8)
                    sHex = new String('0', 8 - sHex.Length) + sHex;
                string sTag = "0x" + sHex;
                return sTag;
            }
            set
            {
                string sTag = value;
                if (sTag.StartsWith("0x"))
                {
                    // Hex number
                    _tag = Int32.Parse(sTag.Substring(2), System.Globalization.NumberStyles.HexNumber);
                    _type = MAPITagToType(_tag);
                }
                else
                {
                    // Assume decimal number
                    _tag = Convert.ToInt32(sTag);
                    _type = MAPITagToType(_tag);
                }
            }
        }

        public string Name
        {
            get
            {
                string name = "";
                if (_exactNames.Count > 0)
                {
                    foreach (string sName in _exactNames)
                    {
                        if (sName.StartsWith("PR_"))
                        {
                            name = sName;
                            break;
                        }
                    }
                }
                if (_partialNames.Count > 0)
                {
                    foreach (string sName in _partialNames)
                    {
                        if (sName.StartsWith("PR_"))
                        {
                            name = sName;
                            break;
                        }
                    }
                }
                if (String.IsNullOrEmpty(name))
                    name = this.TagString;
                return name;
            }
        }

        public string NamedPropName
        {
            get { return _namedPropName; }
            set { _namedPropName = value; }
        }

        private MAPIPropertyType MAPITagToType(Int32 Tag)
        {
            Int16 iType = (Int16)(Tag & 0xFFFF);
            MAPIPropertyType Type;
            switch (iType)
            {
                case 0x0B: { Type = MAPIPropertyType.PT_BOOLEAN; break; }
                case 0x1E: { Type = MAPIPropertyType.PT_STRING8; break; }
                case 0x0102: { Type = MAPIPropertyType.PT_BINARY; break; }
                case 0x40: { Type = MAPIPropertyType.PT_SYSTIME; break; }
                case 0x03: { Type = MAPIPropertyType.PT_LONG; break; }
                case 0x05: { Type = MAPIPropertyType.PT_DOUBLE; break; }
                default: { Type = MAPIPropertyType.PT_UNSPECIFIED; break; }
            }
            return Type;
        }

        public List<string> ExactNames
        {
            get { return _exactNames; }
        }

        public List<string> PartialNames
        {
            get { return _partialNames; }
        }

        public string StringValue
        {
            get { return _value; }
            set
            {
                _value = value;
            }
        }

        public byte[] BinaryValue
        {
            // This property represents the value as a byte array
            get
            {
                if (!(_value.StartsWith("cb: "))) return null;
                string sValue = _value.Substring(4);
                string[] sTemp=sValue.Split(' ');
                int iLength = Convert.ToInt32(sTemp[0]);
                byte[] aValue = new byte[iLength];
                for (int i = 0; i < iLength; i++)
                {
                    aValue[i] = Convert.ToByte(sTemp[2].Substring(i * 2, 2));
                }
                return aValue;
            }
            set
            {
                _value = "cb: " + value.Length.ToString() + " lpb: ";
                for (int i = 0; i < value.Length; i++)
                {
                    _value += value[i].ToString();
                }
            }
            
        }

        public long LongValue
        {
            get
            {
                return Convert.ToInt64(_value);
            }
            set
            {
                _value = Convert.ToString(value);
                _altValue="0x" + String.Format("{0:X}", _value);
            }
        }

        public string AltValue
        {
            get
            {
                return _altValue;
            }
            set
            {
                _altValue = value;
            }
        }

        public string StringType
        {
            get
            {
                return _type.ToString();
            }
        }
    }
}
