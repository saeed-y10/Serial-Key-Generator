using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeyGeneratorLibrary
{
    public class clsKeyGenerator
    {
        public clsKeyGenerator()
        {
            this._TotalKeys = 5;
            _Keys = new string[5];
            this._KeyLength = 5;
            this._PartLength = 5;
            this._KeyType = enKeyType.Letters;
            this._LetterType = enLetterType.Capital;
            this._DefaultPath = @"C:\Users\Public\Documents\Keys.txt";
        }

        public clsKeyGenerator(Byte TotalKeys, Byte KeyLength, Byte PartLength, enKeyType keyType, enLetterType LetterType, String DefaultPath = @"C:\Users\Public\Documents\")
        {
            this._TotalKeys = TotalKeys;
            _Keys = new string[_TotalKeys];
            this._KeyLength = KeyLength;
            this._PartLength = PartLength;
            this._KeyType = keyType;
            this._LetterType = LetterType;
            this._DefaultPath = DefaultPath;

            _rand = new Random();
        }

        static clsKeyGenerator()
        {
            clsKeyGenerator._rand = new Random();
        }

        public enum enKeyType : byte
        {
            Letters = 1,
            Numbers = 2,
            Random = 3
        }

        public enum enLetterType : byte
        {
            Small = 1,
            Capital = 2,
            Random = 3
        }

        private byte _TotalKeys;
        private byte _KeyLength;
        private byte _PartLength;
        private enKeyType _KeyType;
        private enLetterType _LetterType;
        private string _DefaultPath;
        private string[] _Keys;
        private static Random _rand;

        public enKeyType KeyType
        {
            set
            {

                if (value != enKeyType.Numbers && value != enKeyType.Letters && value != enKeyType.Random)
                    throw new ArgumentException("invalid enum value");

                _KeyType = value;
            }

            get
            {
                return _KeyType;
            }
        }

        public enLetterType LetterType
        {
            set
            {
                if (value != enLetterType.Capital && value != enLetterType.Small && value != enLetterType.Random)
                    throw new ArgumentException("invalid enum value");

                _LetterType = value;
            }

            get
            {
                return _LetterType;
            }
        }

        public byte TotalKeys
        {
            set
            {
                if (!byte.TryParse(value.ToString(), out _TotalKeys))
                    throw new ArgumentException("invalid input");

                if (value <= 0)
                    _TotalKeys = 1;
                else
                    _TotalKeys = value;
            }

            get
            {
                return _TotalKeys;
            }
        }

        public byte KeyLength
        {
            set
            {
                if (!byte.TryParse(value.ToString(), out _KeyLength))
                    throw new ArgumentException("invalid input");

                if (value <= 0)
                    _KeyLength = 1;
                else
                    _KeyLength = value;
            }

            get
            {
                return _KeyLength;
            }
        }

        public byte PartLenth
        {
            set
            {
                if (!byte.TryParse(value.ToString(), out _PartLength))
                    throw new ArgumentException("invalid input");

                if (value <= 0)
                    _PartLength = 5;
                else
                    _PartLength = value;
            }

            get
            {
                return _PartLength;
            }
        }

        public string[] Keys
        {
            get
            {
                return _Keys;
            }
        }

        private static bool _IsValidLetterType(enLetterType LetterType)
        {
            return (LetterType == enLetterType.Capital || LetterType == enLetterType.Small || LetterType == enLetterType.Random);
        }

        private static bool _IsValidKeyType(enKeyType KeyType)
        {
            return (KeyType == enKeyType.Letters || KeyType == enKeyType.Numbers || KeyType == enKeyType.Random);
        }

        private static bool IsValidPath(string Path)
        {
            return System.IO.Directory.Exists(Path);
        }

        public string DefaultPath
        {
            set
            {
                if (IsValidPath(value))
                    _DefaultPath = value;

                else
                    _DefaultPath = @"C:\Users\Public\Documents\Keys.txt";
            }

            get
            {
                return _DefaultPath;
            }
        }

        private static char _GetRandomNumber()
        {
            return ((char)_rand.Next(49, 57));
        }

        private static enKeyType _GetRandomKeyType()
        {
            return (enKeyType)((byte)_rand.Next(1, 3));
        }

        private static enLetterType _GetRnadomLetterType()
        {
            return (enLetterType)((byte)_rand.Next(1, 3));
        }

        private static char _GetRandomLetter(enLetterType LetterType)
        {
            if (LetterType == enLetterType.Random)
                LetterType = _GetRnadomLetterType();

            switch (LetterType)
            {
                case enLetterType.Small:
                    return ((char)_rand.Next(97, 122));

                case enLetterType.Capital:
                    return ((char)_rand.Next(65, 90));
            }

            return ((char)_rand.Next(97, 122));
        }

        private static char _GetRandomCharacter(enKeyType KeyType, enLetterType LetterType)
        {
            if (KeyType == enKeyType.Random)
                KeyType = _GetRandomKeyType();

            if (KeyType == enKeyType.Numbers)
                return _GetRandomNumber();

            return _GetRandomLetter(LetterType);
        }

        private static string _GenerateKeyPart(byte Length, enKeyType KeyType = enKeyType.Letters, enLetterType LetterType = enLetterType.Capital)
        {
            string Part = string.Empty;

            for (byte i = 0; i < Length; i++)
            {
                Part += _GetRandomCharacter(KeyType, LetterType);
            }

            return Part;
        }

        public static string GenerateKey(byte KeyLength, byte PartLength, enKeyType KeyType = enKeyType.Letters, enLetterType LetterType = enLetterType.Capital, string Seperator = "-")
        {
            if (PartLength <= 0)
                return null;

            if (KeyLength <= 0)
                return null;

            if (!_IsValidKeyType(KeyType))
                return null;

            if (!_IsValidLetterType(LetterType))
                return null;

            string Key = "";

            for (byte i = 0; i < KeyLength; i++)
            {
                Key += _GenerateKeyPart(PartLength, KeyType, LetterType) + Seperator;
            }

            return Key.Substring(0, Key.Length - 1);
        }

        public string GenerateKey()
        {
            string Key = "";

            for (byte i = 0; i < KeyLength; i++)
            {
                Key += _GenerateKeyPart(_PartLength, _KeyType, _LetterType) + "-";
            }

            return Key.Substring(0, Key.Length - 1);
        }

        public static string[] GenerateKeys(byte TotalKeys, byte KeyLength, byte PartLength, enKeyType KeyType, enLetterType LetterType, string Seperator)
        {
            if (TotalKeys <= 0)
                return null;
            
            if (PartLength <= 0)
                return null;
            
            if (KeyLength <= 0)
                return null;

            if (!_IsValidKeyType(KeyType))
                return null;

            if (!_IsValidLetterType(LetterType))
                return null;

            string[] arrKeys = new string[TotalKeys];

            for (byte i = 0; i < TotalKeys; i++)
            {
                arrKeys[i] = (GenerateKey(KeyLength, PartLength, KeyType, LetterType, Seperator));
            }

            return arrKeys;
        }

        public void GenerateKeys(byte TotalKeys, byte KeyLength, byte PartLength, enKeyType KeyType, enLetterType LetterType)
        {
            _Keys = GenerateKeys(TotalKeys, KeyLength, PartLenth, KeyType, LetterType, "-");
        }

        public void GenerateKeys()
        {
            _Keys = GenerateKeys(TotalKeys, KeyLength, PartLenth, KeyType, LetterType, "-");
        }

        public static bool SaveTo(string[] listKeys, string Path)
        {
            //Path.Trim();

            //if (!IsValidPath(Path))
            //    Path = @"C:\Users\Public\Documents\Keys.txt";

            //if (!Path.EndsWith("\\"))
            //    Path += "\\";

            //Path = Path.Substring(0, Path.Length - Path.LastIndexOf('\\'));

            string Keys = string.Empty;

            foreach (string v in listKeys)
                Keys += v + "\n";

            //if (System.IO.Path.HasExtension(Path))
            //    Path = System.IO.Path.ChangeExtension(Path, "txt");
            //else
            //    Path += "Keys.txt";

            FileStream File = new FileStream(Path, FileMode.Create);

            if (!File.CanWrite)
            {
                File.Close();

                return false;
            }

            byte[] data = Encoding.UTF8.GetBytes(Keys);

            File.Write(data, 0, data.Length);

            File.Close();

            return true;
        }

        public bool SaveTo()
        {
            return SaveTo(_Keys, DefaultPath);
        }

        public bool SaveTo(string Path)
        {
            return SaveTo(_Keys, Path);
        }
    }
}
