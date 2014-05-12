using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Dnd_4e_Character_Assistant.Persistance
{
    public class CharacterFile :ICharacterPersistance
    {
        const string CommentSymbol = "#";

        private string _fileName;
        public CharacterFile(string file) {
            _fileName = file;
        }

        private Dictionary<string, string> _fileKV = null;
        private Dictionary<string, string> FileKV { get {
            if (_fileKV == null) {
                LoadFile();
            }
            return _fileKV;
        } }

        public string Get(string key) {
            if (!FileKV.ContainsKey(key)) { throw new Exception(string.Format("Property {0} not found in file", key)); }
            return FileKV[key];
        }
        public void Set(string key, string value) {
            //Load any external changes
            LoadFile();
            FileKV[key] = value;
            //Now save FileKV back to the file
            SaveFile();
        }


        private void LoadFile()
        {
            Dictionary<string, string> kv = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(_fileName)) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();

                    if (line.StartsWith(CommentSymbol)) { continue; }

                    string[] p = line.Split('=');
                    kv[p[0]] = p[1];
                }
            }
            _fileKV = kv;
        }

        private void SaveFile()
        {
            using (StreamWriter sw = new StreamWriter(_fileName)) {
                foreach (string key in _fileKV.Keys) {
                    sw.WriteLine(string.Format("{0}={1}", key, _fileKV[key]));
                }
                sw.Flush();
            }
        }

    }
}
