using System;
using System.Collections.Generic;
using System.IO;

namespace Dnd_4e_Character_Assistant.Persistance
{
	public class PersistantFile{
		const string CommentSymbol = "#";

		  private string _fileName;
        public PersistantFile(string file) {
            _fileName = file;
			LoadFile();
        }

		protected Dictionary<string, string> FileKV { get; private set; }


		   protected string Get(string key) {
            if (!FileKV.ContainsKey(key)) { throw new Exception(string.Format("Property {0} not found in file", key)); }
            return FileKV[key];
        }

		 private void LoadFile()
        {
            Dictionary<string, string> kv = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(_fileName)) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();

                    if (line.StartsWith(CommentSymbol)) { continue; }

					int ind = line.IndexOf('=');
					kv[line.Substring(0,ind)] = line.Substring(ind+1);
                    //string[] p = line.Split('=');
                    //kv[p[0]] = p[1];
                }
            }
            FileKV = kv;
        }

	}

	public class FeatFileFeat{

		public FeatFileFeat(){
			FileKV = new Dictionary<string, string>();
		}

		/*Creates the object from the given string*/
		public static FeatFileFeat Load (string str)
		{
			FeatFileFeat ret = new FeatFileFeat ();
			string[] data = str.Split ('|');
			foreach (string s in data) {
				if(s.Contains("=")){
				string[] d = s.Split('=');
				ret.Set(d[0],d[1]);
				}else{
					ret.Set(s,"");
				}
			}
			return ret;
		}

		protected Dictionary<string, string> FileKV { get; private set;}

		private void Set(string key, string value){
			FileKV[key] = value;
		}

		   public string Get(string key) {
			if (!FileKV.ContainsKey(key)) {return ""; }
            return FileKV[key];
        }


	}

	/*This file and CharacterFile could be dried up a bit*/
	public class FeatFile : PersistantFile
	{
		public FeatFile(string file):base(file){
			LoadFeats();
		}

		private Dictionary<string, FeatFileFeat> FeatKV { get; set; }

		public FeatFileFeat GetFeat(string key) {
            if (!FeatKV.ContainsKey(key)) { throw new Exception(string.Format("Feat {0} not found in file", key)); }
            return FeatKV[key];
        }

		private void LoadFeats ()
		{
			FeatKV = new Dictionary<string, FeatFileFeat>();
			foreach (string featName in FileKV.Keys) {
				FeatKV.Add(featName,FeatFileFeat.Load(Get(featName)));
			}
		}


	}
}

